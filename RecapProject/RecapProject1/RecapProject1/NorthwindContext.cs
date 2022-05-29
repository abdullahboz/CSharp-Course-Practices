using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RecapProject1.Entities;

namespace RecapProject1
{
    // Mapping yapmadığımız için
    // benim elimde bir Product var ve o Product veritabanında Products'a karşılık gelir,
    // ben onu direk tablo gibi Products diye ismiyle kullanacağım.
    public class NorthwindContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
