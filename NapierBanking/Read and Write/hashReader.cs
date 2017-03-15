using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NapierBanking.Read_and_Write
{
    public class hashReader
    {
        //New list is creaeted to store hash values found
        public List<string> hashTag = new List<string>();

        public void readHash()
        {
            //Hash values stored are then read in this method to be called 
            string GetPath = System.Reflection.Assembly.GetExecutingAssembly().Location + "\\..\\..\\..\\Resource\\hashtag.csv";
            var readThis = File.ReadLines(GetPath);
            hashTag.Clear();
            
            foreach(string templine in readThis)
            {
                hashTag.Add(templine);
            }
        }
    }
}
