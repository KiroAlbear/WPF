using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPF.Functions
{
    public class ListViewTransportation
    {
        List<string> FirstList;
        List<string> SecondtList;
        int SelectedIndex;
       public ListViewTransportation(List<string>FirstList, List<string>SecondList,int SelectedIndex)
        {
            this.FirstList = FirstList;
            this.SecondtList = SecondList;
            this.SelectedIndex = SelectedIndex;
        }
        public void Transport()
        {
            
            SecondtList.Add(FirstList[SelectedIndex]);

            FirstList.RemoveAt(SelectedIndex);

            ICollectionView view = CollectionViewSource.GetDefaultView(FirstList);
            view.Refresh();

            view = CollectionViewSource.GetDefaultView(SecondtList);
            view.Refresh();

        }
    }
}
