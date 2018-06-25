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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Interaction logic for Pop.xaml
    /// </summary>
    public partial class Pop : Page
    {
        string spaces = "                                                                                                      ";
        public Pop()
        {
            InitializeComponent();
            this.Loaded += Page_loaded;
        }
        private async void Page_loaded(object sender, RoutedEventArgs e)
        {
            await Animation();
        }

        private void PopCancelButton_Click(object sender, RoutedEventArgs e)
        {
           
            this.Visibility = Visibility.Collapsed;
        }

        public async Task Animation()
        {
            var sb = new Storyboard();

            var slideAnimation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(.5f)),
                From = new Thickness(300, 300, 300, 300),
                To = new Thickness(0),
                DecelerationRatio = 1
            };

            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
            sb.Children.Add(slideAnimation);
            sb.Begin(this);
            //   this.Visibility = Visibility.Visible;
            //await Task.Delay((int)(0.2f * 1000));

        }
        private void GLOBALTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == spaces)
                ((TextBox)sender).Text = string.Empty;
            //if (((TextBox)sender).Name == PriestTextBox.Name)
            //    PositioningGlobalList(1, 0);
            //if (((TextBox)sender).Name == ChurchBox.Name)
            //    PositioningGlobalList(2, 0);
            //if (((TextBox)sender).Name == PersonBox.Name)
            //    PositioningGlobalList(3, 0);
            //if (((TextBox)sender).Name == StreetTextBox.Name)
            //    PositioningGlobalList(4, 0);
            //if (((TextBox)sender).Name == RegionTextBox.Name)
            //    PositioningGlobalList(6, 0);

        }
        private void GlobalTextBox_Loaded(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == string.Empty)
                ((TextBox)sender).Text = spaces;
         

           



        }

        private void TextBox_Loaded(object sender, RoutedEventArgs e)
            {
            ((TextBox)sender).Focus();
        }


    }
}
