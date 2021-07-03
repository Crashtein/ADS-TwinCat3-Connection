using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TwinCAT.Ads;

namespace ADSTwinCat3
{
    class ADSConnection
    {
        TcAdsClient tcAds = new TcAdsClient();
        private string ADSAddress = "127.0.0.1.1.1";
        private int ADSPort = 851;
        public string Connect()
        {
            try
            {
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
        public string ReadVariables()
        {
            // creates a stream with a length of 4 byte 
            AdsStream ds = new AdsStream(4);
            BinaryReader br = new BinaryReader(ds);

            // reads a DINT from PLC
            try
            {
                tcAds.Read(0x4020, 0, ds);
            }catch(Exception ex)
            {
                if (ex != null)
                {
                    return ex.ToString();
                }
            }
            
            ds.Position = 0;
            return br.ReadInt32().ToString();
        }
        public void WriteVariables()
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
