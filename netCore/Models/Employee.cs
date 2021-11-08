using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace netCore.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public string  EmployeeID { get; set; }
        [Display(Name ="Nhân viên")]
        public string EmployeeName { get; set; }
        [Display(Name ="số điện thoại")]
         public string PhoneNumber { get; set; }
    }
}