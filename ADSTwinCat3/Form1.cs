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


        private List<int> tabState=null;
        private List<string> limitSwitches=null;//private string[] limitSwitches = { "X5", "X6", "X8", "X7" };
        private List<int> pastStates;
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

                Console.WriteLine("Start reading without loading");
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
                string[] varNamesSplit = varNames.Split(';');
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
            //currentState = Int32.Parse(results[0]) * 8 + Int32.Parse(results[1]) * 4 + Int32.Parse(results[2]) * 2 + Int32.Parse(results[3]) * 1;

            if (pastStates.Last()!=currentState)
            {           

                //              private List<int> tabState = null;
                //      private List<string> limitSwitches = null;//private string[] limitSwitches = { "X5", "X6", "X8", "X7" };
                //    private List<int> pastStates;
                errorSwitches = true;
                for (int i = 0; i < tabState.Count; i++)
                {

                    if (tabState[i] == currentState)
                    {
                        int iterPastStates = pastStates.Count - 1;
                        int iterFromEnd = 0;
                        for (int iterComparisons = numberOfCheksStates - 2; iterComparisons >= 0; iterComparisons--)
                        {
                            int iterComp = 0;//the same what iterComparison but calculate from zero
                            if (iterPastStates >= 0)//check if we have enough elements in work fistory - pastStates
                            {
                                if (i - 1 - iterComp >= 0)// check if tabState ends and we have to start from the end of our tabStates, i-current state, i-1 - last state
                                {

                                    if (pastStates[iterPastStates] != tabState[i - 1 - iterComp])
                                    {
                                        errorSwitches = true;
                                        break;
                                    }
                                    else
                                    {
                                        errorSwitches = false;
                                    }

                                }
                                else
                                {
                                    iterFromEnd++;
                                    if (pastStates[iterPastStates] != tabState[tabState.Count - iterFromEnd])
                                    {
                                        errorSwitches = true;
                                        break;
                                    }
                                    else
                                    {
                                        errorSwitches = false;
                                    }
                                }
                            }
                            iterComp++;
                            iterPastStates--;
                        }
                    }
                }
                        pastStates.Add(currentState);








                        /*
                        
                        
                        
                        
                        for (int j = 0; j < numberOfCheksStates; j++)
                        {
                            if (pastStates.Count - j - 2 >= 0)
                            {
                                if ()
                                    if (pastStates[pastStates.Count - j - 2] ==)
                        }
                            else
                            {
                                break;
                            }
                        }
                    }
                }

                if (currentState == lastState && (10 == lastLastState && 10 == lastState && 10 == currentState))
                {

                    errorSwitches = false;
                }
                else if (currentState == lastState && !(10 == lastLastState && 10 == lastState && 10 == currentState))
                { }
                else if (10 == lastLastState && 10 == lastState && 2 == currentState)
                {
                    errorSwitches = false;
                }
                else
                {
                    int iter = 2;
                    errorSwitches = true;
                    */
                        /*  while (iter < tabState.Length)
                        {
                            if (tabState[iter] == currentState && tabState[iter - 1] == lastState && tabState[iter - 2] == lastLastState)
                            {
                                errorSwitches = false;
                            }

                            iter = iter + 1;

                        }*/
                        /*  lastLastState = lastState;
                          lastState = currentState;
                      }

                      */




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
           
        }



        private void StopReadingButton_Click(object sender, EventArgs e)
        {
            timer.Dispose();
        }
        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            tabState = new List<int>();
            limitSwitches = new List<string>();


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

            }
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
