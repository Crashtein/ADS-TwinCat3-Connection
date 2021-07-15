using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ADSTwinCat3
{
    public partial class Form1 : Form
    {
        private ADSConnection Connection = null;
        private CDataTable data = null;
        private Timer timer = null;
        private CStreamFile fileStream = null;
        private CStreamFile fileStream1 = null;
        private DataAnalysis a = null;
        private dataValidationAlgorithm dVA = null;

        private List<int> tabState=null;
        private List<string> limitSwitches=null;//private string[] limitSwitches = { "X5", "X6", "X8", "X7" };
        private List<int> pastStates=null;
        private int numberOfCheksStates = 3;





        string varNames = null;
        string[] varNamesSplit = null;

//To przenieść, lista wszystkich nowych stanów i nakładam na to tablicę tabState


//-1 - nie występuje 
//stan wczytuje z pliku

        private int lastLastState = 10;
        private int lastState = 10;
        private bool errorSwitches = false;



        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            
            if (Connection != null)
            {
                Connection.Dispose();
            }
            Connection = new ADSConnection(addressBox.Text,Convert.ToInt32(PortNBox.Value));
            ConnectBox.Text = Connection.Connect();
        }

        private void StartReadingButton_Click(object sender, EventArgs e)
        {
            if(null!=tabState || null!= limitSwitches) //check if data was load
            {
                if (timer != null)
                {
                    timer.Dispose();
                }
                if (fileStream == null || fileStream.getFileName() != FileNameBox.Text)
                {
                    if (fileStream != null)
                    {
                        fileStream.CloseStream();
                    }
                    fileStream = new CStreamFile(FileNameBox.Text, false, true);
                }
                string varNames = null;
                foreach (string str in limitSwitches)
                {
                    if (null == varNames)
                    {
                        varNames = str;
                    }
                    else
                    {
                        varNames = varNames + ";" + str;
                    }
                }
                Console.WriteLine(varNames);
                varNamesSplit = varNames.Split(';');
                string[] timestampName = { "Timestamp" };
                string[] colNames = timestampName.Concat(varNamesSplit).ToArray();


                bool empty = false;
                if (data == null)
                {
                    empty = true;
                }
                if (empty || !varNamesSplit.SequenceEqual(data.getVarNames()))
                {
                    data = new CDataTable();
                    data.setColumnNames(colNames);
                    data.setVarNames(varNamesSplit);
                    data.setType(0);
                    string line = string.Join(";", data.getColumnNames());
                    if (ShowLogsBox.Checked)
                    {
                        ReadBox.Text = line;
                    }
                    if (SaveToFileBox.Checked)
                    {
                        fileStream.Write("\"" + string.Join("\";\"", data.getColumnNames()) + "\"");
                    }

                }
                // ReadBox.AppendText("\r\n" + date + "    " + varNames + "=" + Convert.ToString(Connection.ReadInt32VariablesByName(varNamesSplit)));
                timer = new Timer();
                timer.Tick += new EventHandler(update);
                timer.Interval = Convert.ToInt32(timerNBox.Value); //in ms
                timer.Start();

                
            }
            
        }
        private void update(object sender, EventArgs e)
        {
        string[] results = null;
        int currentState =0;
            
            results = Connection.ReadInt32VariablesByName(varNamesSplit).Select(i=>i.ToString()).ToArray();

            int iter2 = results.Length;  //converter which change state from binary to decimal 
            foreach (string column in results)
            {
                iter2 = iter2 - 1;
                int pom = (2 ^ iter2);
                currentState = (int)(currentState + Convert.ToInt32(column) * Math.Pow(2.0, Convert.ToDouble(iter2)));
            }
            Console.WriteLine("currentState: "+ currentState);
            

            if (pastStates.Count !=0)
            {
                Console.WriteLine("pastStates.count>0");
                if (pastStates.Last() != currentState)
                {
                    errorSwitches = dVA.camel(pastStates, currentState);
                    pastStates.Add(currentState);

                }
                

            }
            else
            {

                errorSwitches = dVA.camel(pastStates, currentState);
                pastStates.Add(currentState);
            }

            if (true == errorSwitches)
            {
                string[] date = { DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") };
                string[] err = { "An error relating to the limit switches has occurred" };
                string[] row = date.Concat(err).ToArray();//Tu doadac wystąpienie błedu 

                string line = string.Join(";", row);
                if (ShowLogsBox.Checked)
                {
                    ReadBox.AppendText("\r\n" + string.Join(";", row));
                }
                if (SaveToFileBox.Checked)
                {
                    fileStream.Write("\"" + string.Join("\";\"", row) + "\"");
                }

            }



        }



        private void StopReadingButton_Click(object sender, EventArgs e)
        {
            timer.Dispose();
        }
        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            tabState = new List<int>();
            limitSwitches = new List<string>();
            pastStates = new List<int>();

        DataAnalysis a = new DataAnalysis();
            fileStream1 = new CStreamFile(textBox1.Text, true, false);
            if(fileStream1 !=null)
            {
                string[] a1 = fileStream1.Read();
                fileStream1.CloseStream();
                a.convert(a1, '	');
                tabState = a.getTabState();
                limitSwitches = a.getLimitSwitches();



                int pom = 0;
                bool success = Int32.TryParse(numberOfStates.Text, out pom);
                if (success)
                {
                    numberOfCheksStates = pom;
                }
                dVA = new dataValidationAlgorithm(tabState, numberOfCheksStates);
            
               
                

            }
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
