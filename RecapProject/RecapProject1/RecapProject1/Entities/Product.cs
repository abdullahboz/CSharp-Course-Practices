using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapProject1.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        //Primary Key
        public int CategoryId { get; set; }
        //ardından foreign key geliyor.
        public string ProductName { get; set; }
        //ardından diğer kategorileri tanımlıyoruz. 
        public decimal UnitPrice { get; set; }
        // sıralamanın DB ile aynı olmasına dikkat ediyoruz.
        public Int16 UnitsInStock { get; set; }
        public string QuantityPerUnit { get; set; }
        
    }
}
