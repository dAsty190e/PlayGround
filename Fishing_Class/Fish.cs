using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Class
{
    internal class Fish 
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Place { get; set; }
        public int Size { get; set; }
        public int Weight { get; set; }
        public List<Fish> FishCatalogs { get; set; }
        public TimeSpan ActveTime { get; set; }
        public DateOnly ActiveDateStart { get; set; } 
        public DateOnly ActiveDateEnd { get; set; }

    }

}
