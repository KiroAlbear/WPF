using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using WPF.classes;
namespace WPF.ComponentPages
{
    /// <summary>
    /// Interaction logic for BottomPage.xaml
    /// </summary>
    public partial class BottomPage : Page
    {
        public BottomPage()
        {
            InitializeComponent();
            this.Loaded += Page_loaded;
            Prepare();
        }

        private async void Page_loaded(object sender, RoutedEventArgs e)
        {
            await Animation();
        }

        public async Task Animation()
        {
            var sb = new Storyboard();

            var slideAnimation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(1)),
                From = new Thickness(0, this.WindowWidth, 0, -this.WindowWidth),
                To = new Thickness(0),
                DecelerationRatio = 0.5
            };
            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
            sb.Children.Add(slideAnimation);
            sb.Begin(this);
            //   this.Visibility = Visibility.Visible;
            //await Task.Delay((int)(0.2f * 1000));
        }
        private void Prepare()
        {
            DataGrid visitgrid= (DataGrid)this.FindName("VisitGrid");
            visitgrid.CellStyle = (Style)Application.Current.Resources["BottomGridCellStyle"];
            visitgrid.RowStyle = (Style)Application.Current.Resources["BottomGridRowStyle"];
            visitgrid.ColumnHeaderStyle = (Style)Application.Current.Resources["BottomGridColumnHeaderStyle"];

            

            visitgrid.OnApplyTemplate();

        }
        private void PopCancelButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void PopEditButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void PopSaVeButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(family_data_shared.new_family_head.familyname);
        }


        private void DateCalendar_PreviewMouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            
          
        }
    }
}