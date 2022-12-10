using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    public class TestCatalog : Catalog
    {
        public TestCatalog() 
        {
            CompanyName = "TestCompany";
            Advertisement = "TestAdvertisement";
            PublishDate = DateTime.Now;
            Miscellaneous = new List<string> { "Misc1", "Misc2" };
            CatalogItems = new List<CatalogItem> 
            {
                new CatalogItem { 
                    Description = "CI1",
                    Price = 10.00m,
                    Quantity = 20,
                    Title = "Test Cupcake",
                    Id = 1
                },
                new CatalogItem {
                    Description = "CI2",
                    Price = 25.00m,
                    Quantity = 5,
                    Title = "Test Cake",
                    Id = 2
                },
                new CatalogItem {
                    Description = "CI3",
                    Price = 2.50m,
                    Quantity = 50,
                    Title = "Test Bagel",
                    Id = 3
                },
                new CatalogItem {
                    Description = "CI4",
                    Price = 3.50m,
                    Quantity = 50,
                    Title = "Pumpkin Bagel",
                    Id = 4 
                }
            };
        }
    }
}
