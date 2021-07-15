using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ADSTwinCat3
{
    class DataAnalysis
    {
        private List<int> tabState;
        private List<string> limitSwitches;//private string[] limitSwitches = { "X5", "X6", "X8", "X7" };
        public DataAnalysis()
        {
            tabState = new List<int>();
            limitSwitches = new List<string>();
        }
        ~DataAnalysis()
        { 
        
        }
        public void convert(string[] fileData, char separator)
        {
            
            int iter = 0;
            foreach (string line in fileData)
            {
                string[] columns = line.Split(separator);
                if (iter == 0)
                {
                    foreach (string column in columns)
                    {
                        limitSwitches.Add(column);
                    }
                    iter = iter + 1;
                }
                else
                {
                    int suma = 0;
                    int iter2 = columns.Length;
                    foreach (string column in columns)
                    {
                        
                        iter2 = iter2 - 1;
                        //int pom =(2 ^ iter2);
                        int pom = 0;
                        bool success = Int32.TryParse(column, out pom);
                        //  Console.WriteLine(success +"    "+pom+" "+column );
                        if (success)
                        {
                            suma = (int)(suma + pom * Math.Pow(2.0, Convert.ToDouble(iter2)));
                        }
                    }
                    tabState.Add(suma);
                    iter = iter + 1;
                }
            }
            int b = 0;
        }
        public List<string> getLimitSwitches()
        {
            return limitSwitches;
        }
        public List<int> getTabState()
        {
            return tabState;
        }
    }
}
