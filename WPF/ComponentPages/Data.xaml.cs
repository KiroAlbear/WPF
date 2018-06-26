using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using MahApps.Metro.Controls;
using WPF.Functions;

namespace WPF.ComponentPages
{
    /// <summary>
    /// Interaction logic for Data.xaml
    /// </summary>
    public partial class Data : Page
    {
        // private List<string> MyList = new List<string>();
       
        private ListView GlobalListView = new ListView();
        string spaces = "                                                                                                          ";
        bool firsttime = false;
        //private SqlConnection con;
        //private SqlCommand com;
        //private SqlDataAdapter rdr;
        //private DataTable tb;

        public delegate void ree();
        public Data()
        {
            InitializeComponent();
            MarriageDataPicker.SelectedDate = DateTime.Today;
            this.Loaded += Page_loaded;
            CreatGlobalList();




        }

        private async void Page_loaded(object sender, RoutedEventArgs e)
        {
            await Animation();
        }

        public async void abc(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("f");
        }

        private void MarriageDataPicker_LostFocus(object sender, RoutedEventArgs e)
        {
            string time = MarriageDataPicker.SelectedDate.Value.Day.ToString() + "/" + MarriageDataPicker.SelectedDate.Value.Month.ToString() + "/" + MarriageDataPicker.SelectedDate.Value.Year.ToString();
            VisitDateTextBox.Text = (time);
        }

        private void MarriageDataPicker_Loaded(object sender, RoutedEventArgs e)
        {
            string time = MarriageDataPicker.SelectedDate.Value.Day.ToString() + "/" + MarriageDataPicker.SelectedDate.Value.Month.ToString() + "/" + MarriageDataPicker.SelectedDate.Value.Year.ToString();

            VisitDateTextBox.Text = time;


            //      MessageBox.Show(MarriageDataPicker.SelectedDateFormat.ToString());
        }

        private void TextBox_Loaded(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == string.Empty)
                ((TextBox)sender).Text = spaces;
        }

