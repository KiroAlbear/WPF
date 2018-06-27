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
using WPF.classes;
using System.Linq;

namespace WPF.ComponentPages
{
    /// <summary>
    /// Interaction logic for Data.xaml
    /// </summary>
    public partial class Data : Page
    {
        // private List<string> MyList = new List<string>();
        DatabaseFamilyDataContext dd = new DatabaseFamilyDataContext();
        private ListView PriestListView;
        private ListView ChurchListView;
        private ListView StreetListView;

        string spaces = "                                                                                                          ";
        bool firsttime = false;
        bool visible = false;

        string PriestListName = "PriestList";
        string ChurchListName = "ChurchList";
        string StreettListName    = "StreetList";


        bool firsttimepriest = true;
        bool firsttimechurch = true;
        bool firsttimestreet = true;

        bool priestlistvisible = false;
        bool churchlistvisible = false;
        bool streetlistvisible = false;
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


            //if (TableGrid.Children.Contains(GlobalListView))
            //{
            //    GlobalListView.ItemsSource = null;
            //    TableGrid.Children.Remove(GlobalListView);
            //}

           // ShowList(GlobalListView, false);

          

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

        private void PositioningGlobalList(int row, int col,string ListName,ListView listView)
        {



            listView.Style = (Style)FindResource("StylishList");
            listView.SetValue(Grid.RowProperty, row);
            listView.SetValue(Grid.ColumnProperty, col);
            listView.Name = ListName;
          //  listView.SelectionChanged += new SelectionChangedEventHandler(ListView_SelectionChanged);
            listView.PreviewKeyUp += new KeyEventHandler(Listview_PreviewKeyDown);
            listView.PreviewMouseLeftButtonUp += new MouseButtonEventHandler(Listview_PreviewMouseLeftButtonUp);

            TableGrid.Children.Add(listView);
            listView.SelectedIndex = 0;
        }
        private void ShowList(ListView listview, bool Switch)
        {
            if (Switch)
            {
                listview.Visibility = Visibility.Visible;
                Keyboard.Focus(listview);
              
            }
            else
            {
             
                listview.Visibility = Visibility.Collapsed;

            }
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
         
            // AddAndFillList();
            //GlobalListView.ItemsSource = MyList;
            //TableGrid.Children.Add(GlobalListView);
           // ShowList(GlobalListView, false);
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


        private void Telefone1Textbox_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
         
        }

        private void MariageDateTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

     
        private void PriestTextBox_Loaded(object sender, RoutedEventArgs e)
        {
            DatabaseFamilyDataContext dd = new DatabaseFamilyDataContext();
            var a = (from aa in new DatabaseFamilyDataContext().responsiblepriests
                     where aa.responsiblepriestcode > 0
                     select new responsiblepriests
                     {
                         responsiblepriestname = aa.responsiblepriestname
                     }).ToList();
            PriestTextBox.Text = spaces;

          //  List<string> testlist = dd.responsiblepriests;
          
            PriestListView = new ListView();
            PriestListView.ItemsSource = dd.responsiblepriests.Select(o => o.responsiblepriestname).ToList(); 


            //testlist.Add("Hello");
            //testlist.Add("World");
            //testlist.Add("Hai");



        }

     

        private void GlobalTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            family f = new family();
            if (((TextBox)sender).Text == string.Empty || ((TextBox)sender).Text == spaces)
                ((TextBox)sender).Text = spaces;
            family_data_shared.new_family_head = new family();
            family_data_shared.new_family_head.familyname = PersonBox.Text;
            if(((TextBox)sender).Name==PriestTextBox.Name)
            {
                
            }
            if (((TextBox)sender).Name == ChurchBox.Name)
            {

            }
            if (((TextBox)sender).Name == PriestTextBox.Name)
            {

            }
            if (((TextBox)sender).Name == PersonBox.Name)
            {

            }
            if (((TextBox)sender).Name == HouseNuberBox.Name)
            {

            }
            if (((TextBox)sender).Name == StreetTextBox.Name)
            {

            }
            if (((TextBox)sender).Name == FloorTextBox.Name)
            {

            }
            if (((TextBox)sender).Name == ApartmentTextBox.Name)
            {

            }
            if (((TextBox)sender).Name == RegionTextBox.Name)
            {

            }
            if (((TextBox)sender).Name == AdressDesciption.Name)
            {

            }
            if (((TextBox)sender).Name == Telefone1Textbox.Name)
            {

            }
            if (((TextBox)sender).Name == Telefone2Textbox.Name)
            {

            }
            if (((TextBox)sender).Name == VisitDateTextBox.Name)
            {

            }
            if (((TextBox)sender).Name == PersonsNumberTextBox.Name)
            {

            }
            if (((TextBox)sender).Name == NotesTextbox.Name)
            {

            }

        }

     

        private void PriestTextBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
			 
            if (firsttimepriest == true)
            {

                PositioningGlobalList(1, 0, PriestListName, PriestListView);
                ShowList(PriestListView, true);
                firsttimepriest = false;
                priestlistvisible = true;
            }

