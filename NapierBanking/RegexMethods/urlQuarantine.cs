using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NapierBanking.RegexMethods
{
    public class urlQuarantine
    {
        public string quarantineURL(string temp)
        {
            //Regex used to find valid URL to quarantine and the replace
            Regex regx = new Regex(@"\b(?:http?s://|www\.|http://)\S+\b", RegexOptions.IgnoreCase | RegexOptions.Compiled);
            MatchCollection matches = regx.Matches(temp);
            foreach (Match match in matches)
            {
                saveURL(match.Value.ToString());

                //URL is replaced 
                temp = temp.Replace(match.Value, "<URL Quarantined>");


            }

            return temp;

        }
        public void saveURL(string urlSave)
        {
            string GetPath = System.Reflection.Assembly.GetExecutingAssembly().Location + "\\..\\..\\..\\Resource\\quarantineURL.csv";
            using (var writer = new StreamWriter(GetPath, true))
            {
                var saveLink = string.Format("{0}", urlSave);
                writer.WriteLine(saveLink);
                writer.Flush();
            }
        }
    }
}
