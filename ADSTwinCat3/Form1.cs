using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADSTwinCat3
{
    public partial class Form1 : Form
    {
        private ADSConnection Connection = null;
        private CDataTable data = null;
        private Timer timer = null;
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
            
            
            string varNames = VarNameBox.Text;
            string[] varNamesSplit = CDataTable.splitString(varNames);
            string[] timestampName = { "Timestamp" };
            string[] colNames = timestampName.Concat(varNamesSplit).ToArray();
            bool empty = false;
            if (data == null)
            {
                empty = true;
            }
            if (empty || !varNamesSplit.SequenceEqual(data.getVarNames()) || !ReadAsBooleanRadioButton.Checked==Convert.ToBoolean(data.getType()))
            {
                data = new CDataTable();
                data.setColumnNames(colNames);
                data.setVarNames(varNamesSplit);
                if (ReadAsInt32RadioButton.Checked)
                {
                    data.setType(0);
                }
                else if (ReadAsBooleanRadioButton.Checked)
                {
                    data.setType(1);
                }
                ReadBox.Text=string.Join(";", data.getColumnNames());
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
            if (data.getType()==0)
            {
                results = Connection.ReadInt32VariablesByName(data.getVarNames()).Select(i => i.ToString()).ToArray();
            }
            else if (data.getType()==1)
            {
                results = Connection.ReadBooleanVariablesByName(data.getVarNames()).Select(i => i.ToString()).ToArray();
            }
            string[] date = { DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") };
            string[] row = date.Concat(results).ToArray();
            //data.addRow(row);

            ReadBox.AppendText("\r\n"+string.Join(";", row));
        }

        private void StopReadingButton_Click(object sender, EventArgs e)
        {
            timer.Dispose();
        }
    }
}
