﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IBookAdService : IGenericService<BookAd>
    {
        public BookAd GetBookAdByTitle(String title);
        public List<BookAd> GetBookAdBySearch(String search);
    }
}
