using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WPF.Functions
{
    public class ExpanderFunctions
    {
        const string DataGridBackGroundPath = @"\BackGroundImages\DataGridBackGround.png";
        StackPanel stackpanel;
        BitmapImage DataGridBackGround = Functions.BitmapFunctions.FillBitMap(DataGridBackGroundPath);
        DataTable dataTable;
        public ExpanderFunctions(StackPanel stackpanel)
        {
            this.stackpanel = stackpanel;

            ImageBrush imagebrush = new ImageBrush();
            imagebrush.ImageSource = DataGridBackGround;



            SolidColorBrush mySolidColorBrush = new SolidColorBrush();

            // Describes the brush's color using RGB values. 
            // Each value has a range of 0-255.
            mySolidColorBrush.Color = Color.FromRgb(242, 242, 242);
           

            stackpanel.Background = mySolidColorBrush;
        }

        public DataTable Table()
        {
            DataTable newdatatable = new DataTable();
            ////add Columns
            for (int i = 0; i < 10; i++)
            {
                newdatatable.Columns.Add(i.ToString());
            }

            ///add Rows
            for (int row = 0; row < 10; row++)
            {

                newdatatable.Rows.Add(row.ToString());
            }
            Random rnd = new Random();

            for (int row = 0; row < 10; row++)
            {
                for (int column = 0; column < 10; column++)
                {
                    long randomnumber = rnd.Next(1, 1000000);
                    newdatatable.Rows[row][column] = randomnumber.ToString();
                }
            }

            return newdatatable;
        }
        public bool IsExpanderExist(string ExpanderName)
        {

            return false;
        }
        public Expander AddExpanderToStackPanel(string ExpanderName)

        {

            Expander newexpander = NewExpander(ExpanderName);
            stackpanel.Children.Add(newexpander);
            return newexpander;
            ////Register the name of the element so we can search for it lately
            // MainStackPanel.RegisterName(name, newexpander);
        }
        public Expander AddExpanderToExpander(Expander ParentExpander, string NewExpanderName)
        {

            Expander newexpander = NewExpander(NewExpanderName);
            //if (MainStackPanel.Children.Contains(ParentExpander)) ;
            ParentExpander.Content = newexpander;
            return newexpander;
            ////Register the name of the element so we can search for it lately
            //ParentExpander.RegisterName(NewExpanderName, newexpander);
        }

        public Expander NewExpander(string ExpanderName)
        {
            Expander newexpander = null;
            string NoSpaceString = SpaceCleaningString(ExpanderName);

            //if expander register name exist
            if (IsElementExist(NoSpaceString))
            {
                stackpanel.Children.Remove((Expander)stackpanel.FindName(NoSpaceString));
                stackpanel.UnregisterName(NoSpaceString);
                // stackpanel.UpdateLayout();
                // MessageBox.Show("Expander Replaced");
            }
            try
            {


                newexpander = new Expander();



                newexpander.Name = NoSpaceString;
                newexpander.Header = ExpanderName;

                //newexpander.Template = (ControlTemplate)Application.Current.Resources["ExpaanderControlTemplat"];

                newexpander.HeaderTemplate = (DataTemplate)Application.Current.Resources["ExpanderHeaderStyle"];


                //newexpander.Foreground =  Brushes.Wheat;

                //newexpander.MouseEnter += new MouseEventHandler(Expander_MouseEnter);
                //newexpander.MouseLeave += new MouseEventHandler(Expander_MouseLeave);



                ////////////////////////////

                ////Register the name of the element so we can search for it lately
                stackpanel.RegisterName(NoSpaceString, newexpander);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return newexpander;
        }


        public Expander GetExpander(string ExpanderName)
        {
            string NoSpaceString = SpaceCleaningString(ExpanderName);
            Expander existexpander = (Expander)stackpanel.FindName(NoSpaceString);

            return existexpander;
        }

        public DataGrid GetDataGrid(string DatagridName)
        {
            string NoSpaceString = SpaceCleaningString(DatagridName);
            DataGrid existdatagrid = (DataGrid)stackpanel.FindName(NoSpaceString);
            return existdatagrid;
        }

        public static T FindChild<T>(DependencyObject parent, string childName)
         where T : DependencyObject
        {
            // Confirm parent and childName are valid. 
            if (parent == null) return null;

            T foundChild = null;

            int childrenCount = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < childrenCount; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                // If the child is not of the request child type child
                T childType = child as T;
                if (childType == null)
                {
                    // recursively drill down the tree
                    foundChild = FindChild<T>(child, childName);

                    // If the child is found, break so we do not overwrite the found child. 
                    if (foundChild != null) break;
                }
                else if (!string.IsNullOrEmpty(childName))
                {
                    var frameworkElement = child as FrameworkElement;
                    // If the child's name is set for search
                    if (frameworkElement != null && frameworkElement.Name == childName)
                    {
                        // if the child's name is of the request name
                        foundChild = (T)child;
                        break;
                    }
                }
                else
                {
                    // child element found.
                    foundChild = (T)child;
                    break;
                }
            }

            return foundChild;
        }
        public void AddTableToDataGrid(DataTable datatable, DataGrid datagrid)
        {
            // Grid gridInTemplate = (Grid)datagrid.Template.FindName("grid", myButton1);
            this.dataTable = datatable;

            //var child = VisualTreeHelper.GetChild(datagrid, 1);
            // var child = FindChild<TextBlock>(datagrid, "datagridTextBlock");
            //  var dasd = (Style)Application.Current.Resources["DataGridRowStyle1"];
            // var templatedControl = datagrid.Template;//.LoadContent() as FrameworkElement;
            //     var templatedButton = datagrid.FindName("TextBlockGrid") as Grid;

            //  TextBlock gridInTemplate = (TextBlock)datagrid.Template.FindName("datagridTextBlock", datagrid);
            //if (ct != null)
            //    MessageBox.Show(ct.ToString());
            // MessageBox.Show(templatedControl.ToString());
            // MessageBox.Show(datagrid.FindName("TextBlockGrid").ToString());
            //    TextBlock textBlock = (TextBlock)datagrid.RowStyle.FindName("grid", myButton1);
            //         MessageBox.Show(textBlock.Name);
            //for (int row = 0; row < datatable.Rows.Count; row++)
            //{
            //    for (int col = 0; col < datatable.Columns.Count; col++)
            //    {
            //        Object ds = datatable.Rows[row][col];
            //        string str = Convert.ToString(ds);

            //    }

            //}
            // int firstcolwid = ColumnWidth(0, datatable);
            //MessageBox.Show(firstcolwid.ToString());
            datagrid.ItemsSource = datatable.DefaultView;
        }

        public void InsetIntoDataGrid(DataTable table, DataGrid datagrid)
        {
            datagrid.ItemsSource = table.DefaultView;
            datagrid.AutoGeneratingColumn += (s, e) =>
            {

                e.Column.Width = new DataGridLength(1,
                                  DataGridLengthUnitType.
                                    Star);
            };
            //DataGridColumn col = datagrid.Columns[0];
            //col.Width = 222222;


        }
        public string SpaceCleaningString(string anystring)
        {
            return anystring = anystring.Replace(" ", string.Empty);
        }

        private bool IsElementExist(string ElementName)
        {
            var UIElement = stackpanel.FindName(ElementName);
            if (UIElement != null)
                return true;
            else
                return false;
        }

        public DataGrid NewDataGridToExpander(string DataGridName, Expander expander)
        {
            DataGrid temp = null;
            string NoSpaceString = SpaceCleaningString(DataGridName);
            if (IsElementExist(NoSpaceString))
            {
                stackpanel.Children.Remove((DataGrid)stackpanel.FindName(NoSpaceString));
                stackpanel.UnregisterName(NoSpaceString);
                //stackpanel.Children.Clear();
                // stackpanel.UpdateLayout();
                try
                {
                    //expander.UnregisterName(NoSpaceString);
                    // expander.UpdateLayout();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                /// MessageBox.Show("DataGrid Replaced");
            }

            try
            {
                temp = new DataGrid();
                temp.Name = NoSpaceString;
                //Color color = Color.FromRgb(49, 72, 108);





                // Style ColumnheaderStyle = (Style)Application.Current.Resources["DataGridColumnHeaderStyle"];

                temp.CellStyle = (Style)Application.Current.Resources["DataGridCellStyle"];
                // temp.Style = (Style)Application.Current.Resources["DataGridStyl"];

                // temp.RowHeaderTemplate = (DataTemplate)Application.Current.Resources["datagridtemplate"];

                temp.RowStyle = (Style)Application.Current.Resources["DataGridRowStyle"];
                // temp.Opacity = 0.5;
                temp.ColumnHeaderStyle = (Style)Application.Current.Resources["DataGridColumnHeaderStyle"];
                temp.Width = 1000;
                temp.IsReadOnly = true;
                temp.HorizontalAlignment = HorizontalAlignment.Left;
                temp.CanUserAddRows = false;
                Windows.SearchWindows searchWindows = new Windows.SearchWindows();


                temp.Height = 350;
                //  temp.AlternatingRowBackground = Brushes.BlueViolet;
                //  temp.Background = Brushes.LightGray;
                // MessageBox.Show((temp.ColumnWidth.Value).ToString());
                ///temp.CanUserResizeColumns = true;
                ///temp.RowBackground = new SolidColorBrush(color);
                //
                ////ImageBrush imagebrush = new ImageBrush();
                ////imagebrush.ImageSource = DataGridBackGround;
                ////temp.Background = imagebrush;
                //temp.Style = (Style)Application.Current.Resources["DataGridStyl"];
                // 
                // 
                // 
                // temp.MouseDoubleClick += new MouseButtonEventHandler(MydataGride_MouseDoubleClick);
                //temp.MouseEnter += new MouseEventHandler(MydataGride_MouseEnter);
                //   MessageBox.Show((temp.).ToString());
                //temp.PreviewMouseDown += new MouseButtonEventHandler(MydataGride_MouseDown);

                temp.PreviewMouseRightButtonUp += new MouseButtonEventHandler(MydataGride_MouseRightClick);

                expander.RegisterName(NoSpaceString, temp);
                temp.FlowDirection = FlowDirection.RightToLeft;
                temp.AutoGenerateColumns = true;
                temp.OnApplyTemplate();

                expander.Content = temp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return temp;

        }
        public void MydataGride_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var columnIndex = ((DataGrid)sender).Columns.IndexOf(((DataGrid)sender).CurrentColumn);
            MessageBox.Show(columnIndex.ToString());
        }
        public void MydataGride_MouseRightClick(object sender, MouseButtonEventArgs e)
        {
            DependencyObject dep = (DependencyObject)e.OriginalSource;
            while ((dep != null) && !(dep is DataGridCell))
            {
                dep = VisualTreeHelper.GetParent(dep);
            }
            if (dep == null) return;

            if (dep is DataGridCell)
            {
                DataGridCell cell = dep as DataGridCell;
                cell.Focus();

                while ((dep != null) && !(dep is DataGridRow))
                {
                    dep = VisualTreeHelper.GetParent(dep);
                }

                DataGridRow row = dep as DataGridRow;
                ((DataGrid)sender).SelectedItem = row.DataContext;
                 var columnIndex = ((DataGrid)sender).Columns.IndexOf(((DataGrid)sender).CurrentColumn);




                object item = ((DataGrid)sender).SelectedItem;
                string ID = (((DataGrid)sender).SelectedCells[columnIndex].Column.GetCellContent(item) as TextBlock).Text;
                MessageBox.Show(ID);


            }
        }
            public void MydataGride_MouseDoubleClick(object sender, MouseButtonEventArgs e)
            {
                string index = ((DataGrid)sender).SelectedIndex.ToString();
                int Columncount = ((DataGrid)sender).FrozenColumnCount;
                //  Style style = (Style)Application.Current.Resources["TonyIssacCellStyle"];


                var columnIndex = ((DataGrid)sender).Columns.IndexOf(((DataGrid)sender).CurrentColumn);


                var rowIndex = ((DataGrid)sender).Items.IndexOf(((DataGrid)sender).CurrentItem);


                //object item = ((DataGrid)sender).SelectedItem;
                //string ID = (((DataGrid)sender).SelectedCells[columnIndex].Column.GetCellContent(item) as TextBlock).Text;
                //MessageBox.Show(ID);

                // DataGridColumn col = ((DataGrid)sender).Columns[columnIndex];

                ///////change columncolor
                // ((DataGrid)sender).CurrentCell.Column.CellStyle = style;

                /////change row color 
                //  DataGridRow row = (DataGridRow)((DataGrid)sender).ItemContainerGenerator
                // .ContainerFromIndex(rowIndex);

                //  row.Background = Brushes.Yellow;
                /////////////////////////////////////////////////////////////


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

                //Frame fram = new Frame();
                //fram.SetValue(Grid.ColumnProperty, 0);
                //fram.SetValue(Grid.RowProperty, 1);
                //fram.VerticalAlignment = VerticalAlignment.Stretch;
                //fram.HorizontalAlignment = HorizontalAlignment.Stretch;

                //fram.NavigationService.Navigate(new Pop());
                //MainGrid.Children.Add(fram);

                // MessageBox.Show(mylist[1]);


                //PopUpFrame.NavigationService.Navigate(new Pop());

            }

            public double ColumnWidth(DataGrid dataGrid)
            {
                double allcolumnsizw = 0;
                if (dataTable.Columns.Count > 0)
                {

                    Int32 ColumnCount = dataTable.Columns.Count;

                    //var columnIndex = ((DataGrid)).Columns.IndexOf(((DataGrid)sender).CurrentColumn);
                    int maxsize = -1;
                    DataTable data = new DataTable();
                    for (int i = 0; i < ColumnCount; i++)
                    {
                        double columnIndex2 = dataGrid.SelectedCells[i].Column.DisplayIndex;

                        allcolumnsizw += columnIndex2;//Object ds = data.Rows[i][ColumnNumber];
                                                      //string str = Convert.ToString(ds);
                                                      //if (str.Length > maxsize)
                                                      //    maxsize = str.Length;
                    }
                }
                return allcolumnsizw;
            }


            public void MydataGride_MouseEnter(object sender, MouseEventArgs e)
            {
                var columnIndex = ((DataGrid)sender).Columns[2];


                var rowIndex = ((DataGrid)sender).Items.IndexOf(((DataGrid)sender).CurrentItem);
                // int index = ((DataGrid)sender).SelectedIndex;
                MessageBox.Show(columnIndex.ToString());
                //if (columnIndex >0)
                //{          
                //Style style = (Style)Application.Current.Resources["TonyIssacCellStyle"];
                //// ((DataGrid)sender).CurrentCell.Column.CellStyle = style;
                //((DataGrid)sender).CurrentCell.Column.CellStyle = style;
                //}

                //MessageBox.Show(columnIndex.ToString);
                // MessageBox.Show((sender.GetType()).ToString());
            }


        }
    }

