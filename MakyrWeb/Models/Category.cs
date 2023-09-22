using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MakyrWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Category Name")]
        [Range(3, 50)]
        public string Name { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "Display order must be within 1-100")]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
