using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        [Key]
        public int CategoryId { get; set; }
        [StringLength(200)]
        public string CategoryName { get; set; }
        [StringLength(200)]
        public string CategoryDescription { get; set; }

        public bool CategoryStatus { get; set; } //İlişkili tablo, category'i duruma göre pasif yada aktif yapacağız.

        // İlişki => Category-Heading
        public ICollection<Heading> Headings { get; set; }
    }
}