        public async Task Animation()
        {
            var sb = new Storyboard();

            var slideAnimation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(0.8f)),
                From = new Thickness(0, this.WindowHeight, 0, -this.WindowHeight),
                To = new Thickness(0),
                DecelerationRatio = 0.5
            };
            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
            sb.Children.Add(slideAnimation);
            sb.Begin(this);
            //   this.Visibility = Visibility.Visible;
            // await Task.Delay((int)(0.8f * 1000));
        }


        private List<string> GetFromDataBase(string text, string columnName, string DataBaseName)
        {

            List<string> MyList = new List<string>();
            ////  MyList.Clear();
            ////   MessageBox.Show(MyList.Count.ToString());
            //con = new SqlConnection(@"Data Source=desktop-bcrn859\sqlexpress;Initial Catalog=familydb;Integrated Security=True");
            ////       SqlCommand com = new SqlCommand("select familycode , familyname,streetname from family join streets on family.streetcode=streets.Streetcode ", con);
            //com = new SqlCommand("select " + columnName + " from " + DataBaseName + " where " + columnName + " like '%" + text + "%'", con);

            //con.Open();
            //SqlDataReader read = com.ExecuteReader();
            //while (read.Read())
            //{

            //    MyList.Add(read[columnName].ToString());
            //    //   MessageBox.Show(read["priestname"].ToString());
            //}


            //con.Close();
            return MyList;

        }

        private void GlobalTextBox_Loaded(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Text = spaces;


            if (TableGrid.Children.Contains(GlobalListView))
            {
                GlobalListView.ItemsSource = null;
                TableGrid.Children.Remove(GlobalListView);
            }

            ShowList(GlobalListView, false);

          

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

        private void GlobalTextBox_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (((TextBox)sender).Name == PriestTextBox.Name)
            {
                //List<string> PriestListDoubleClick = new List<string>();
                //PriestListDoubleClick = GetFromDataBase(" ", "priestname", "priests");
                //GlobalListView.ItemsSource = PriestListDoubleClick;
                //list_functions f=new list_functions();
                ////  ShowList(GlobalListView, false);
                
                ////  ShowList(GlobalListView, true);

                //ShowList(GlobalListView, true);
            }

            if (((TextBox)sender).Name == ChurchBox.Name)
            {
                //List<string> ChurchListDoubleClick = new List<string>();
                //// List<string> churcList = new List<string>();
                //ChurchListDoubleClick = GetFromDataBase(" ", "churchname", "churches");
                //GlobalListView.ItemsSource = ChurchListDoubleClick;

                ////  ShowList(GlobalListView, false);
                ////  ShowList(GlobalListView, true);

                //ShowList(GlobalListView, true);
            }
            if (((TextBox)sender).Name == StreetTextBox.Name)
            {
                //List<string> ChurchListDoubleClick = new List<string>();
                //// List<string> churcList = new List<string>();
                //ChurchListDoubleClick = GetFromDataBase(" ", "streetname", "streets");
                //GlobalListView.ItemsSource = ChurchListDoubleClick;

                ////  ShowList(GlobalListView, false);
                ////  ShowList(GlobalListView, true);

                //ShowList(GlobalListView, true);
            }
            //  ShowList(GlobalListView, true);
        }

        private void PositioningGlobalList(int row, int col)
        {
            GlobalListView.SetValue(Grid.RowProperty, row);
            GlobalListView.SetValue(Grid.ColumnProperty, col);
            TableGrid.Children.Add(GlobalListView);
            GlobalListView.SelectedIndex = 0;
        }
        private void ShowList(ListView listview, bool Switch)
        {
            if (Switch)
                listview.Visibility = Visibility.Visible;
            else
                listview.Visibility = Visibility.Collapsed;
        }
        private void GLOBAL_TextChanged(object sender, TextChangedEventArgs e)
        {
         
            if (((TextBox)sender).Name == PriestTextBox.Name)
            {
                
                //List<string> priestList = new List<string>();
                //priestList.Add("asdasd");
                //priestList.Add("asdasd");
                //priestList.Add("asdasd");
                
                ////priestList = GetFromDataBase(PriestTextBox.Text, "paxname", "familydetails");
                //GlobalListView.ItemsSource = priestList;

                ////  ShowList(GlobalListView, false);
                ////  ShowList(GlobalListView, true);
                //ShowList(GlobalListView, true);

            }
            else if (((TextBox)sender).Name == ChurchBox.Name)
            {

                //List<string> churcList = new List<string>();
                //churcList = GetFromDataBase(ChurchBox.Text, "churchname", "churches");
                //GlobalListView.ItemsSource = churcList;

                ////  ShowList(GlobalListView, false);
                ////  ShowList(GlobalListView, true);

                //ShowList(GlobalListView, true);
            }
            else if (((TextBox)sender).Name == StreetTextBox.Name)
            {

                //List<string> churcList = new List<string>();
                //churcList = GetFromDataBase(StreetTextBox.Text, "streetname", "streets");
                //GlobalListView.ItemsSource = churcList;

                ////  ShowList(GlobalListView, false);
                ////  ShowList(GlobalListView, true);

                //ShowList(GlobalListView, true);
            }




        }

        private void CreatGlobalList()
        {
            //GlobalListView.SetValue(Grid.ColumnProperty, 1);
            //GlobalListView.SetValue(Grid.RowProperty, 1);
            GlobalListView.Style = (Style)FindResource("StylishList");
            // AddAndFillList();
            //GlobalListView.ItemsSource = MyList;
            //TableGrid.Children.Add(GlobalListView);
            ShowList(GlobalListView, false);
        }


        /*private void AddAndFillList()
        {
            MyList.Add("ان");
            MyList.Add("مكنتش");
            MyList.Add("انت");
            MyList.Add("تدلعنى");
            MyList.Add("مين");
            MyList.Add("هيدلعنى");
            MyList.Add("يييي");
            MyList.Add("يييي");
            MyList.Add("");
        }
    */
        private void AutoCompleteList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //PriestTextBox.TextChanged -= new TextChangedEventHandler(PriestTextBox_TextChanged);
            //ShowList(AutoCompleteList, false);
            //if (AutoCompleteList.SelectedIndex != -1)
            //{
            //    PriestTextBox.Text = AutoCompleteList.SelectedItem.ToString();
            //}
            //PriestTextBox.TextChanged += new TextChangedEventHandler(PriestTextBox_TextChanged);


        }

        private void SubmitButton_KeyDown(object sender, KeyEventArgs e)
        {
            list_functions f=new list_functions();

            // if(e.Key==((Key.LeftShift)|(Key.Tab)))
            //{
            //    e.Handled = true;
            //    PersonsNumberTextBox.Focus();
            //}
            

            if ((e.Key == Key.Tab))
            {
                e.Handled = true;
                PriestTextBox.Focus();
            }

        }


        private void MovinginGlobalList(Key KeyBoardKey)
        {
            if (KeyBoardKey.Equals(Key.Down))
            {
                //  GlobalListView.SelectedIndex++;
            }
        }

        //pass calendar focus
        private void PassCalendar_KeyDown(object sender, KeyEventArgs e)
        {
            //if ((e.Key == Key.Tab) && (((TextBox)sender).Name == MariageDateTextBox.Name))
            //{
            //    e.Handled = true;
            //    PersonsNumberTextBox.Focus();
            //}

            //else if ((((TextBox)sender).Name == PersonsNumberTextBox.Name) && (e.Key == (Key.Tab | Key.LeftShift)))
            //{
            //    e.Handled = true;
            //    MariageDateTextBox.Focus();
            //}
        }


        private void PriestTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

