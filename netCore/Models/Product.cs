using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace netCore.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public string ProductID { get; set; }

        public string ProductName { get; set; }
        public string UnitPrice{ get; set; }
        public string Quantity{ get; set; }
    }
}