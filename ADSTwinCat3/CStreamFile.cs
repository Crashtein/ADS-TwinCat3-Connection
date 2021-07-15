﻿using System;
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
        private StreamReader fileR = null;
        private string fileName = null;
        private string errors = null;
        public CStreamFile(string filename, bool readFile, bool writeFile)
        {
            fileName = filename;
            if (true == readFile)
            {
                OpenStreamR();
            }
            if (true == writeFile)
            {
                OpenStream();
            }
            
        }
        ~CStreamFile()
        {
            //CloseStream();
        }
        public void OpenStream()
        {
            file = new StreamWriter(fileName, append: false);
        }

        public void OpenStreamR()
        {
            try
            {
                fileR = new StreamReader(fileName);
            }
            catch (Exception ex)
            {
                
            }
            
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
        public string[] Read()
        {


            string[] lines = System.IO.File.ReadAllLines(fileName);
            return lines;
        }

        public string getFileName()
        {
            return fileName;
        }

    }
}
