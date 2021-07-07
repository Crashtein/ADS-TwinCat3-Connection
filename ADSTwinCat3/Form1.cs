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
        private ADSConnection Connection = new ADSConnection();
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
            ConnectBox.Text = Connection.Connect();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            int nBytes = Convert.ToInt32(NBytesBox.Value);
            uint area = Convert.ToUInt32(AreaBox.Value);
            uint type = Convert.ToUInt32(TypeBox.Value);
            string date = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff");
            ReadBox.AppendText("\r\n"+date+"    "+Connection.ReadVariables(area,nBytes,type));
        }

        private void ReadByNameButton_Click(object sender, EventArgs e)
        {
            int nBytes = Convert.ToInt32(NBytesBox.Value);
            string varNames = VarNameBox.Text;
            string date = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff");
            ReadBox.AppendText("\r\n" + date + "    " + varNames + "=" + Convert.ToString(Connection.ReadInt32VariablesByName(varNames)));
        }
    }
}
