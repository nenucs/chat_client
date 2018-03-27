using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace wechat
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private Visibility Is_display
        {
            get;
            set;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(username.Text == "a" && password.Text =="a")
            {
                var usrname = username.Text;
                MainWindow mainWindow = new MainWindow(usrname);
                Is_display = Visibility.Collapsed;
                Thread.Sleep(3000);
                this.Close();
                mainWindow.ShowDialog();
                
            }
        }
    }
}
