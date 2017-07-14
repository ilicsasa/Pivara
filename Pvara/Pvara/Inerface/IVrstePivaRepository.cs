using Pvara.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pvara.Inerface
{
    interface IVrstePivaRepository
    {
        IQueryable<VrstePiva> GetAll();

        VrstePiva GetById(int id);
        void Create(VrstePiva vrstePiva);
        void Edit(VrstePiva vrstePiva);
        void Delete(VrstePiva vrstePiva);
    }
}
