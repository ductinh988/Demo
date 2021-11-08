using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace netCore.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [Display(Name ="ID")]
        public string ProductID { get; set; }
        [Display(Name ="tên")]

        public string ProductName { get; set; }
        public string UnitPrice{ get; set; }
        [Display(Name ="số lượng")]
        public string Quantity{ get; set; }
    }
}