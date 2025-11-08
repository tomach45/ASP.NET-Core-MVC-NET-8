using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBook.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Name_Ver7")]
        public string Name_Ver6 { get; set; }
        [Range(1, 100, ErrorMessage = "Display Order must be between 1-100")]
        [DisplayName("Order_Ver7")]
        public int DisplayOrder { get; set; }
    }
}
