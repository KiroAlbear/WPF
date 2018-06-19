using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace WPF
{
    /// <summary>
    /// Interaction logic for EntryWindow.xaml
    /// </summary>
    public partial class EntryWindow : MahApps.Metro.Controls.MetroWindow
    {
        public ComponentPages.Data my_own_data { set; get; }
        public ComponentPages.BottomPage my_own_bottom { set; get; }
        object sender=null;
        public EntryWindow(object sender)
        {
            
            InitializeComponent();
            this.sender = sender;
            this.Closing += new System.ComponentModel.CancelEventHandler(Window4_Closing);
            //MarriageDataPicker.SelectedDate = DateTime.Today;

            if (((Button)sender).Name== ItemsNames.ItemsNameStrings.RegisterButton)
            {
                DataPage_Load();
                DataGridView_Load();
                BottomPage_Load();
              
            }
            //StreetFrame.NavigationService.Navigate(new ComponentPages.StreetPage());
            
        }
        public EntryWindow(object sender,ComponentPages.Data d,ComponentPages.BottomPage b)
        {
            
            InitializeComponent();
            this.sender = sender;
            this.Closing += new System.ComponentModel.CancelEventHandler(Window4_Closing);
            //MarriageDataPicker.SelectedDate = DateTime.Today;
            my_own_data = d;
            my_own_bottom = b;
            if (((Button)sender).Name == ItemsNames.ItemsNameStrings.RegisterButton)
            {

                DataPage_Load();
                DataGridView_Load();
                BottomPage_Load();

            }
            //StreetFrame.NavigationService.Navigate(new ComponentPages.StreetPage());

        }

        /////////////// Border Change Color/////////////////////

        /// ///////91, 194, 255//////////////// msh asly
        //// 22, 169, 255/////////asly


        public string RearrangeDate(string time)
        {
            char[] TimeAr = new char[12];
            TimeAr = time.ToCharArray(0, 10);

            char[] day = new char[3];
            char[] month = new char[3];
            char[] year = new char[5];
            string monthstr;
            string daystr;
            string yearstr;
            int k = 0;
            int breakpoint = 0;

            for (int i = 0; i < TimeAr.Length; i++)
            {
                month[k] = TimeAr[i];
                if (TimeAr[i] == '/')
                {
                    breakpoint = i;
                    break;
                }

                k++;
            }

            int monthelem = k + 1;
            if (monthelem == 2)
            {
                month[2] = month[1];
                month[1] = month[0];
                month[0] = '0';

                monthstr = new string(month);
            }
            else
                monthstr = new string(month);

            k = 0;
            for (int i = breakpoint + 1; i < TimeAr.Length; i++)
            {
                day[k] = TimeAr[i];
                if (TimeAr[i] == '/')
                {
                    breakpoint = i;

                    break;
                }
                k++;
            }
            int dayelem = k + 1;

            if (dayelem == 2)
            {
                day[2] = day[1];
                day[1] = day[0];
                day[0] = '0';

                daystr = new string(day);
            }
            else
            {
                daystr = new string(day);
            }

            k = 0;
            for (int i = breakpoint + 1; i < TimeAr.Length; i++)
            {
                year[k] = TimeAr[i];
                if (year.Length == 4)
                {
                    break;
                }

                k++;
            }

            //  if (year[4] == '\0')
            // year[4] = ' ';

            yearstr = new string(year);

            //string newtime = "";

            string final1 = daystr + monthstr + yearstr;

            //string final2 = final1.Insert(2, monthstr);

            //string final3 = final2.Insert(dayelem + monthelem, yearstr);

            return final1;
        }
        void Window4_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
           
                if (MessageBox.Show("Test", "asdasd", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                {
                    this.Hide();
                    //Application.Current.Shutdown();

                    //  return;
                }

                else
                {

                }


            }


            private void PopUpGrid_Loaded(object sender, RoutedEventArgs e)
        {
            //for (int row = 0; row < 6; row++)
            //{
            //    TextBox newbox = new TextBox();
            //    newbox.Width = 100;
            //    newbox.Height = 150;
            //    newbox.Background = Brushes.Black;
            //    newbox.Style = Resources["{StaticResource TextBoxStyle}"] as Style;
            //    newbox.SetValue(Grid.ColumnProperty, 0);
            //    newbox.SetValue(Grid.RowProperty, row);
            //    PopUpGrid.Children.Add(newbox);
            //}
        }

        private void TestButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void XButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Button exit = new Button();
            exit = (Button)sender;
            exit.Background = Brushes.Blue;
        }

        private void XButton_MouseLeave(object sender, MouseEventArgs e)
        {
            Button exit = new Button();
            exit = (Button)sender;
            exit.Background = Brushes.Red;
        }

        private void DataPage_Load()
        {
            // this object created to be passed into anywhere i want
            ComponentPages.Data my_data_oblect = new ComponentPages.Data();
            DataFrame.NavigationService.Navigate(my_own_data);
            DataFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            //MainGrid.Children.Add(DataFrame);
        }

        private void BottomPage_Load()
        {
            // this object created to be passed into anywhere i want
            BottomPageFrame.NavigationService.Navigate(my_own_bottom);
            BottomPageFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
        }

        private void DataGridView_Load()
        {
            bool enablePopPage = true;
            DataGridViewFrame.NavigationService.Navigate(new ComponentPages.DataGridView(enablePopPage));
            DataGridViewFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
        }
    }
}