using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.classes
{
    class familydetails
    {
        public int familycodedetails { set; get; }
        public string paxname { set; get; }
        public string relativity { set; get; }
        public string birthdate { set; get; }
        public string birthplace { set; get; }
        public string mamodia { set; get; }
        public int confesspriestcode { set; get; }
        public string moahel { set; get; }
        public string job { set; get; }
        public string maritalstatus { set; get; }
        public int maritalstatuscode { set; get; }
        public int socialnumber { set; get; }
        public string healthstatus { set; get; }
        public string electionnumber { set; get; }
        public DateTime birthdt { set; get; }
        public string mobile { set; get; }
        public string email { set; get; }
        public string paxaddress { set; get; }
        public string comments { set; get; }
        public int movedfl { set; get; }
        public int khedmacode { set; get; }
        public int shmosiacode { set; get; }
        public int mamodiacode { set; get; }
        public int housetypecode { set; get; }
        public int churchcode { set; get; }
        public familydetails( int _familycodedetails, string _paxname, string _relativity, string _birthdate, string _mamodia, int _confesspriestcode, string __moahel,
            string _job, string _maritalstatus, int _socialnumber, string _healthstatus, string _electionnumber, DateTime _birthdt,
            string _mobile, string _email, string _paxaddress, int _khedmacode, int _shmosiacode, int _mamodiacode, int _housetypecode, int _churchcode)
        {
            
        }
    }
}
