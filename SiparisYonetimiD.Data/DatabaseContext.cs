using SiparisYonetimiD.Entities;
using System.Data.Entity; // Bu kütüphane Entity Framework paketinden geliyor. Onu yüklemeseydik buna erişemezdik 

namespace SiparisYonetimiD.Data
{
    public class DatabaseContext : DbContext // Burada Entity Frameworkün DbContext sınıfndan miras alıyoruz DatabaseContext sınıfından dbcontextleri kullanabilmek için 
    {
        public DatabaseContext()
        {

        }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
