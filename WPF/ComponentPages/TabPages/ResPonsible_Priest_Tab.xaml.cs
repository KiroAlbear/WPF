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
using WPF.Animation;
using WPF.Functions;

namespace WPF.ComponentPages.TabPages
{
    /// <summary>
    /// Interaction logic for ResPonsible_Priest_Tab.xaml
    /// </summary>
    public partial class ResPonsible_Priest_Tab : Page
    {
        string spaces = "                                                                                                          ";
        
        public ResPonsible_Priest_Tab()
        {
            InitializeComponent();
            this.Loaded += Page_loaded;
            

        }

        private async void Page_loaded(object sender, RoutedEventArgs e)
        {
            await AnimatePage();

        }

        public async Task AnimatePage()
        {

            Storyboard storyboard = new Storyboard();
            storyboard.SlideAnimation(-this.WindowWidth / 20, 0, this.WindowWidth, 0, 0.23);
            storyboard.FadeAnimation(0.5);
            storyboard.Begin(this);
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

            if (NameTextBox.Text == string.Empty || NameTextBox.Text == spaces)
                TextBoxValidation.Exception(NameTextBox);
            else
                TextBoxValidation.ReturnNormal(NameTextBox);



        }

        private void ServiceComboBox_MouseEnter(object sender, MouseEventArgs e)
        {
            Color color = Color.FromRgb(49, 89, 102);

        

            ComboBox newCombo = ((ComboBox)sender) as ComboBox;
            newCombo.Background = new SolidColorBrush(color);
          
        }

        private void ServiceComboBox_MouseLeave(object sender, MouseEventArgs e)
        {
            ComboBox newCombo = ((ComboBox)sender) as ComboBox;
            Color color = Color.FromRgb(80, 197, 224);

            newCombo.Background = new SolidColorBrush(color);
          
        }

        private void NameTextBox_Loaded(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == string.Empty)
                ((TextBox)sender).Text = spaces;

        }

        private void NameTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == string.Empty)
                ((TextBox)sender).Text = spaces;

        }

        private void NameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == spaces)
                ((TextBox)sender).Text = string.Empty;
        }
    }
}
