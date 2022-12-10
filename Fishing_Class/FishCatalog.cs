using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Class
{
    internal class FishCatalog : Fish
    {
        public FishCatalog() 
        {
            FishCatalogs = new List<Fish>
            {
                new Fish{
                    Name = "Crayfish",
                    Type = "Seafood",
                    Place = "Central Shroud",
                    Size = 2,
                    Weight = 5,
                    ActiveDateStart = new DateOnly(DateTime.Now.Year, 01,01),
                    ActiveDateEnd = new DateOnly(DateTime.Now.Year, 02,02),
                    ActveTime = new TimeSpan(25,65,45)
                }

            };


        }
    }
}
