using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makyr.Utility
{
    public static class StaticDetails
    {
        public enum GPUMemoryType
        {
            GDDR6,
            GDDR5,
            HBM2,
            HBM,
            DDR5,
            GDDR3,
            DDR3,
            GDDR4
        }

        public static List<int> GPUMemorySizes { get; } = new List<int> { 1, 2, 4, 6, 8, 12, 16, 24, 32 };


        public static List<int> GPUBusTypes { get; } = new List<int> { 32, 64, 128, 256, 384, 512 };

        public static List<string> GPUConditions { get; } = new List<string> { "New", "Used" };
    }
}
