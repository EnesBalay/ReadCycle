using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Message : Base
    {
        [Key]
        public int Id { get; set; }
        public string MessageText { get; set; }
        public int BookAdId { get; set; }
        public int UserId { get; set; }
        public bool MessageStatus { get; set; }
        public BookAd BookAd { get; set; }
        public User User { get; set; }
    }
}
