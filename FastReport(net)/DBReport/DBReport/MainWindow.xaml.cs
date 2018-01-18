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
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using FastReport.Data;

namespace DBReport
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            initializeDataBase();
        }
        private string uDataBase = "Employee.db3"; //default is in the app file directory   
        private string strDBPwsd ="williamxia2018";
        private void initializeDataBase()
        {
            IOSQL.getInstance(uDataBase, strDBPwsd);
            IOSQL.getInstance(uDataBase).executeSQL(STRSQL.TABLE_EMPLOYYE);
        }

        private void btnLoadReport_Click(object sender, RoutedEventArgs e)
        {
            CPrintView vc = new CPrintView();
            vc.ShowDialog();
        }

        private void writeData_Click(object sender, RoutedEventArgs e)
        {
            string strSQL = "insert into employees values('aaa','123145464','hereerer','william','xia','1984-06-03')";
            IOSQL.getInstance(uDataBase, strDBPwsd).executeSQL(strSQL);
        }
    }
}
