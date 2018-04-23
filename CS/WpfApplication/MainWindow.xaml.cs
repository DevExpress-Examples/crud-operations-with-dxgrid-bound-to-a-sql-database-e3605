using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Grid;

namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WpfApplication.NorthwindDataSetTableAdapters.CustomersTableAdapter _Adapter = new NorthwindDataSetTableAdapters.CustomersTableAdapter();

        private NorthwindDataSet.CustomersDataTable _Table;
        public MainWindow()
        {
            InitializeComponent();
            _Table = _Adapter.GetData();
            gridControl1.ItemsSource = _Table;


        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            _Adapter.Update(_Table);
        }
    }
}
