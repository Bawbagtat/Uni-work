using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NapierBanking.Read_and_Write
{
    public class mentionsReader
    {
        //New list created to store in mentions read
        public List<string> mentions = new List<string>();

        public void readMention()
        {
            //Mentions are read from csv in Resources folder
            string GetPath = System.Reflection.Assembly.GetExecutingAssembly().Location + "\\..\\..\\..\\Resource\\mentions.csv";
            var readThis = File.ReadLines(GetPath);
            mentions.Clear();

            foreach (string templine in readThis)
            {
                mentions.Add(templine);
            }
        }
    }
}

