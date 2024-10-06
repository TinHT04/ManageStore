using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QuanliKho.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        //All thing will process in this here
        public MainViewModel()
        {
            MessageBox.Show("This is MainViewModel -> DataContext of mainwindow.xaml");
        }
    }
}
