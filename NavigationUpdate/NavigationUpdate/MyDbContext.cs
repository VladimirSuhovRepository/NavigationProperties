using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationUpdate
{
    public class MyDbContext:DbContext
    {
        public virtual DbSet<Usergroup> Usergroups { get; set; }

        public virtual DbSet<Permission> Permissions { get; set; }
    }
}
