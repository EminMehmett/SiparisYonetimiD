using System;
using System.Data.Entity.Migrations;
using System.Linq;


namespace SiparisYonetimiD.Data.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<SiparisYonetimiD.Data.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; // otomatik migration özelliğini aç
            AutomaticMigrationDataLossAllowed = true; // migration işlemlerinde data kayıplarına izin ver 
        }

        protected override void Seed(SiparisYonetimiD.Data.DatabaseContext context)
        {
            // Bu metot veritabanı oluşturduktan sonra çalışır ve tablolara örnek kayıt ekleyebilmemizi sağlar
            if (context.Users.Any()) // Eğer veritabanında hiç kayıt yoksa 
            {
                context.Users.Add(new Entities.User // yeni bir kullanıcı oluştur ve context e ekle 
                {
                    CreateDate = DateTime.Now,
                    Email = "amdin@SiparisYonetimi.net",
                    Id = 1,
                    IsActive = true,
                    IsAdmin = true,
                    Name = "Admin",
                    Username = "Admin",
                    Password = "123"
                });
                context.SaveChanges(); // Değişiklikleri veritabanına işle 
            }
        }
    }
}
