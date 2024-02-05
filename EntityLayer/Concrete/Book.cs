using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Book : Base
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime PublishedDate { get; set; }
        public int Edition { get; set; }
        public DateTime EditionDate { get; set; }
        public bool BookStatus { get; set; }
        public Writer Writer { get; set; }
        public Publisher Publisher { get; set; }
        public Category Category { get; set; }
    }
}
