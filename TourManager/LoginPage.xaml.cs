using CommonLib;
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
using TourManager.Contracts;
using MahApps.Metro.Controls;

namespace TourManager
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : MetroWindow
    {
        WebInvoker Invoker { get; set; }
        LocalSecurity Security { get; set; }
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            ValidateUser();
        }

        private void ValidateUser()
        {
            string user = txtUserName.Text;
            string pass = txtPassword.Password;

            User newuser = new User();
            string postData2 = newuser.Validate(user, pass,"");
            //Invoker.GenerateRequest(postData2);
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();

            /*if (user.Equals(""))
            {
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid user credentials. Please try again.","Tour Manager",MessageBoxButton.OKCancel,MessageBoxImage.Error);
            }*/

            //MessageBox.Show(Invoker.GenerateRequest(postData2), "Tour Manager", MessageBoxButton.OKCancel, MessageBoxImage.Information);

        }
    }
}
