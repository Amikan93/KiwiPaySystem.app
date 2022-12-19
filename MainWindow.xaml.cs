using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
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

namespace WPFCreatePay.app
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

        private void BtnAuth_OnClick(object sender, RoutedEventArgs e)
        {
            string login = tbxLogin.Text;
            string password = tbxPassword.Password;

            if (string.IsNullOrWhiteSpace(login))
                lblLoginMessage.Content = "Поле обязательно к заполнению";
            else
                lblLoginMessage.Content = null;

            if (string.IsNullOrWhiteSpace(password))
                MessageBox.Show("Необходимо указать пароль");

            //do...

            //обращаемся к MainAuthWindow, текущее окно закроется и откроется новое

            MainAuthWindow mainAuth = new MainAuthWindow();
            mainAuth.Show();

            this.Close();
        }
    }
}
