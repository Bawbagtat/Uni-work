using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NapierBanking.Message
{
    public class Messages
    {
        //Getters and setters for all message content is found and set here
        public string MessageHead { get; set; }
        public string MessageSender { get; set; }
        public string MessageSubject { get; set; }
        public string MessageContent { get; set; }


        public Messages(string header, string sender, string subject, string content)
        {
            MessageHead = header;
            MessageSender = sender;
            MessageSubject = subject;
            MessageContent = content;
        }

       public Messages()
        {

        }

      

        

        

        

        
       
        

    }
}
