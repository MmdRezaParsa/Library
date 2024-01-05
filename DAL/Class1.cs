using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusnessEntity;

namespace DAL
{
    public class dlmember
    {

    }
    public class dlemployee
    {
        
        public bool emp_isin(employee emp1)
        {
            db2 d2 = new db2();
            foreach (var item in d2.employees_list)
            {
                if (item.name == emp1.name && item.family == emp1.family && item.national_code == emp1.national_code && item.username == emp1.username)
                {
                    return true;               
                }
            }
            return false;
        }
        public bool change_pass(employee emp1, string national_code)
        {
            db2 d2 = new db2();
            var q = from i in d2.employees_list where (i.national_code == national_code) select i;
            if (q.Count() == 1)
            {
                employee emp2 = new employee();
                emp2 = q.Single();
                emp2.password = emp1.password;
                d2.SaveChanges();
                return true;
            }
            return false;
        }
        public bool regester(employee emp1)
        {
            db2 d2 = new db2();
            var q = from i in d2.employees_list where (i.national_code == emp1.national_code) select i;
            if (q.Count() == 0)
            {
                d2.employees_list.Add(emp1);
                d2.SaveChanges();
                return true;
            }
            return false;
        }
    }
    public class dlemployee_login
    {
        db2 d2 = new db2();
        public bool login(employee_login emp1)
        {
            foreach (var item in d2.employees_list)
            {
                if (item.username == emp1.username && item.password == emp1.password)
                {
                    return true;
                } 
            }
            return false;
        }
    }
    public class dlremember_me
    {
        public void remember(remember_me rem1)
        {
            db3 d3 = new db3();
            foreach (var item in d3.rem_list)
            {
                d3.rem_list.Remove(item);
            }
            d3.rem_list.Add(rem1);
            d3.SaveChanges();
        }
        public void rem_del(string s1,string s2)
        {
            db3 d3 = new db3();
            foreach (var item in d3.rem_list)
            {
                if (item.rem_user == s1 && item.rem_pass == s2)
                {
                    d3.rem_list.Remove(item);
                }
            }
            d3.SaveChanges();

        }
        public remember_me read_rem()
        {
            db3 d3 = new db3();
            foreach (var item in d3.rem_list)
            {
                return item;
            }
            remember_me remfake = new remember_me();
            return remfake;
        }
    }
}