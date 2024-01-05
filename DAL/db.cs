using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusnessEntity;
using System.Data.Entity;

namespace DAL
{
    public class db1 : DbContext
    {
        public db1() : base("name=constr1") { }
        public DbSet<member> members_list { get; set; }
    }
    public class db2 : DbContext
    {
        public db2() : base("name=constr1") { }
        public DbSet<employee> employees_list { get; set; }
    }
    public class db3 : DbContext
    {
        public db3() : base("name=constr1") { }
        public DbSet<remember_me> rem_list { get; set; }
    }
}
