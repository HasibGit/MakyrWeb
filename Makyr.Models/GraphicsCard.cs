using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makyr.Models
{
    public class GraphicsCard
    {
        [Key]
        public Guid Id { get; set; }

        // Key Features
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Brand name must be between 3 and 50 characters.")]
        public string Brand { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Model name must be between 3 and 50 characters.")]
        public string Model { get; set; }
        [Required]
        [Display(Name="Product Code")]
        [StringLength(6, MinimumLength = 3, ErrorMessage = "Product code must be between 3 and 6 characters.")]
        public string ProductCode { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Character limit is 3 to 10 characters")]
        public string Status { get; set; }
        [Required]
        [Range(30, 30000, ErrorMessage = "Price must be between $30 and $30,000")]
        public double Price { get; set; } // in dollers

        // Video Memory Specifications
        public string MemoryType { get; set; } // GDDR 5 / 6..
        [Range(1, int.MaxValue, ErrorMessage = "Memory size must be at least 1")]
        public int MemorySize { get; set; } // 2Gb, 4Gb, 6Gb, 8Gb
        [Range(1, int.MaxValue, ErrorMessage = "Clock speed must be at least 1")]
        public int BaseClock { get; set; } // in Mhz
        [Range(1, int.MaxValue, ErrorMessage = "Clock speed must be at least 1")]
        public int BoostClock { get; set; } // in Mhz
        [Range(1, int.MaxValue, ErrorMessage = "Memory clock speed must be at least 1")]
        public int MemoryClockSpeed { get; set; } // in Gbps
        public int BusType { get; set; } // in bit
        public int CudaCores { get; set; }

        // Interface specs
        public string DisplayPort { get; set; }
        public string HdmiPort { get; set; }

        // Power Specs
        public string Connectors { get; set; }
        public int RecommendedPsu { get; set; } // in Watt

        // Graphics api support
        public string Directx { get; set; }
        public string OpenGL { get; set; }

        // Physical Spec
        [Range(0, int.MaxValue, ErrorMessage = "Width cannot be negative number")]
        public double Width { get; set; } // in mm
        [Range(0, int.MaxValue, ErrorMessage = "Height cannot be negative number")]
        public double Height { get; set; } // in mm
        [Range(0, int.MaxValue, ErrorMessage = "Depth cannot be negative number")]
        public double Depth { get; set; } // in mm

        // Condition
        public string Condition { get; set; } // new or used

        // Warrenty
        [Range(0, int.MaxValue, ErrorMessage = "Manufacturing warranty must be a positive number")]
        public int ManufacturingWarrenty { get; set; } // warrenty in months
        [Range(0, int.MaxValue, ErrorMessage = "Service warranty must be a positive number")]
        public int ServiceWarrenty { get; set; } // for used gpu
    }
}
