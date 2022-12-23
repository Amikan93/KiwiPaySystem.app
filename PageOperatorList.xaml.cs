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
using WPFCreatePay.app.Model;

namespace WPFCreatePay.app
{
    /// <summary>
    /// Interaction logic for PageOperatorList.xaml
    /// </summary>
    public partial class PageOperatorList : Page
    {
        public PageOperatorList()
        {
            InitializeComponent();

            //List<Operator> operators = new List<Operator>();
            //operators.Add(new Operator()
            //{
            //    Prefix = "+7 777",
            //    Logo = "https://upload.wikimedia.org/wikipedia/commons/7/7a/BeeLine_logo.png",
            //    Name = "Beeline",
            //    Percent = 0.5
            //});


            OperatorService operatorService = new OperatorService();
            lvOperatorList.ItemsSource = operatorService.GetOperators();

        }
        private void BtnEditData_OnClick(object sender, RoutedEventArgs e)
        {
            Operator data = (Operator)lvOperatorList.SelectedItem;

            MainAuthWindow._frameMain.Source = new Uri("_pageAddOperator.xaml", UriKind.RelativeOrAbsolute);
        }
    }

}
