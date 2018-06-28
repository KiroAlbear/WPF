using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPF.Functions
{
    class ListViewPrepare
    {
        ListView listview;
       
        Grid grid;
        Style style;
        int row;
        int col;
        bool visible = false;
        bool firsttime = true;
        string listname = "";
        public ListViewPrepare(ListView listview,Grid grid,int row,int col,string listname,Style style)
        {
            this.listview = listview;
            this.grid = grid;
            this.listname = listname;
            this.style = style;
            this.row = row;
            this.col = col;

        }
        private void ShowList(bool Switch)
        {
            if (Switch)
            {
                listview.Visibility = Visibility.Visible;
                Keyboard.Focus(listview);
            }
            else
                listview.Visibility = Visibility.Collapsed;

        }

        public void TextBoxMouseDownFunction()
        {
 
            if (firsttime == true)
            {

                PositioningGlobalList();
                ShowList( true);
                firsttime = false;
                visible = true;
            }

            else if (visible == false && firsttime == false)
            {
                ShowList(true);
                visible = true;

            }
            else if (visible == true && firsttime == false)
            {
                ShowList(false);
                visible = false;
            }
        }

        private void PositioningGlobalList()
        {



            listview.Style = style;
            listview.SetValue(Grid.RowProperty, row);
            listview.SetValue(Grid.ColumnProperty, col);
            listview.Name = listname;
            //  listView.SelectionChanged += new SelectionChangedEventHandler(ListView_SelectionChanged);
          


            grid.Children.Add(listview);
            listview.SelectedIndex = 0;
        }

        public void ListViewKeyDownFunction(TextBox textBox,KeyEventArgs e)
        {
            ListViewItem item = listview.ItemContainerGenerator.ContainerFromIndex(listview.SelectedIndex) as ListViewItem;
            item.Focus();


            if (e.Key == Key.Down && listview.SelectedIndex < listview.Items.Count)
            {
                listview.SelectedIndex++;

            }

            else if (e.Key == Key.Up && listview.SelectedIndex > 0)
                listview.SelectedIndex--;
            else if (e.Key == Key.Enter)
            {
                
                    textBox.Text = listview.SelectedItem.ToString();
                    listview.Visibility = Visibility.Collapsed;
                

            }
        }

        public void ListViewMouseDown(TextBox textBox)
        {

            textBox.Text = listview.SelectedItem.ToString();
            listview.Visibility = Visibility.Collapsed;
         

        }

       





    }
}
