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
using WPF.Windows;

namespace WPF.ComponentPages
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Page
    {
        Frame FloatingFrame;
        public Search(Frame FloatingFrame)
        {
            InitializeComponent();
            setLabel();
            this.FloatingFrame = FloatingFrame;
            this.FloatingFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
        }
        private void setLabel(){
            //const string startBirthString = "= < تاريخ الميلاد ";
            //const string StartVisitDate = "= < ت اخر زيارة ";
            //const string StartPersonCounter = "= < عدد الافراد";
            //StartVisitDateLabel.Content = StartVisitDate;
            //StartBirthDateLabel.Content = startBirthString;
            //StartPersonCounterLabel.Content = StartPersonCounter;
            }

        private void SearchStreetButton_Click(object sender, RoutedEventArgs e)
        {

            //FloatingFrame.NavigationService.Navigate(new ComponentPages.StreetPage());
          //  StreetChooseFrame.Visibility = Visibility.Visible;

            //street.Margin = new Thickness(0, 0, 0, 100);




            var sb = new Storyboard();

            var slideAnimation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(.3)),
                From = new Thickness(0, -this.WindowHeight, this.WindowHeight, 0),
                To = new Thickness(0),
                DecelerationRatio = 0.8
            };
            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
            sb.Children.Add(slideAnimation);
            sb.Begin(FloatingFrame);
            //Animation.PageAnimation StreetFrameAnimation = new Animation.PageAnimation(street);

            //StreetFrameAnimation.ActualAnimation(0, -this.Height, 0, this.Height, 5);




        }

        private void SearchPriestButton_Click(object sender, RoutedEventArgs e)
        {

            FloatingFrame.NavigationService.Navigate(new ComponentPages.ResponsiblePriest());

            //street.Margin = new Thickness(0, 0, 0, 100);




            var sb = new Storyboard();

            var slideAnimation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(.3)),
                From = new Thickness(0, -this.WindowHeight, this.WindowHeight, 0),
                To = new Thickness(0),
                DecelerationRatio = 0.8
            };
            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
            sb.Children.Add(slideAnimation);
            sb.Begin(FloatingFrame);
        }

        private void SearchConfisionButton_Click(object sender, RoutedEventArgs e)
        {
            FloatingFrame.NavigationService.Navigate(new ComponentPages.ConfessionPriest());

            //street.Margin = new Thickness(0, 0, 0, 100);




            var sb = new Storyboard();

            var slideAnimation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(.3)),
                From = new Thickness(0, -this.WindowHeight, this.WindowHeight, 0),
                To = new Thickness(0),
                DecelerationRatio = 0.8
            };
            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
            sb.Children.Add(slideAnimation);
            sb.Begin(FloatingFrame);
        }

        private void SearchSocialButton_Click(object sender, RoutedEventArgs e)
        {
            FloatingFrame.NavigationService.Navigate(new ComponentPages.SocialCondition());

            //street.Margin = new Thickness(0, 0, 0, 100);




            var sb = new Storyboard();

            var slideAnimation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(.3)),
                From = new Thickness(0, -this.WindowHeight, this.WindowHeight, 0),
                To = new Thickness(0),
                DecelerationRatio = 0.8
            };
            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
            sb.Children.Add(slideAnimation);
            sb.Begin(FloatingFrame);
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            TablePreview preview = new TablePreview(@"E:\Projects\OfflineWpf\PDF\test.pdf");
            preview.Width = 1000;
            preview.Show();
        }

        private void FatherTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if(((TextBox)sender).Text== "ادخل اسم الكاهن")
            ((TextBox)sender).Text = string.Empty;

          
        }

        private void FatherTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == string.Empty)
                ((TextBox)sender).Text = "ادخل اسم الكاهن";
        }

        private void GlobalTextBox_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void GlobalTextBox_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void FatherTextBox_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
