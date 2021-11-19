// using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace netCore.Models
{
    [Table("People")]
    public class Person
    {
        [Key]
        [Display(Name ="ID")]
        public int PersonID { get; set; }
        [Display(Name ="tên")]

        public string Fullname { get; set; }
       
    }
}