<<<<<<< HEAD
        private void PriestTextBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
	        
            if (firsttimepriest == true)
=======
            if (e.Key == Key.Down&&GlobalListView.Visibility==Visibility.Visible)
>>>>>>> parent of 991f202... ComboBox Fix KeyBoard keyDown
            {
                
                GlobalListView.SelectedIndex++;


            }
            else if (e.Key == Key.Down && GlobalListView.Visibility == Visibility.Collapsed)
            {
                GlobalTextBox_MouseDoubleClick(sender, null);
               // ShowList(GlobalListView,true);
            }

            else if (e.Key == Key.Up && (GlobalListView.SelectedIndex > 0))
            {
                GlobalListView.SelectedIndex--;
            }

            #region ifEnter is Pressed
            else if (e.Key == Key.Enter&&GlobalListView.SelectedIndex>=0)
            {
                if (((TextBox)sender).Name == PriestTextBox.Name)
                {
                    PriestTextBox.Text = GlobalListView.SelectedItem.ToString();
                    ShowList(GlobalListView, false);
                }
                if (((TextBox)sender).Name == ChurchBox.Name)
                {
                    ChurchBox.Text = GlobalListView.SelectedItem.ToString();
                    ShowList(GlobalListView, false);
                }
                if (((TextBox)sender).Name == PersonBox.Name)
                {
                    PersonBox.Text = GlobalListView.SelectedItem.ToString();
                    ShowList(GlobalListView, false);
                }

                if (((TextBox)sender).Name == StreetTextBox.Name)
                {
                    StreetTextBox.Text = GlobalListView.SelectedItem.ToString();
                    ShowList(GlobalListView, false);
                }

                if (((TextBox)sender).Name == RegionTextBox.Name)
                {
                    RegionTextBox.Text = GlobalListView.SelectedItem.ToString();
                    ShowList(GlobalListView, false);
                }
                



            }
           
            #endregion  ifEnter is Pressed

            GlobalListView.ScrollIntoView(GlobalListView.SelectedItem);
            return;

        }

        private void Telefone1Textbox_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
         
        }

        private void MariageDateTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

<<<<<<< HEAD

        //private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
          
        //    string selecteditem = ((ListView)sender).SelectedItem.ToString();

        //    if (((ListView)sender).Name == PriestListName)
        //    {
        //        PriestTextBox.Text = selecteditem;
        //      //  PriestTextBox.Focus();
        //    }
        //    else if (((ListView)sender).Name == ChurchListView.Name)
        //        ChurchBox.Text = selecteditem;
        //    else if (((ListView)sender).Name == StreetListView.Name)
        //        StreetTextBox.Text = selecteditem;
=======
     
        private void PriestTextBox_Loaded(object sender, RoutedEventArgs e)
        {
>>>>>>> parent of 991f202... ComboBox Fix KeyBoard keyDown

            List<string> testlist = new List<string>();

            testlist.Add("Hello");
            testlist.Add("World");
            testlist.Add("Hai");

<<<<<<< HEAD
        //}
=======
>>>>>>> parent of 991f202... ComboBox Fix KeyBoard keyDown

          
        }

        private void PriestTextBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
<<<<<<< HEAD
            //((ListView)sender).HideSelection = false;
            ListViewItem item = ((ListView)sender).ItemContainerGenerator.ContainerFromIndex(((ListView)sender).SelectedIndex) as ListViewItem;
            item.Focus();

            if (((ListView)sender).Name == PriestListName)
            {
                if (e.Key==Key.Down&& ((ListView)sender).SelectedIndex < ((ListView)sender).Items.Count)
                {
                    ((ListView)sender).SelectedIndex++;
                   
                }

                else if (e.Key == Key.Up && ((ListView)sender).SelectedIndex>0)
                    ((ListView)sender).SelectedIndex--;
                else if(e.Key == Key.Enter)
                {
                    PriestTextBox.Text = ((ListView)sender).SelectedItem.ToString();
                    ((ListView)sender).Visibility = Visibility.Collapsed;
                 
                }

            }
=======
>>>>>>> parent of 991f202... ComboBox Fix KeyBoard keyDown

        }

        private void GlobalTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == string.Empty || ((TextBox)sender).Text == spaces)
                ((TextBox)sender).Text = spaces;
        }
    }
}