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
    /// Interaction logic for ReadFilter.xaml
    /// </summary>
    public partial class ReadFilter : Window
    {
        public ReadFilter()
        {
            InitializeComponent();
            populateListBox();
        }

        private void populateListBox()
        {
            //Method to populate list box
            messageListBox.Items.Clear();
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
                    messageListBox.Items.Add(tempMessage.MessageHead + " " + tempMessage.MessageSender + " " + tempMessage.MessageSubject + " " + message);
                }
                else
                {
                    messageListBox.Items.Add(tempMessage.MessageHead + " " + tempMessage.MessageSubject + " " + tempMessage.MessageSender);
                }
            }

        }
        private void filterYo()
        {
            //Method to filter messages 
            Read_and_Write.ReaderClass reader = new Read_and_Write.ReaderClass();
            reader.ReadYo();
            ObservableCollection<Message.Messages> tempList = new ObservableCollection<Message.Messages>(reader.message);
            ObservableCollection<Message.Messages> sms = new ObservableCollection<Message.Messages>();
            ObservableCollection<Message.Messages> Tweet = new ObservableCollection<Message.Messages>();
            ObservableCollection<Message.Messages> Email = new ObservableCollection<Message.Messages>();
            ObservableCollection<Message.Messages> SIR = new ObservableCollection<Message.Messages>();

            foreach (Message.Messages tempMessage in tempList)
            {
                if (tempMessage.MessageHead.Contains("S"))
                {
                    sms.Add(tempMessage);
                }

                else if (tempMessage.MessageHead.Contains("T"))
                {
                    Tweet.Add(tempMessage);
                }

                else if (tempMessage.MessageHead.Contains("E"))
                {
                    if (tempMessage.MessageSubject.Contains("SIR"))
                        SIR.Add(tempMessage);
                    else
                        Email.Add(tempMessage);
                }

            }
            if (sms_FilterBtn.IsChecked == true)
            {
                foreach (Message.Messages tempMessage in sms)
                {

                    messageListBox.Items.Add(tempMessage.MessageHead + " " + tempMessage.MessageSender);
                }
            }
            if (tweet_FilterBtn.IsChecked == true)
            {
                foreach (Message.Messages tempMessage in Tweet)
                {

                    messageListBox.Items.Add(tempMessage.MessageHead + " " + tempMessage.MessageSender);
                }
            }
            if (email_FilterBtn.IsChecked == true)
            {
                foreach (Message.Messages tempMessage in Email)
                {

                    messageListBox.Items.Add(tempMessage.MessageHead + " " + tempMessage.MessageSender + " " + tempMessage.MessageSubject);
                }
            }
            if (sir_FilterBtn.IsChecked == true)
            {
                foreach (Message.Messages tempMessage in SIR)
                {
                    char splitItem = ' ';
                    string[] splitLines = tempMessage.MessageContent.Split(splitItem);
                    string message = splitLines[0] + " " + splitLines[1] + " " + splitLines[2] + " " + splitLines[3] + " " + splitLines[4] + " " + splitLines[5] + " " + splitLines[6];
                    messageListBox.Items.Add(tempMessage.MessageHead + " " + tempMessage.MessageSender + " " + tempMessage.MessageSubject + " " + message);
                }
            }


        }





        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //navigation for session end
            hashTrend ht = new hashTrend();
            ht.Show();
            Close();
        }

        

        private void sms_FilterBtn_Checked(object sender, RoutedEventArgs e)
        {
            //Filter sms 
            messageListBox.Items.Clear();
            filterYo();

        }

        private void email_FilterBtn_Checked(object sender, RoutedEventArgs e)
        {
            //filter email 
            messageListBox.Items.Clear();
            filterYo();
        }

        private void tweet_FilterBtn_Checked(object sender, RoutedEventArgs e)
        {
            //filter tweet
            messageListBox.Items.Clear();
            filterYo();
        }

        private void sir_FilterBtn_Checked(object sender, RoutedEventArgs e)
        {
            //filter SIR
            messageListBox.Items.Clear();
            filterYo();
        }


        

        private void all_FilterBtn_Checked(object sender, RoutedEventArgs e)
        {
            //show all messages filter
            messageListBox.Items.Clear();
            populateListBox();
        }

        private void viewBtn_Click(object sender, RoutedEventArgs e)
        {
            //View message selected from list box
            try
            {

                string Item = messageListBox.SelectedItem.ToString();
                char split = ' ';
                string[] splitItem = Item.Split(split);
                //Item = null;
                Read_and_Write.ReaderClass reader = new Read_and_Write.ReaderClass();
                reader.ReadYo();


                var message = reader.message.Find(x => x.MessageHead == splitItem[0]);
                string showMessage = message.MessageHead + "\n" + message.MessageSubject + "\n" + message.MessageSender + "\n" + message.MessageContent;
                MessageBox.Show(showMessage);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void messageListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
