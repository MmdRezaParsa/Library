using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BusnessEntity;

namespace BLL
{
    public class blmember
    {

    }
    public class blemployee    
    {
        public bool emp_isin(employee emp1)
        {
            dlemployee emp2 = new dlemployee();
            if (emp2.emp_isin(emp1))
            {
                return true;
            }
            return false;
        }
        public bool change_pass(employee emp1, string national_code)
        {
            dlemployee dlemp1 = new dlemployee();
            bool is_change = dlemp1.change_pass(emp1, national_code);
            if (is_change)
            {
                return true;
            }
            return false;

        }
        public bool regester(employee emp1)
        {
            dlemployee dlemployee = new dlemployee();
            bool is_reg = dlemployee.regester(emp1);
            if (is_reg)
            {
                return true;
            }
            return false;
        }
    }
    public class blemployee_login
    {
        public bool login(employee_login emp1)
        {
            dlemployee_login dle = new dlemployee_login();
            bool emp_check = dle.login(emp1);
            if (emp_check)
            {
                return true;
            }
            return false;
        }
    }
    public class blremember_me
    {
        public void remember(remember_me rem1)
        {
            dlremember_me dlrem = new dlremember_me();
            dlrem.remember(rem1);
        }
        public void rem_del(string s1,string s2)
        {
            dlremember_me dlerem = new dlremember_me();
            dlerem.rem_del(s1,s2);
        }
        public remember_me read_rem()
        {
            dlremember_me dlrem = new dlremember_me();
            return dlrem.read_rem();
        }
    }

}