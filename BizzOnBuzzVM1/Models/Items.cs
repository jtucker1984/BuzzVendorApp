using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzOnBuzzVM1.Models
{
    class Items
    {
#nullable enable
        public required string Name { get; set; }

        public double Weight { get; set; }

        public double Price { get; set; }
        public string? Description { get; set; }

        public string? ImageUrl { get; set; }
    }
}
