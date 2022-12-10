using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014__Interfaces
{
    interface IFlyable
    {
        void Fly();
    }

    class Bird 
    {
        public string Name { get; set; }
        public string CanFly { get; set; }
    }

    class Plane : IFlyable
    {
        public void Fly() 
        {
            global::System.Console.WriteLine("HI");
        }
    }
}
