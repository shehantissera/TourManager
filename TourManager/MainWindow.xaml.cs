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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace TourManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        WebInvoker Invoker { get; set; }
        LocalSecurity Security { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            InitializingSystem();
        }

        private void InitializingSystem()
        {
            Invoker = new WebInvoker();
            Security = new LocalSecurity();

            //MessageBox.Show("testing message");
            //var controller = this.ShowMessageAsync("This is the title", "Some message");
            
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            //InsertData subWindow = new InsertData(Invoker,Security);
            //subWindow.Show();
            DialogManager.ShowMessageAsync(this, "Error", "This is a message", MessageDialogStyle.Affirmative, new MetroDialogSettings { ColorScheme = MetroDialogColorScheme.Accented });
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            flyout.IsOpen = true;
        }
    }
}
