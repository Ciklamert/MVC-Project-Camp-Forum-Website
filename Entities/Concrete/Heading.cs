using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Heading :IEntity// diğer classlardan erişim sağlamak için public yapıyorum
    {
        // property = attribute,column
        [Key] // bütün primary keyleri key olarak annotate et
        public int HeadingId { get; set; }
        [StringLength(50)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }

        //İlişki => Heading-Category => N to 1 relationship
        public int CategoryId { get; set; } // diğer tablonun primary key'sini bu tabloya koydum.
        public virtual Category Category { get; set; } // Category table'ından category değerini alacaksın.

        public ICollection<Content> Contents { get; set; } // Heading-Content ,veritabanında varchar olarak depolanacak

        // Writer <=> Heading
        public int WriterId { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
