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
using System.Windows.Media.Animation;
namespace WPF.ComponentPages
{
    /// <summary>
    /// Interaction logic for DataPage.xaml
    /// </summary>
    public partial class DataPage : Page
    {
        public DataPage()
        {
            InitializeComponent();
            MarriageDataPicker.SelectedDate = DateTime.Today;
            PriestCombo.Items.Add("wwwwwwwwwwwwwwwwwwwww");
            PriestCombo.Items.Add("antonious isaac");


            this.Loaded += Page_loaded;
        }

        private async void Page_loaded(object sender,RoutedEventArgs e)
        {
             await Animation();
        }
        private void MarriageDataPicker_LostFocus(object sender, RoutedEventArgs e)
        {

            string time = MarriageDataPicker.SelectedDate.Value.Day.ToString() + "/" + MarriageDataPicker.SelectedDate.Value.Month.ToString() + "/" + MarriageDataPicker.SelectedDate.Value.Year.ToString();
            MariageDateTextBox.Text = (time);

        }

        private void MarriageDataPicker_Loaded(object sender, RoutedEventArgs e)
        {
            string time = MarriageDataPicker.SelectedDate.Value.Day.ToString() + "/" + MarriageDataPicker.SelectedDate.Value.Month.ToString() + "/" + MarriageDataPicker.SelectedDate.Value.Year.ToString();

            MariageDateTextBox.Text = time;

            //      MessageBox.Show(MarriageDataPicker.SelectedDateFormat.ToString());

        }
        private void ChurchCombo_GotFocus(object sender, RoutedEventArgs e)
        {
            PriestTextBox.Focus();
            return;
        }
        private void TextBox_Loaded(object sender, RoutedEventArgs e)
        {
            TextBox textbox = new TextBox();
            textbox = (TextBox)sender;
            textbox.Focus();
        }

        public async Task Animation()
        {
            var sb = new Storyboard();

            var slideAnimation = new ThicknessAnimation {
                Duration = new Duration(TimeSpan.FromSeconds(0.8f)),
                From = new Thickness(0, this.WindowHeight, 0, -this.WindowHeight),
                To = new Thickness(0),
                DecelerationRatio = 0.5
            };
            Storyboard.SetTargetProperty(slideAnimation,new PropertyPath("Margin"));
            sb.Children.Add(slideAnimation);
            sb.Begin(this);
         //   this.Visibility = Visibility.Visible;
          // await Task.Delay((int)(0.8f * 1000));
           
        }

        private void PriestCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
