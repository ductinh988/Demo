using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace netCore.Models {
    public class Product {
        [Key]
        public string ProductID {get; set;}
        public string ProductName { get; set; }
        public string CategoryID {get; set;}

        public Category Category {get; set;}

    }
}