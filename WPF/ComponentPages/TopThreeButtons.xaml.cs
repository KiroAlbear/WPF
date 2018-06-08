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

namespace WPF.ComponentPages
{
    /// <summary>
    /// Interaction logic for TopThreeButtons.xaml
    /// </summary>
    public partial class TopThreeButtons : Page
    {
        Window CurrentWindow;
        //const string FirstCloseIconPath = @"P:\Projects\OfflineWpf\WPF\Icons\StaticClose.png";
        //const string SecondCloseIconPath = @"P:\Projects\OfflineWpf\WPF\Icons\DynamicClose.png";
        //const string FirstMinimizeIconPath = @"P:\Projects\OfflineWpf\WPF\Icons\StaticMinimize.png";
        //const string SecondMinimizeIconPath = @"P:\Projects\OfflineWpf\WPF\Icons\DynamicMinimize.png";


        //const string FirstCloseIconName = "FistCloseButton";
        //const string SecondCloseIconName = "SecondCloseButton";
        //const string FirsttMinimizeIconName = "FirstMinimizeButton";
        //const string SecondMinimizeIconName = "SecondMinimizeButton"; 

        BitmapImage FirstCloseButtonBitmap=null;
        BitmapImage SecondCloseButtonBitmap=null;
        BitmapImage FirstMinimizeButtonBitmap=null;
        BitmapImage SecondMinimizeButtonBitmap=null;
        public TopThreeButtons(Window CurrentWindow)
        {
            this.CurrentWindow = CurrentWindow;
            InitializeComponent();
            InitializeControlButtonsIcons();
        }
        private void InitializeControlButtonsIcons()
        {
            try
            {


                //#region CloseButtonInitialization
                //FirstCloseButtonBitmap = FillBitMap(FirstCloseIconPath, FirstCloseButtonBitmap);
                //SecondCloseButtonBitmap = FillBitMap(SecondCloseIconPath, SecondCloseButtonBitmap);

                //AddBitmapToStackPanel(FirstCloseButtonBitmap, CloseButtonStackPanel);

                //#endregion



                //#region MinimizeButtonInitialization
                //FirstMinimizeButtonBitmap = FillBitMap(FirstMinimizeIconPath, FirstMinimizeButtonBitmap);
                //SecondMinimizeButtonBitmap = FillBitMap(SecondMinimizeIconPath, SecondMinimizeButtonBitmap);
                //AddBitmapToStackPanel( FirstMinimizeButtonBitmap, MinimizeButtonStackPanel);

             //   #endregion
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private BitmapImage FillBitMap(string ImageLocation,BitmapImage EmptyBitmap)
        {
            EmptyBitmap = new BitmapImage();
            EmptyBitmap.BeginInit();
            EmptyBitmap.UriSource = new Uri(ImageLocation);
            EmptyBitmap.EndInit();
            return EmptyBitmap;
        }


        private void AddBitmapToStackPanel(BitmapImage EmptyBitimage,StackPanel stackpanel)
        {
            stackpanel.Children.Clear();
            Image dynamicImage = new Image();
            
            dynamicImage.Width = stackpanel.Width;
            dynamicImage.Height = stackpanel.Height;

            // Create a BitmapSource  
          
          

            // Set Image.Source  
            dynamicImage.Source = EmptyBitimage;

            // Add Image to Window  
            
            stackpanel.Children.Add(dynamicImage);
        }
        


        private void Exit_MouseDown(object sender, MouseButtonEventArgs e)
        {

            //  CurrentWindow.Close();
            if (CurrentWindow.Name == "MainWindow")
                Application.Current.Shutdown();
            else if (CurrentWindow.Name == "SearchWindow")
                CurrentWindow.Close();
            
        }

        private void MinimizeButtonStackPanel_MouseEnter(object sender, MouseEventArgs e)
        {
            AddBitmapToStackPanel( SecondMinimizeButtonBitmap, MinimizeButtonStackPanel);
        }

        private void MinimizeButtonStackPanel_MouseLeave(object sender, MouseEventArgs e)
        {
            AddBitmapToStackPanel( FirstMinimizeButtonBitmap, MinimizeButtonStackPanel);
        }

        private void CloseStackPanel_MouseEnter(object sender, MouseEventArgs e)
        {
            AddBitmapToStackPanel( SecondCloseButtonBitmap, CloseButtonStackPanel);
        }

        private void CloseStackPanel_MouseLeave(object sender, MouseEventArgs e)
        {
            AddBitmapToStackPanel(FirstCloseButtonBitmap, CloseButtonStackPanel);
        }

        private void MinimizeButtonStackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CurrentWindow.WindowState = WindowState.Minimized;
        }
    }
}
