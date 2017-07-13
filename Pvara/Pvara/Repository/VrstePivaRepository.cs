using Pvara.Inerface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pvara.Models;

namespace Pvara.Repository
{
    public class VrstePivaRepository : IVrstePivaRepository, IDisposable
    {
        private ApplicationDbContext db = new ApplicationDbContext();

       
        public IQueryable<VrstePiva> GetAll()
        {
            return db.VrstePivas;
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (db != null)
                {
                    db.Dispose();
                    db = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}