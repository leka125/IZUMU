using System;
using System.Linq;
using Xunit;
using IZUMU.Clientes.Infrastructure.Entities;
using IZUMU.Clientes.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace IZUMU.Clientes.Tests.Services
{
    public class DatosPersonalesRepositoryTests
    {
        private DatosPersonalesRepository GetRepositoryWithContext()
        {
            var options = new DbContextOptionsBuilder<IZUMU.Clientes.Infrastructure.DatosPersonalesDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            var context = new IZUMU.Clientes.Infrastructure.DatosPersonalesDbContext(options);
            return new DatosPersonalesRepository(context);
        }

        [Fact]
        public void Add_And_GetAll_ShouldPersistEntity()
        {
            var repo = GetRepositoryWithContext();
            var entity = new DatosPersonalesEntity
            {
                IdTipoDeDocumento = "CC",
                NumeroDeDocumento = "12345678",
                FechaDeNacimiento = DateTime.Today.AddYears(-30),
                PrimerNombre = "Juan",
                SegundoNombre = "Carlos",
                PrimerApellido = "Pérez",
                SegundoApellido = "Gómez",
                DireccionDeResidencia = "Calle Falsa 123",
                NúmeroDeCelular = "3001234567",
                Email = "juan@example.com",
                PlanContratado = 1
            };
            repo.Add(entity);
            var all = repo.GetAll();
            Assert.Single(all);
            Assert.Equal("12345678", all.First().NumeroDeDocumento);
        }

        [Fact]
        public void Update_ShouldModifyEntity()
        {
            var repo = GetRepositoryWithContext();
            var entity = new DatosPersonalesEntity
            {
                IdTipoDeDocumento = "CC",
                NumeroDeDocumento = "12345678",
                FechaDeNacimiento = DateTime.Today.AddYears(-30),
                PrimerNombre = "Juan",
                SegundoNombre = "Carlos",
                PrimerApellido = "Pérez",
                SegundoApellido = "Gómez",
                DireccionDeResidencia = "Calle Falsa 123",
                NúmeroDeCelular = "3001234567",
                Email = "juan@example.com",
                PlanContratado = 1
            };
            repo.Add(entity);
            var added = repo.GetAll().Where(x => x.NumeroDeDocumento == "12345678").FirstOrDefault();
            added.PrimerNombre = "Pedro";
            repo.Update(added);
            var updated = repo.GetAll().First();
            Assert.Equal("Pedro", updated.PrimerNombre);
        }

        [Fact]
        public void Delete_ShouldRemoveEntity()
        {
            var repo = GetRepositoryWithContext();
            var entity = new DatosPersonalesEntity
            {
                IdTipoDeDocumento = "CC",
                NumeroDeDocumento = "12345678",
                FechaDeNacimiento = DateTime.Today.AddYears(-30),
                PrimerNombre = "Juan",
                SegundoNombre = "Carlos",
                PrimerApellido = "Pérez",
                SegundoApellido = "Gómez",
                DireccionDeResidencia = "Calle Falsa 123",
                NúmeroDeCelular = "3001234567",
                Email = "juan@example.com",
                PlanContratado = 1
            };
            repo.Add(entity);
            var added = repo.GetAll().First();
            repo.Delete(added.IdInformacionPersonal);
            var all = repo.GetAll();
            Assert.Empty(all);
        }
    }
}
