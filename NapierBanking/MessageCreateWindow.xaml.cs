using NapierBanking.Read_and_Write;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for MessageCreateWindow.xaml
    /// </summary>
    public partial class MessageCreateWindow : Window
    {
        public MessageCreateWindow()
        {
            //Setting the initial visibility of the form
            InitializeComponent();
            subject_txtBox.Visibility = Visibility.Hidden;
            sirCombo.Visibility = Visibility.Hidden;
            sortCode1.Visibility = Visibility.Hidden;
            sortCode2.Visibility = Visibility.Hidden;
            sortCode3.Visibility = Visibility.Hidden;
            sortLabel.Visibility = Visibility.Hidden;
        }

       

        private void back_Btn_Click(object sender, RoutedEventArgs e)
        {
            //Navigation
            MainWindow mw = new MainWindow();
            mw.Show();
            Close();
        }

        

        private void save_Btn_Click(object sender, RoutedEventArgs e)
        {
            //Button click event to save message
            Read_and_Write.ReaderClass read = new Read_and_Write.ReaderClass();
            read.ReadYo();
            Read_and_Write.SaveMessage save = new Read_and_Write.SaveMessage();
            MessageBox.Show("Message created successfully");
            save.MessageHead = null;
            save.MessageSender = sender_txtBox.Text;
            save.MessageSubject = subject_txtBox.Text;
            save.MessageContent = messageBody_txtBox.Text;
            
            //Message Id is incremented 
            int id = 10000000 + read.message.Count();
            

            if(sms_RadioBtn.IsChecked == true)
            {
               
                    if (messageBody_txtBox.Text.Length > 140)
                    {
                        MessageBox.Show("Too many digits");
                    }
  
                save.MessageHead = "S" + id;
                save.MessageSubject = null;
                RegexMethods.textSpeakExpander ts = new RegexMethods.textSpeakExpander();

                save.MessageContent = ts.textExpanded(save.MessageContent);
                //id++;
            }
            else if(Email_RadioBtn.IsChecked == true)
            {
                RegexMethods.urlQuarantine uq = new RegexMethods.urlQuarantine();

                save.MessageContent = uq.quarantineURL(save.MessageContent);
                save.MessageHead = "E" + id;
                //id++;
            }
            else if(tweet_RadioBtn.IsChecked == true)
            {
                if (messageBody_txtBox.Text.Length > 140)
                {
                    MessageBox.Show("Too many digits");
                }
                save.MessageSender = "@" + save.MessageSender;
                save.MessageHead = "T" + id;
                save.MessageSubject = null;
                save.MessageContent = messageBody_txtBox.Text;
                RegexMethods.hashSave hs = new RegexMethods.hashSave();
                hs.searchHashtag(save.MessageContent);
                RegexMethods.twitterHandleSave ts = new RegexMethods.twitterHandleSave();
                ts.searchTwHandle(save.MessageContent);
                RegexMethods.textSpeakExpander textEx = new RegexMethods.textSpeakExpander();

                save.MessageContent = textEx.textExpanded(save.MessageContent);
                //id++;
            }
            else if(sir_RadioBtn.IsChecked == true)
            {
                save.MessageHead = "E" + id;
                save.MessageSubject = "SIR " + System.DateTime.Now.ToShortDateString();
                string sReport = "Sortcode" + " " + sortCode1.Text + "-" + sortCode2.Text + "-" + sortCode3.Text;
                sReport = sReport + " " + "Nature of Incident" + " " + sirCombo.SelectedItem.ToString();
                save.MessageContent = sReport + " " + save.MessageContent;
                RegexMethods.urlQuarantine uq = new RegexMethods.urlQuarantine();

                save.MessageContent = uq.quarantineURL(save.MessageContent);
                //id++;
            }
            //Message is saved
            save.SaveYo();
            
        }

        private void sms_RadioBtn_Checked(object sender, RoutedEventArgs e)
        {
            //Custom Visibility
            subject_txtBox.Visibility = Visibility.Hidden;
            sirCombo.Visibility = Visibility.Hidden;
            sortCode1.Visibility = Visibility.Hidden;
            sortCode2.Visibility = Visibility.Hidden;
            sortCode3.Visibility = Visibility.Hidden;
            sortLabel.Visibility = Visibility.Hidden;

        }

        private void Email_RadioBtn_Checked(object sender, RoutedEventArgs e)
        {
            //Custom Visibility
            subject_txtBox.Visibility = Visibility.Visible;
            sirCombo.Visibility = Visibility.Hidden;
            sortCode1.Visibility = Visibility.Hidden;
            sortCode2.Visibility = Visibility.Hidden;
            sortCode3.Visibility = Visibility.Hidden;
            sortLabel.Visibility = Visibility.Hidden;
        }

        private void tweet_RadioBtn_Checked(object sender, RoutedEventArgs e)
        {
            //Custom Visibility
            subject_txtBox.Visibility = Visibility.Hidden;
            sirCombo.Visibility = Visibility.Hidden;
            sortCode1.Visibility = Visibility.Hidden;
            sortCode2.Visibility = Visibility.Hidden;
            sortCode3.Visibility = Visibility.Hidden;
            sortLabel.Visibility = Visibility.Hidden;
        }

        private void sir_RadioBtn_Checked(object sender, RoutedEventArgs e)
        {
            //Custom Visibility
            subject_txtBox.Visibility = Visibility.Hidden;
            sirCombo.Visibility = Visibility.Visible;
            sortCode1.Visibility = Visibility.Visible;
            sortCode2.Visibility = Visibility.Visible;
            sortCode3.Visibility = Visibility.Visible;
            sortLabel.Visibility = Visibility.Visible;
        }

        private void sirCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //SIR combo box selection is implemented
            var comboBox = sender as ComboBox;

            string value = comboBox.SelectedItem as string;
            this.Title = "Selected" + value;
        }

        private void sirCombo_Loaded_1(object sender, RoutedEventArgs e)
        {
            //Coombo box created for SIR messages
            
            sirCombo.Items.Add("Theft");
            sirCombo.Items.Add("Staff Attack");
            sirCombo.Items.Add("ATM Theft");
            sirCombo.Items.Add("Raid");
            sirCombo.Items.Add("Customer Attack");
            sirCombo.Items.Add("Staff Abuse");
            sirCombo.Items.Add("Bomb Threat");
            sirCombo.Items.Add("Terrorism");
            sirCombo.Items.Add("Suspicious Incident");
            sirCombo.Items.Add("Intelligence");
            sirCombo.Items.Add("Cash Loss");
    
        }

        private int ValidateSC(string temp)
        {
            //Validation for sort codes in numeric values
            int tempint;
            if(int.TryParse(temp,out tempint))
            {
                int tempintB = int.Parse(temp);
                if (tempint < 0 || tempint > 99)
                {
                    MessageBox.Show("Sort code must be numeric value");
                    return 0;
                }
                return tempint;
            }

            else if(temp != "")
            {
                MessageBox.Show("Sortcode must be numeric");
            }
            return 0;
        }

        private void sortCode1_TextChanged(object sender, TextChangedEventArgs e)
        {
            ValidateSC(sortCode1.Text);
        }

        private void sortCode2_TextChanged(object sender, TextChangedEventArgs e)
        {
            ValidateSC(sortCode2.Text);
        }

        private void sortCode3_TextChanged(object sender, TextChangedEventArgs e)
        {
            ValidateSC(sortCode3.Text);
        }

        private void sender_txtBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sender_txtBox.Text == "Message Sender")
                sender_txtBox.Text = "";
        }

        private void subject_txtBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if(subject_txtBox.Text == "Subject")
            subject_txtBox.Text = "";
        }

        private void messageBody_txtBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (messageBody_txtBox.Text == "Message Body")
                messageBody_txtBox.Text = "";
        }

        private void messageBody_txtBox_LostFocus(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(messageBody_txtBox.Text))
            {
                messageBody_txtBox.Text = "Message Body";
            }
        }

        private void subject_txtBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(subject_txtBox.Text))
            {
                subject_txtBox.Text = "Subject";
            }
        }

        private void sender_txtBox_LostFocus(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(sender_txtBox.Text))
                sender_txtBox.Text = "Message Sender";
        }

        private void messageBody_txtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
