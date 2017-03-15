using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NapierBanking.RegexMethods
{
    class hashSave
    {
        public void searchHashtag(string temp)
        {
            //Regex method to search for hashtags 

            Regex regHashx = new Regex(@"(?<!\w)#\w+");
            MatchCollection matches = regHashx.Matches(temp);
            foreach (Match match in matches)
            {
                saveHashtag(match.Value);
            }
        }
        private void saveHashtag(string hashSave)
        {
            //Method to save hashtags

            string GetPath = System.Reflection.Assembly.GetExecutingAssembly().Location + "\\..\\..\\..\\Resource\\hashtag.csv";
            using (var writer = new StreamWriter(GetPath, true))
            {
                var saveHash = string.Format("{0}", hashSave);
                writer.WriteLine(saveHash);
                writer.Flush();
            }
        }
    }
}
