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

using System.Reflection;//for access resource report file to load 
using System.IO;
using System.Data;
using FastReport;
using System.Diagnostics;

namespace DBReport
{
    /// <summary>
    /// Interaction logic for CPrintView.xaml
    /// </summary>
    public partial class CPrintView : Window
    {
        // DataSet FdataSet;

        //  StreamReader _frxStreamReader;
        public static string RES_FRPT = "simpleRpt.frx";

        Report FReport = null;
        Assembly _assembly;
        Stream frxStream = null;
        public void loadMyReport(string fileName)
        {
           
            FReport = new Report();
            FReport.Preview = reportVC;
            //
            bool iLoadRes = true;
            try
            {
                _assembly = Assembly.GetExecutingAssembly();
                string strReport = string.Format("{0}.{1}.{2}", GetType().Namespace, "Resources", fileName);
                Debug.WriteLine("report name read from stream is " + strReport);

                frxStream = _assembly.GetManifestResourceStream(strReport);
            }
            catch (Exception e)
            {
                iLoadRes = false;
                Debug.WriteLine(e.ToString());
            }
            Debug.WriteLine("load report result is  {0}", iLoadRes);
            if (iLoadRes)
            {
                FReport.Load(frxStream);
                FReport.Prepare();
                FReport.ShowPrepared();
            }

        }

        public CPrintView()
        {
            InitializeComponent();
        }
        private string uDataBase = "Employee.db3"; //default is in the app file directory   
        private string strDBPwsd = "williamxia2018";
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            bool isRes = IOSQL.getInstance(uDataBase, strDBPwsd).iSDataBaseOpen();
            Debug.WriteLine("report db isconnection {0}", isRes);

            int count = IOSQL.getInstance(uDataBase, strDBPwsd).numOfCount("Employees");
            Debug.WriteLine("receive table row number is  " + count);
            loadMyReport(RES_FRPT);



        }
    }
}
