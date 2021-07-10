using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ADSTwinCat3
{
    class CStreamFile
    {
        private StreamWriter file = null;
        private string fileName = null;
        public CStreamFile(string filename)
        {
            fileName = filename;
            OpenStream();
        }
        ~CStreamFile()
        {
            //CloseStream();
        }
        public void OpenStream()
        {
            file = new StreamWriter(fileName, append: false);
        }
        public void CloseStream()
        {
            if(file!=null)
                file.Dispose();
        }
        public void Write(string line)
        {
            file.WriteLine(line);
            file.Flush();
        }
        public string getFileName()
        {
            return fileName;
        }
    }
}
