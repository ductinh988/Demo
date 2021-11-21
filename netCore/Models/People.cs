using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace netCore.Models {
    public class People {
        [Key]
        public string PeopleID {get; set;}
        public string PeopleName { get; set; }

    }
}