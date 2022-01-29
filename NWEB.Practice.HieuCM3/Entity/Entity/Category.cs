using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entity
{
    [Table("Category")]
    public class Category : EntityBase
    {
        [Required(ErrorMessage ="Tên loại không được bỏ trống!")]
        [MaxLength(100)]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "Order không được bỏ trống!")]
        [DefaultValue(1)]
        public int Oder{ get; set; }
        public string Text { get; set; }
        public ICollection<Flower> Flowers { get; set; }
    }
}