            else if (priestlistvisible == false && firsttimepriest == false)
            {
                ShowList(PriestListView, true);
                priestlistvisible = true;

            }
            else if (priestlistvisible == true && firsttimepriest == false)
            {
                ShowList(PriestListView, false);
                priestlistvisible = false;
            }



        }

        private void PriestTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            //if (priestlistvisible == true && firsttimepriest == false)
            //{
                ShowList(PriestListView, false);
            //    priestlistvisible = false;
            //}
        }

        private void ChurchBox_LostFocus(object sender, RoutedEventArgs e)
        {
           // if (churchlistvisible == true && firsttimechurch == false)
            {
                ShowList(ChurchListView, false);
            //    churchlistvisible = false;
            }

        }

        private void ChurchBox_Loaded(object sender, RoutedEventArgs e)
        {
            
            ChurchBox.Text = spaces;
            ChurchListView = new ListView();
            ChurchListView.ItemsSource = dd.churches.Select(o => o.churchname).ToList();
        }

        private void ChurchBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
            if (firsttimechurch==true)
            {

            PositioningGlobalList(2, 0, ChurchListName , ChurchListView);
            ShowList(ChurchListView, true);
                firsttimechurch = false;
               churchlistvisible = true;
            }

            else if(churchlistvisible == false&& firsttimechurch == false)
            {
                ShowList(ChurchListView, true);
                churchlistvisible = true;

            }
            else if (churchlistvisible == true && firsttimechurch == false)
            {
                ShowList(ChurchListView, false);
                churchlistvisible = false;
            }


        }

        private void StreetTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
           // if (streetlistvisible == true && firsttimestreet == false)
            {
                ShowList(StreetListView, false);
              //  streetlistvisible = false;
            }
        }

        private void StreetTextBox_Loaded(object sender, RoutedEventArgs e)
        {
            StreetTextBox.Text = spaces;
            StreetListView = new ListView();
        }

        private void StreetTextBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
            if (firsttimestreet == true)
            {

                PositioningGlobalList(4, 0, StreettListName, StreetListView);
                ShowList(StreetListView, true);
                firsttimestreet = false;
                streetlistvisible = true;
            }

            else if (streetlistvisible == false && firsttimestreet == false)
            {
                ShowList(StreetListView, true);
                streetlistvisible = true;

            }
            else if (streetlistvisible == true && firsttimestreet == false)
            {
                ShowList(StreetListView, false);
                streetlistvisible = false;
            }
          
        }


        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
            string selecteditem = ((ListView)sender).SelectedItem.ToString();

            if (((ListView)sender).Name == PriestListName)
            {
                PriestTextBox.Text = selecteditem;
              //  PriestTextBox.Focus();
            }
            else if (((ListView)sender).Name == ChurchListView.Name)
                ChurchBox.Text = selecteditem;
            else if (((ListView)sender).Name == StreetListView.Name)
                StreetTextBox.Text = selecteditem;



        }

        private void PriestTextBox_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
          
        }


        private void Listview_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            //((ListView)sender).HideSelection = false;
            ListViewItem item = ((ListView)sender).ItemContainerGenerator.ContainerFromIndex(((ListView)sender).SelectedIndex) as ListViewItem;
            item.Focus();

           
                if (e.Key==Key.Down&& ((ListView)sender).SelectedIndex < ((ListView)sender).Items.Count)
                {
                    ((ListView)sender).SelectedIndex++;
                   
                }

                else if (e.Key == Key.Up && ((ListView)sender).SelectedIndex>0)
                    ((ListView)sender).SelectedIndex--;
                else if(e.Key == Key.Enter)
                {
                    if (((ListView)sender).Name==PriestListName)
                    {
                    PriestTextBox.Text = ((ListView)sender).SelectedItem.ToString();
                    ((ListView)sender).Visibility = Visibility.Collapsed;
                    }
                    else if (((ListView)sender).Name==ChurchListName)
                    {
                        ChurchBox.Text = ((ListView)sender).SelectedItem.ToString();
                        ((ListView)sender).Visibility = Visibility.Collapsed;
                    }
                    else if (((ListView)sender).Name==StreettListName)
                    {
                        StreetTextBox.Text = ((ListView)sender).SelectedItem.ToString();
                        ((ListView)sender).Visibility = Visibility.Collapsed;
                    }
                }

            

        }

        private void Listview_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
          
            if (((ListView)sender).Name == PriestListName)
            {
                PriestTextBox.Text = ((ListView)sender).SelectedItem.ToString();
                ((ListView)sender).Visibility = Visibility.Collapsed;
            }
            else if (((ListView)sender).Name == ChurchListName)
            {
                ChurchBox.Text = ((ListView)sender).SelectedItem.ToString();
                ((ListView)sender).Visibility = Visibility.Collapsed;
            }
            else if (((ListView)sender).Name == StreettListName)
            {
                StreetTextBox.Text = ((ListView)sender).SelectedItem.ToString();
                ((ListView)sender).Visibility = Visibility.Collapsed;
            }
        }




    }
}