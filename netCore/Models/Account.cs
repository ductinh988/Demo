using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace netCore.Models {
    public class Account {
        [Key]
        public string AccountID {get; set;}
        public string AccountName { get; set; }
        public string CategoryID {get; set;}

       public Category Category {get; set;}

    }
}