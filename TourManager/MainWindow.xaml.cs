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
using TourManager.ViewModel;

namespace TourManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        App_ViewModel ViewModel { get; set; }
        public MainWindow(App_ViewModel _viewmodel)
        {
            InitializeComponent();
            InitializingSystem(_viewmodel);
        }

        private void InitializingSystem(App_ViewModel _viewmodel)
        {
            this.ViewModel = _viewmodel;
            LayoutRootMain.DataContext = ViewModel;
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            DialogManager.ShowMessageAsync(this, "Error", "This is a message", MessageDialogStyle.Affirmative, new MetroDialogSettings { ColorScheme = MetroDialogColorScheme.Accented });
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            flyout.IsOpen = true;
        }
    }
}
