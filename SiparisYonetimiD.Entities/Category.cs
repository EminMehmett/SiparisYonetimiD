using System;
using System.Collections.Generic;

namespace SiparisYonetimiD.Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreateDate { get; set; } = DateTime.Now;
        public virtual List<Product> Products { get; set; } // Kategori ile Product arasında ilişki kurduk. 1 Kategoriye ait birden fazla product olabileceği için List ile bire çok ilişki kurduk.
        public Category()
        {
            Products = new List<Product>(); 
        }

    }
}
