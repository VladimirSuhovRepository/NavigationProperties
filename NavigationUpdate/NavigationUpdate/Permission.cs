using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationUpdate
{
    public class Permission
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int UsergroupId { get; set; }
        public virtual Usergroup Usergroup { get; set; }

    }
}
