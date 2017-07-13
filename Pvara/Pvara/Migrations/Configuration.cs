namespace Pvara.Migrations
{
    using Pvara.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Pvara.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Pvara.Models.ApplicationDbContext context)
        {
            context.Pivaras.AddOrUpdate(
                b => b.Id,
                new Pivara { Id = 1, Naziv = "Apatinska pivara", PIB = "1565489", Drzava="Srbija" },
                new Pivara { Id = 2, Naziv = "Calsberg", PIB = "15165489", Drzava = "Srbija" },
                new Pivara { Id = 3, Naziv = "Heiniken", PIB = "15615465", Drzava = "Srbija" }
                );

            context.VrstePivas.AddOrUpdate(
                b => b.Id,
                new VrstePiva { Id = 1, Naziv = "Svetlo" },
                new VrstePiva { Id = 2, Naziv = "Tamno" },
                new VrstePiva { Id = 3, Naziv = "Jeèmeno" }
                );

            context.Pivos.AddOrUpdate(
                a => a.Id,
                   new Pivo { Id = 1, Naziv = "Jelen", ProcenatAlkohola = 5, IBU = 25, Cena = 75, Kolicina = 5,  DatumProizvodnje = new DateTime(2017, 3, 8, 16, 5, 7, 123), PivaraId = 1, VrstePivaId = 2 },
                   new Pivo { Id = 2, Naziv = "Lav", ProcenatAlkohola = 5, IBU = 25, Cena = 77, Kolicina = 10, DatumProizvodnje = new DateTime(2017, 5, 9, 16, 5, 7, 123), PivaraId = 2, VrstePivaId = 1 },
                   new Pivo { Id = 3, Naziv = "Zajecarsko", ProcenatAlkohola = 5, IBU = 25, Cena = 71, Kolicina = 7, DatumProizvodnje = new DateTime(2016, 3, 11, 16, 5, 7, 123), PivaraId = 3, VrstePivaId = 3 }
                   );

        }
    }
}
