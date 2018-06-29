using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WPF.ComponentPages;

namespace WPF.classes
{
    public static class family_data_shared
    {
        public static family new_family_head;
        public static List<familydetail> new_family_member;
        public static DataGrid my_datagrid;
        public static void add_to_database ()
        {
            try
                {


                DatabaseFamilyDataContext dd = new DatabaseFamilyDataContext();
                dd.families.InsertOnSubmit(new_family_head);
                int x = dd.families.Where(o => o.familyname == new_family_head.familyname).Select(q => q.familycode).FirstOrDefault();
                foreach (familydetail fm in new_family_member)
                {
                    fm.familycodedetails = x;
                    dd.familydetails.InsertOnSubmit(fm);
                }
                dd.SubmitChanges();
                MessageBox.Show("Done");
            }
            catch(Exception s)
            {
                MessageBox.Show(s.ToString());
            }
            
        }
        
    }
}
