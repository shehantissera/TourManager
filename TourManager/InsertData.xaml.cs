using CommonLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
using TourManager.Contracts;

namespace TourManager
{
    /// <summary>
    /// Interaction logic for InsertData.xaml
    /// </summary>
    public partial class InsertData : Window
    {
        WebInvoker Invoker { get; set; }
        LocalSecurity Security { get; set; }

        public InsertData(WebInvoker _invoker,LocalSecurity _security)
        {
            this.Invoker = _invoker;
            this.Security = _security;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SendInsertData();
        }

        private void SendInsertData()
        {
            string user = txtName.Text;
            string pass = txtAge.Text;

            User newuser = new User();
            string postData1 = newuser.Store(user, "22", pass);
            string postData2 = newuser.Validate(user, pass,"");

            //MessageBox.Show(Invoker.GenerateRequest(postData2), "Tour Manager", MessageBoxButton.OKCancel, MessageBoxImage.Information);
           
        }
    }
}
