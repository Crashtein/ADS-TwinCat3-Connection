using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSTwinCat3
{
    class CDataTable
    {
        public static readonly char[] delimiterChars = { ' ', ',', '.', ':', '\t', ';' };
        private string[] columnNames = null;
        private string[] varNames = null;
        private List<string[]> dataList { get; set; }
        private int dataType = 0;   //0 - Int32;1 - boolean
        public static string[] splitString(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                return null;
            }
            string[] textSplitted = text.Split(delimiterChars);
            return textSplitted;
        }
        public void setColumnNames(string[] colNames)
        {
            columnNames = colNames;
        }
        public void addRow(string[] row)
        {
            dataList.Add(row);
        }
        public void resetData()
        {
            dataList = null;
            columnNames = null;
        }
        public List<string[]> getDataList()
        {
            return dataList;
        }
        public string[] getColumnNames()
        {
            return columnNames;
        }
        public void setVarNames(string[] names)
        {
            varNames = names;
        }
        public string[] getVarNames()
        {
            return varNames;
        }
        public void setType(int type)
        {
            dataType = type;
        }
        public int getType()
        {
            return dataType;
        }
    }
}
