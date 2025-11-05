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
        [DisplayName("Name_Ver4")]
        public string Name { get; set; }
        [Range(1, 100, ErrorMessage = "Display Order must be between 1-100")]
        [DisplayName("Order_Ver6")]
        public int DisplayOrder { get; set; }
    }
}
