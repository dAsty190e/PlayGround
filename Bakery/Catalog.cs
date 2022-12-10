using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    public class Catalog
    {
        public string CompanyName { get; set; }
        public string Advertisement { get; set; }
        public DateTime PublishDate { get; set; }
        public List<string> Miscellaneous { get; set; }
        public List<CatalogItem> CatalogItems { get; set; }
    }
}
