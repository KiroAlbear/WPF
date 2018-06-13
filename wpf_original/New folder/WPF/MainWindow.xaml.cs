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

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           // var mainWindow = Application.Current.MainWindow;
           // if (mainWindow != null)//should never be
            
             //  mainWindow.WindowStyle = System.Windows.WindowStyle.None; // removes top bar (icon, title, close buttons etc)
               // mainWindow.AllowsTransparency = true; //removes the border around the outside
                //mainWindow.PreviewMouseLeftButtonDown += (s, e) => DragMove();
                

        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();            
        }

        private void EnteryButton_Click_1(object sender, RoutedEventArgs e)
        {

            EntryWindow entrywindow= new EntryWindow();
            entrywindow.Show();
            Application.Current.MainWindow.Close();

        }

    
 
    }
}
