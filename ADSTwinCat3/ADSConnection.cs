using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TwinCAT.Ads;

//plc program:

//program main
//var
//        test at%md0 : dint;
//end_var
//test := test + 1;

namespace ADSTwinCat3
{
    class ADSConnection
    {
        TcAdsClient tcAds = null;
        private string ADSAddress = "5.43.145.72.1.1";
        private int ADSPort = 851;
        public string Connect()
        {
            Dispose();
            try
            {
                tcAds = new TcAdsClient();
                tcAds.Connect(ADSAddress, ADSPort);
            }catch(Exception ex)
            {
                if (ex != null)
                {
                    return ex.ToString();
                }
            }
            return "Connected";
        }
        public BinaryReader ReadVariables(uint area = 16416, int nBytes=4,uint type = 0)
        {
            //16416 (dec) = 0x4020 (hex)
            //0x4020; //ADS Area : PLC memory area
            //0 Data type
            AdsStream ds = new AdsStream(nBytes);
            BinaryReader br = new BinaryReader(ds);
            try
            {
                tcAds.Read(area, type, ds);
            }catch(Exception ex)
            {
                if (ex != null)
                {
                    return null;
                }
            }
            ds.Position = 0;
            return br;
        }
        public BinaryReader ReadVariablesByName(string name, int nBytes = 4)
        {
            if (String.IsNullOrEmpty(name))
            {
                return null;
            }
            AdsStream dataStream = new AdsStream(nBytes);
            BinaryReader binaryReader = new BinaryReader(dataStream);

            int iHandle = 0;
            try
            {
                //Get the handle of the PLC variable "<variable_name>"
                iHandle = tcAds.CreateVariableHandle("GVL."+name);

                //Use the handle to read PLCVar
                tcAds.Read(iHandle, dataStream);
                dataStream.Position = 0;
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    return null;
                    //return ex.ToString();
                }
            }
            finally
            {
                //Delete variable handle
                tcAds.DeleteVariableHandle(iHandle);
            }
            return binaryReader;
            //return Convert.ToString(binaryReader.ReadInt32(), 2);
        }
        public Boolean ReadBinaryVariablesByName(string name)
        {
            BinaryReader br = ReadVariablesByName(name, 1);
            if (br == null)
            {
                return false;   //may give false values when reader does not give any values!!! TO SOLVE
            }
            return br.ReadBoolean();
        }
        public Boolean[] ReadBinaryVariablesByName(string[] names)
        {
            Boolean[] values = new Boolean[names.Length];
            for(int i = 0; i < names.Length; i++)
            {
                values[i] = ReadBinaryVariablesByName(names[i]);
            }
            return values;
        }
        public Int32 ReadInt32VariablesByName(string name)
        {

            BinaryReader br = ReadVariablesByName(name, 4);
            if (br == null)
            {
                return Int32.MinValue;
            }
            return br.ReadInt32();
        }
        public Int32[] ReadInt32VariablesByName(string[] names)
        {
            Int32[] values = new Int32[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                values[i]  = ReadInt32VariablesByName(names[i]);
            }
            return values;
        }
        public void WriteVariables()    //writing function not tested
        {
            // creates a stream with a length of 4 byte
            AdsStream ds = new AdsStream(4);
            BinaryWriter bw = new BinaryWriter(ds);

            ds.Position = 0;
            bw.Write((int)100);

            // writes a DINT to PLC
            tcAds.Write(0x4020, 0, ds);
        }
        public void Dispose()
        {
            if (tcAds != null)
            {
                tcAds.Dispose();
            }
        }
        ~ADSConnection()
        {
            Dispose();
        }
    }
}
