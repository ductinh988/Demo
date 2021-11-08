using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace netCore.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        [Display (Name ="ID")]
        public string  PersonID{ get; set; }
        [Display (Name ="tên")]
        public string PersonName { get; set; }
    }
}