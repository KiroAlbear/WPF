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
using System.Windows.Shapes;



namespace WPF
{
    /// <summary>
    /// Interaction logic for EntryWindow.xaml
    /// </summary>
    public partial class EntryWindow : Window
    {
       
        public EntryWindow()
        {
            InitializeComponent();
            //MarriageDataPicker.SelectedDate = DateTime.Today;
            MarriageDataPicker.SelectedDate = DateTime.Today;

        }



        /////////////// Border Change Color/////////////////////

        /// ///////91, 194, 255//////////////// msh asly    
              //// 22, 169, 255/////////asly

      
      
        public class Person
        {
          
          public  string name;
           public string age;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Button_Click(sender, e);
        }

  
        private void MydataGride_Loaded(object sender, RoutedEventArgs e)
        {
            List<Person> nmylist = new List<Person>();
            for (int i = 0; i < 4; i++)
            {
                Person per = new Person();
                per.name = "kiro" + i.ToString();
                per.age = i.ToString();
            }

            MydataGride.ItemsSource = nmylist;
        

          
          
        }

        private void MarriageDataPicker_LostFocus(object sender, RoutedEventArgs e)
        {

            string time = MarriageDataPicker.SelectedDate.Value.Day.ToString()  +"/" + MarriageDataPicker.SelectedDate.Value.Month.ToString() + "/" + MarriageDataPicker.SelectedDate.Value.Year.ToString();
            MariageDateTextBox.Text = (time);
           
        }

        private void MarriageDataPicker_Loaded(object sender, RoutedEventArgs e)
        {
            string time = MarriageDataPicker.SelectedDate.Value.Day.ToString() + "/" + MarriageDataPicker.SelectedDate.Value.Month.ToString() + "/" + MarriageDataPicker.SelectedDate.Value.Year.ToString();

            MariageDateTextBox.Text = time;
           
      //      MessageBox.Show(MarriageDataPicker.SelectedDateFormat.ToString());

        }

        public string RearrangeDate(string time)
        {
            char[] TimeAr = new char[12];
            TimeAr = time.ToCharArray(0,10);
            
            char[] day = new char[3];
            char[] month = new char[3];
            char[] year = new char[5];
            string monthstr;
            string daystr;
            string yearstr; 
            int k = 0;
            int breakpoint=0;

            for (int i = 0; i < TimeAr.Length; i++)
            {
                month[k] = TimeAr[i];
                if (TimeAr[i] == '/') {

                    breakpoint = i;
                    break;
                } 

                k++;
            }

            int monthelem = k+1;
            if (monthelem==2)
            {
                month[2] = month[1];
                month[1] = month[0];
                month[0] = '0';
               
                monthstr = new string(month);
            }
            else
                monthstr = new string(month);


            k = 0;
            for (int i = breakpoint+1 ; i <TimeAr.Length; i++)
            {
               
                day[k] = TimeAr[i];
                if (TimeAr[i] == '/') {
                    breakpoint = i;

                    break;
                } 
                k++;
            }
            int dayelem = k+1;


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
            for (int i = breakpoint+1; i < TimeAr.Length; i++)
            {

                year[k] = TimeAr[i];
                if (year.Length == 4) {

                    break;
                }
               
                k++;
              
            }


          //  if (year[4] == '\0')
               // year[4] = ' ';

                yearstr = new string(year);

                //string newtime = "";

            string final1 = daystr+monthstr+yearstr;
        
            //string final2 = final1.Insert(2, monthstr);

            //string final3 = final2.Insert(dayelem + monthelem, yearstr);

            return final1 ;
          
            


        }

        Grid NewGride;
        private void MydataGride_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            //RowDefinition Row2= MainRow2;
            //ColumnDefinition column1 = MainColumn1;
            // NewGride = new Grid();
            //NewGride.Background = Brushes.Red;
            //NewGride.Width = 870;
            //NewGride.Height = 550;
            //NewGride.Margin = new Thickness(0, 0, 25, 0);
            //NewGride.Opacity = 0.7;

            //NewGride.SetValue(Grid.RowProperty, 1);
            //NewGride.SetValue(Grid.ColumnProperty, 0);
            //NewGride.HorizontalAlignment = HorizontalAlignment.Center;
            //NewGride.VerticalAlignment = VerticalAlignment.Center;
            //MainGrid.Children.Add(NewGride);
            Frame fram = new Frame();
            fram.SetValue(Grid.ColumnProperty, 0);
            fram.SetValue(Grid.RowProperty, 1);

            fram.NavigationService.Navigate(new Pop());
            MainGrid.Children.Add(fram);

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


        //private void SaveButton_Click(object sender,RoutedEvent e)
        //{
        //    PopUpGrid.Visibility = Visibility.Collapsed;
        //}


    }
}
