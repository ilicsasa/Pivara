using Pvara.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pvara.Inerface
{
    interface IPivoRepository
    {
        IQueryable<Pivo> GetAll();
        Pivo GetById(int id);
        void Create(Pivo pivo);
        void Edit(Pivo pivo);
        void Delete(Pivo pivo);
    }
}
