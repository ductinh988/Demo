using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace netCore.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [Display(Name ="ID")]
        public string  StudentID{ get; set; }
        [Display(Name ="Sinh viên")]
        public string StudentName { get; set; }
        [Display(Name ="địa chỉ")]
         public string Address { get; set; }
    }
}