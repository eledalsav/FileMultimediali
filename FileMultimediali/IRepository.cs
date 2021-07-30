using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali
{
    interface IRepository<T>
    {
        public List<T> Fetch();
    }
}
