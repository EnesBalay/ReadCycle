using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BookAd : Base
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public bool BookAdStatus { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }
        public string Images { get; set; }
    }
}
