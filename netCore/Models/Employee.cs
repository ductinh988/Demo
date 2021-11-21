using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace netCore.Models
{
    [Table("Employee")]
    public class Employee : Movie
    {
       
        public int  EmployeeID{ get; set; }
        
        public string University { get; set; }
        
    }
}