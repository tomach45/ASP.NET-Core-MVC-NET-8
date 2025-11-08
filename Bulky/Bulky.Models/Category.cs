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
        [DisplayName("Name_Ver6")]
        public string Name_Ver7 { get; set; }
        [Range(1, 100, ErrorMessage = "Display Order must be between 1-100")]
        [DisplayName("Order_Ver6")]
        public int DisplayOrder { get; set; }

        public void Genpon()
        {
            string genpon = string.Empty;
            Name_Ver7 = genpon;
        }

        public void ver1()
        {
            string ver1 = string.Empty;
            Name_Ver7 = ver1;
        }

        public void ver2()
        {
            string ver2 = string.Empty;
            Name_Ver7 = ver2;
        }
    }
}
