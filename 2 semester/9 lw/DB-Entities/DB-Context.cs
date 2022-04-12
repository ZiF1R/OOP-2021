using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9lw.DB_Entities
{
    public class DBContext : DbContext
    {
        public DBContext() : base("DefaultConnection") { }
        public DbSet<Account> accounts { get; set; }
        public DbSet<AccountOwner> accountOwners { get; set; }
    }
}
