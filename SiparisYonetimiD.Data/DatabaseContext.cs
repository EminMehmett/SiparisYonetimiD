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
/*
    Proje yaparken classları ve database context i kurduktan sonra veritabanını otomatik oluşturmak yerine migration la oluşturmamız gerekir.

    Migration u oluşturmak için  Visual studio da en üst menüden Tools > Nuget Pack... Manager > Package manage consol menüsünü akif ediyoruz. Aşağıya pac Alanını açıyoruz

    Sonra Default Project bölümünden database context imizin bulunduğu data katmanını seçiyoruz 

    Sonra aşağıdaki kod alanına enable-migrations yazıp enter a basarak Initialcreate class ının oluşturulmasını sağlıyoruz 

    Oluşan Confugration sınıfının içerisinde başlangıç verisi oluşturabileceğimiz Seed metodu oluşuyor bunu kullanarak veritabanı oluştuktan sonra örnek data oluşturabiliriz.

    Eğer enable-migrations tan sonra initialcreate class ı oluşmazsa P.M.C komut ekranına add_migration InitialCreate yazıp enter a basarak kendimiz oluşturabiliriz. 
 */