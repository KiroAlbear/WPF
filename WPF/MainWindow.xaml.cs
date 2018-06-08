using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
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
using WPF.classes;
using WPF.ComponentPages;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MahApps.Metro.Controls.MetroWindow
    {
      
        const string MainWindowName = "MainWindow";
        public MainWindow()
        {
            InitializeComponent();
            this.Name = MainWindowName;

            ShowMaxRestoreButton = false;
            ResizeMode = ResizeMode.CanMinimize;


          

            // var mainWindow = Application.Current.MainWindow;
            // if (mainWindow != null)//should never be

            //  mainWindow.WindowStyle = System.Windows.WindowStyle.None; // removes top bar (icon, title, close buttons etc)
            // mainWindow.AllowsTransparency = true; //removes the border around the outside
            //mainWindow.PreviewMouseLeftButtonDown += (s, e) => DragMove();
            //  ThreeButtonsFrame.NavigationService.Navigate(new ComponentPages.TopThreeButtons(this));

        }
     
     

        private void EnteryButton_Click_1(object sender, RoutedEventArgs e)
        {
            
            EntryWindow entrywindow= new EntryWindow(sender);
            entrywindow.Show();
          
            
        }


        private  void SearchButton_Click(object sender, RoutedEventArgs e)
        {

         

            Windows.SearchWindows searchwindow = new Windows.SearchWindows();
            searchwindow.Show();

        }

        private void EditeButton_Click(object sender, RoutedEventArgs e)
        {
            Windows.SingleEntry singleentry = new Windows.SingleEntry();
            singleentry.Show();
            
        }

        private void second_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
