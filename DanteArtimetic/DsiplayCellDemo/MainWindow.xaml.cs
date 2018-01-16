using DanteLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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

namespace DsiplayCellDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<DeviceInfo> _nDeviceCollection = new ObservableCollection<DeviceInfo>();
        public MainWindow()
        {
            InitializeComponent();

            danteControl.ItemsSource = _nDeviceCollection;
            DeviceInfo minfo = new DeviceInfo("Hellog Gogole1", 2);
          //  DeviceInfo minfo2 = new DeviceInfo("Hellog Gogole2", 12);
            //DeviceInfo minfo3 = new DeviceInfo("Hellog Gogole3", 8);
            //DeviceInfo minfo4 = new DeviceInfo("Hellog Gogole4", 12);
            //DeviceInfo minfo5 = new DeviceInfo("Hellog Gogole5", 10);
            _nDeviceCollection.Add(minfo);
           // _nDeviceCollection.Add(minfo2);
          //  _nDeviceCollection.Add(minfo3);
          //  _nDeviceCollection.Add(minfo4);
        //    _nDeviceCollection.Add(minfo5);

        }        
         

        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            DeviceInfo minfo5 = new DeviceInfo("Hellog Gogole8", 3);
            _nDeviceCollection.Add(minfo5);
            danteControl.collapseAll();
        }
    }



}
