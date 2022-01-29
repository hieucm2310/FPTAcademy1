using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entity
{
    [Table("Flower")]
    public class Flower : EntityBase
    {
        [ForeignKey("CategoryID")]
        public Category Category { get; set; }
        [Required(ErrorMessage ="Tên hoa không được bỏ trống!")]
        [StringLength(255)]
        public string FlowerName { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public byte[] Image { get; set; }
        [Required(ErrorMessage = "Giá bán không được bỏ trống!")]
        public decimal Price { get; set; }
        public decimal? SalePrice { get; set; }
        public DateTime StoreDate { get; set; }
        public int StoreInventory { get; set; }
    }
}
