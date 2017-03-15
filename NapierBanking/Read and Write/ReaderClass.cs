using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace NapierBanking.Read_and_Write
{
    public class ReaderClass
    {
        public List<Message.Messages> message = new List<Message.Messages>();


        public void ReadYo()
        {
            //Method to read in messages 
            try
            {
                string GetPath = System.Reflection.Assembly.GetExecutingAssembly().Location + "\\..\\..\\..\\Resource\\something.csv";
                var readThis = File.ReadLines(GetPath);

            foreach(string line in readThis)
            {
                //Differntiates between messages as per header type
                char Split = ',';
                string tempLine = line;
                string[] SplitLines = tempLine.Split(Split);
                if(SplitLines[0].Contains("S") || SplitLines[0].Contains("T"))
                {
                    message.Add(new Message.Messages(SplitLines[0], SplitLines[1], SplitLines[2], SplitLines[3]));

                }
                else if(SplitLines[0].Contains("E"))
                {
                    message.Add(new Message.Messages(SplitLines[0], SplitLines[1], SplitLines[2], SplitLines[3]));

                }
           
            }
        }
                catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }

        

        
    }
}
