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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NapierBanking
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Create_Btn_Click(object sender, RoutedEventArgs e)
        {
            //Navigation
            MessageCreateWindow msg_Create = new MessageCreateWindow();
            msg_Create.Show();
            Close();
        }

        private void Filter_Btn_Click(object sender, RoutedEventArgs e)
        {
            //Navigation
            ReadFilter rf = new ReadFilter();
            rf.Show();
            Close();
            
        }
    }
}
