using Entities.Concrete; // Eğer bir başka katmanın metodunu, property'sini kullanıyorsan o katmanı using ile eklemelisin.
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class Context : DbContext // SQL'deki tablo isimlerini temsil ediyor. İki nokta Entity Frameworkte bulunan DbContext'i kullanacağını belirtir. Extends gibi çalışır.
    {

        public Context() : base("DbMvcKamp")
        {

        }
        public DbSet<About> Abouts { get; set; } // tablo isimleri s takısı ile olur.
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
