using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NapierBanking.RegexMethods
{
    public class twitterHandleSave
    {
        public void searchTwHandle(string temp)
        {
            //Search message using Regex to to find twitter handle
            Regex regHandlex = new Regex(@"(?<!\w)@\w+");
            MatchCollection matches = regHandlex.Matches(temp);
            foreach (Match match in matches)
            {
                saveHandle(match.Value);
            }
        }

        public void saveHandle(string handleSave)
        {
            //Method to save twitter handle to .csv mentions list
            string GetPath = System.Reflection.Assembly.GetExecutingAssembly().Location + "\\..\\..\\..\\Resource\\mentions.csv";
            using (var writer = new StreamWriter(GetPath, true))
            {
                var saveHandle = string.Format("{0}", handleSave);
                writer.WriteLine(saveHandle);
                writer.Flush();
            }
        }
    }
}
