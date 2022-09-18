using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Types
{
    class Cat
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public string EyeColor { get; set; }
        public void Meow()
        {
            Console.WriteLine("Meow");
        }
    }
}
