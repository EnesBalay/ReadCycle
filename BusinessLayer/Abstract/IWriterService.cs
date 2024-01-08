using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    internal interface IWriterService : IGenericService<Writer>
    {
        public Writer GetWriterByName(String name);
        public List<Writer> GetWriterBySearch(String search);
    }
}
