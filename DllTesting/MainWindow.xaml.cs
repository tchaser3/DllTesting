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
using IncentivePayDLL;

namespace DllTesting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IncentivePayClass TheIncentivePayClass = new IncentivePayClass();

        FindSortedIncentivePayTitles2DataSet TheFindSortedIncentivePayTitles2DataSet = new FindSortedIncentivePayTitles2DataSet();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TheFindSortedIncentivePayTitles2DataSet = TheIncentivePayClass.FindSortedIncentivePayTitles2();

            dgrResults.ItemsSource = TheFindSortedIncentivePayTitles2DataSet.FindSortedIncentivePayTitles2;
        }
    }
}
