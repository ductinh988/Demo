using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace netCore.Models {
    public class Category {
        [Key]
        public string CategoryID {get; set;}
        public string CategoryName { get; set; }

        public ICollection<Product> Products {get; set;}

         public ICollection<Account> Accounts {get; set;}

    }
}