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

namespace WpfApp1
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

        private void btnSentMsg_Click(object sender, RoutedEventArgs e)
        {
            bool result = false;
            lblMessage.Content = Helper.SenttMsg(tbxTo.Text,
                tbxSubject.Text,
                tbxBody.Text, 
                out result);

            if(!result)
            {              
                lblMessage.Foreground = new SolidColorBrush(Colors.Red);
            }
            else
            {               
                lblMessage.Foreground = new SolidColorBrush(Colors.Green);
            }
        }
    }
}
