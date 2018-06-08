using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPF.Functions
{
     
    public class DataGridAccess
    {
        DataGrid datagrid;
        public DataGridAccess(DataGrid datagrid)
        {
            this.datagrid = datagrid;
        }

        public List<string> RowItemsText(int rownumber)
        {
            List<string> temp= new List<string>();
            //DataGridRow row = (DataGridRow)datagrid.ItemContainerGenerator.ContainerFromIndex(rownumber);
            //DataGridCell TXTGROUPID = datagrid.Columns[2].GetCellContent(row).Parent as DataGridCell;
            //string str = ((TextBlock)TXTGROUPID.Content).Text;

    
            return temp;
        }
        public string ItemText()
        {
            string itemtext = "";
            return itemtext;
        }
    }
}
