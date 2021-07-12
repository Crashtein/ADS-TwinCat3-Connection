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
            if (timer != null)
            {
                timer.Dispose();
            }
            if (fileStream == null || fileStream.getFileName()!=FileNameBox.Text)
            {
                if (fileStream != null)
                {
                    fileStream.CloseStream();
                }
                fileStream = new CStreamFile(FileNameBox.Text);
            }


        
       // string varNames = VarNameBox.Text;
            string[] varNamesSplit = limitSwitches;
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
                
                
          /*      string line = string.Join(";", data.getColumnNames());
                if (ShowLogsBox.Checked)
                {
                    ReadBox.Text = line;
                }
                if (SaveToFileBox.Checked)
                {
                    fileStream.Write("\""+string.Join("\";\"", data.getColumnNames())+"\"");
                }*/
                
            }
            //ReadBox.AppendText("\r\n" + date + "    " + varNames + "=" + Convert.ToString(Connection.ReadInt32VariablesByName(varNamesSplit)));
            timer = new Timer();
            timer.Tick += new EventHandler(update);
            timer.Interval = Convert.ToInt32(timerNBox.Value); //in ms
            timer.Start();
        }
        private void update(object sender, EventArgs e)
        {



       

        string[] results = null;
            int currentState =0;
       
                results = Connection.ReadInt32VariablesByName(limitSwitches).Select(i=>i.ToString()).ToArray();
                currentState = Int32.Parse(results[0]) * 8 + Int32.Parse(results[1]) * 4 + Int32.Parse(results[2]) * 2 + Int32.Parse(results[3]) * 1;

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
                while (iter < tabState.Length)
                {
                    if (tabState[iter] == currentState && tabState[iter - 1] == lastState && tabState[iter - 2] == lastLastState)
                    {
                        errorSwitches = false;
                    }

                    iter = iter + 1;

                }
                lastLastState = lastState;
                lastState = currentState;
            }



            if (true == errorSwitches)
            {
                string[] date = { DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") };
                string[] err = { "An error relating to the limit switches has occurred"};
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
    }
}
