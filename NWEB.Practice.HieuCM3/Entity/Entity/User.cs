using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Entity.Entity
{
    [Table("User")]
    public class User : EntityBase
    {
        public string FullName { get; set; }
        public string Password { get; set; }
        public bool Role { get; set; }
    }
}
