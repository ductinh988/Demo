using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace netCore.Models
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "không được để trống")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "tối thiểu có 3 ký tự")]
        // ErrorMessage = "không được để trống"
        public string Title { get; set; }
        [Required(ErrorMessage = "không được để trống")]
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Required(ErrorMessage = "không được để trống")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(30)]
        public string Genre { get; set; }
        [Range(1, 100)]
        [Required(ErrorMessage = "không được để trống")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "không được để trống")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$", ErrorMessage = "không được để trống")]
        [StringLength(5)]
        public string Rating { get; set; }
    }
}