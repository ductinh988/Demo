using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace netCore.Models {
    public class Product {
        [Key]
        [Required(ErrorMessage = "không được để trống")]
        public string ProductID {get; set;}
        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "không được để trống")]
         [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$",ErrorMessage = "phải viết hoa ký tự đầu tiên")]
        public string ProductName { get; set; }
        
        public string CategoryID {get; set;}
        

        public Category Category {get; set;}

    }
}