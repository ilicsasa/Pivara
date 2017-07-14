using Pvara.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pvara.Inerface
{
    interface IPivaraRepository
    {
        IQueryable<Pivara> GetAll();
        Pivara GetById(int id);
        
        void Create(Pivara pivara);
        void Edit(Pivara pivara);
        void Delete(Pivara pivara);
        
    }
}
