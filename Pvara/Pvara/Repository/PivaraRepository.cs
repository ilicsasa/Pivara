using Pvara.Inerface;
using Pvara.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pvara.Repository
{
    public class PivaraRepository : IPivaraRepository , IDisposable
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        
        public IQueryable<Pivara> GetAll()
        {
            throw new NotImplementedException();
        }

        public Pivara GetById(int id)
        {
            throw new NotImplementedException();
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