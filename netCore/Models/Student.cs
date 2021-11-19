
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace netCore.Models
{
    [Table("Student")]
    public class Student : Person
    {
        [Display(Name ="ID")]
        public int  StudentID{ get; set; }
        
        public string University { get; set; }
        
    }
}