using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace NapierBanking.RegexMethods
{
    class textSpeakExpander
    {
        public List<Message.textNonsense> textspeak = new List<Message.textNonsense>();
        private void ReadTextSpeak()
        {
            //Reading in from .csv file with text speak abbreviations

            string GetPath = System.Reflection.Assembly.GetExecutingAssembly().Location + "\\..\\..\\..\\Resource\\textwords.csv";

            try
            {
                var readThis = File.ReadLines(GetPath);
                textspeak.Clear();

                foreach (string Line in readThis)
                {
                    char SplitChar = ',';
                    string GetLine = Line;
                    string[] SplitLines = GetLine.Split(SplitChar);
                    textspeak.Add(new Message.textNonsense(SplitLines[0], SplitLines[1]));

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public string textExpanded(string temp)
        {
            // To expand textspeak Regex here is used to find expressions 
            ReadTextSpeak();
            foreach (Message.textNonsense text in textspeak)
            {
                Regex regularExpressions = new Regex(@"\b" + text.textExpand + @"\b", RegexOptions.IgnoreCase | RegexOptions.Compiled);
                MatchCollection matches = regularExpressions.Matches(temp);

                foreach (Match match in matches)
                {
                    string changeText = match.Value + " " + "<" + text.textExpanded + ">";
                    temp = temp.Replace(match.Value, changeText);
                }
            }
            return temp;
        }
    }
}
