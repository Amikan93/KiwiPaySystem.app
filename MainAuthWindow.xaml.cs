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

namespace WPFCreatePay.app
{
    /// <summary>
    /// логика взаимодействия для MainAuthWindow.xaml
    /// </summary>
    public partial class MainAuthWindow : Window
    {
        public MainAuthWindow()
        {
            InitializeComponent();

        }

        private void MiOperatorList_OnClick(object sender, RoutedEventArgs e)
        {
            frameMain.Source = new Uri("PageOperatorList.xaml",
            UriKind.RelativeOrAbsolute);
        }

        private void MiClose_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

    public class Operator
    {
        public int OperatorId = 1;
        public string Prefix { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public double Percent { get; set; }
    }
}
