using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Makyr.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Category Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Category Name must be between 3 and 50 characters.")]
        public string Name { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "Display order must be within 1-100")]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
