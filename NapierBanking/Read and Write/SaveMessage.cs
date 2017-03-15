using NapierBanking.Message;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NapierBanking.Read_and_Write
{
    public class SaveMessage : Messages
    {
      public void SaveYo()
        {
          //Method to save messages 
            string GetPath = System.Reflection.Assembly.GetExecutingAssembly().Location + "\\..\\..\\..\\Resource\\something.csv";
            using (var writer = new StreamWriter(GetPath, true))
            {
                var SaveLine = string.Format("{0}, {1}, {2}, {3}", MessageHead, MessageSender, MessageSubject, MessageContent);
                writer.WriteLine(SaveLine);
                writer.Flush();
            }

        }
    }
}
