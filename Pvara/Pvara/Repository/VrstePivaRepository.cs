using Pvara.Inerface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pvara.Models;
using System.Data.Entity;

namespace Pvara.Repository
{
    public class VrstePivaRepository : IVrstePivaRepository, IDisposable
    {
        private ApplicationDbContext db = new ApplicationDbContext();

       
        public IQueryable<VrstePiva> GetAll()
        {
            return db.VrstePivas;
        }

        public VrstePiva GetById(int id)
        {
            return db.VrstePivas.Find(id);
        }

        public void Create(VrstePiva vrstePiva)
        {
            db.VrstePivas.Add(vrstePiva);
            db.SaveChanges();
        }

        public void Edit(VrstePiva vrstePiva)
        {
            db.Entry(vrstePiva).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(VrstePiva vrstePiva)
        {
            db.VrstePivas.Remove(vrstePiva);
            db.SaveChanges();
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