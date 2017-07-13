using Pvara.Inerface;
using Pvara.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Pvara.Repository
{
    public class PivoRepository : IPivoRepository, IDisposable
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        public IQueryable<Pivo> GetAll()
        {
            return db.Pivos;
        }

        public Pivo GetById(int id)
        {
            return db.Pivos.Find(id);
        }

        public void Create(Pivo pivo)
        {
            db.Pivos.Add(pivo);
            db.SaveChanges();
        }

        public void Edit(Pivo pivo)
        {
            db.Entry(pivo).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(Pivo pivo)
        {
            db.Pivos.Remove(pivo);
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