using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Content
    {
        [Key]
        public int ContentID { get; set; }
        [StringLength(1000)]
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }

        // We need author and heading but these are related to relationships. We will implement them later.

        // İlişki => Heading-Content
        public int HeadingId { get; set; }
        public virtual Heading Heading { get; set; }

        // Content <=> Writer
        public int? WriterId { get; set; } // Nullable Type
        public virtual Writer Writer { get; set; }
    }
}
