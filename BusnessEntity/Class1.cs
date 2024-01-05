using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusnessEntity
{
    public class member
    {
        public int id { get; set; }
        public string name { get; set; }
        public string family { get; set; }
        public int national_code { get; set; }
        public bool gender { get; set; }
        public bool member_check { get; set; }  
    }
    public class employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string family { get; set; }
        public string national_code { get; set; }
        public bool gender { get; set; }
        public string username { get; set;}
        public string password { get; set;}
        

    }
    public class employee_login
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }

    }
    public class remember_me
    {
        public int id { get; set; }
        public string rem_user { get; set; }
        public string rem_pass { get; set; }
    }

}