using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NapierBanking
{
    /// <summary>
    /// Interaction logic for hashTrend.xaml
    /// </summary>
    public partial class hashTrend : Window
    {
        public hashTrend()
        {
            InitializeComponent();
            populateHash();
            populateMentions();
            populateSIR();
        }

        private void trendList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

        }

        private void populateHash()
        {
            Read_and_Write.hashReader hr = new Read_and_Write.hashReader();
            hr.readHash();

            

            var grp = hr.hashTag.GroupBy(a => a.ToString()).ToDictionary(g => g.Key, g => g.Count());

            foreach(KeyValuePair<string, int> value in grp)
            {
                trendList.Items.Clear();
                trendList.Items.Add(value.Key + " " + value.Value);
            }

            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            Close();
        }

        public void populateMentions()
        {
            Read_and_Write.mentionsReader mr = new Read_and_Write.mentionsReader();
            mr.readMention();
            
            foreach(string mention in mr.mentions)
            {
                mentionList.Items.Add(mention);
            }
        }

        public void populateSIR()
        {
            sirList.Items.Clear();
            Read_and_Write.ReaderClass reader = new Read_and_Write.ReaderClass();
            reader.ReadYo();
            ObservableCollection<Message.Messages> tempList = new ObservableCollection<Message.Messages>(reader.message);

            foreach (Message.Messages tempMessage in tempList)
            {
                if (tempMessage.MessageSubject.Contains("SIR"))
                {
                    char splitItem = ' ';
                    string[] splitLines = tempMessage.MessageContent.Split(splitItem);
                    string message = splitLines[0] + " " + splitLines[1] + " " + splitLines[2] + " " + splitLines[3] + " " + splitLines[4] + " " + splitLines[5] + " " + splitLines[6];
                    sirList.Items.Add(tempMessage.MessageHead + " " + tempMessage.MessageSender + " " + tempMessage.MessageSubject + " " + message);
                }
                
            }

        }

        private void mentionList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
