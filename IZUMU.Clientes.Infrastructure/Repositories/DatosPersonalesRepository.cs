using System.Collections.Generic;
using IZUMU.Clientes.Infrastructure.Entities;

namespace IZUMU.Clientes.Infrastructure.Repositories
{
public class DatosPersonalesRepository : IRepository<DatosPersonalesEntity>
    {
        private readonly DatosPersonalesDbContext _context;

        public DatosPersonalesRepository(DatosPersonalesDbContext context)
        {
            _context = context;
        }

        public IEnumerable<DatosPersonalesEntity> GetAll()
        {
            return _context.DatosPersonales
                .Select(MapToEntity)
                .ToList();
        }

        public DatosPersonalesEntity? GetById(int id)
        {
            var x = _context.DatosPersonales.Find(id);
            return x != null ? MapToEntity(x) : null;
        }

        public void Add(DatosPersonalesEntity entity)
        {
            _context.DatosPersonales.Add(entity);
            _context.SaveChanges();
        }

        public void Update(DatosPersonalesEntity entity)
        {
            var model = _context.DatosPersonales.Find(entity.IdInformacionPersonal);
            if (model != null)
            {
                model.IdTipoDeDocumento = entity.IdTipoDeDocumento;
                model.NumeroDeDocumento = entity.NumeroDeDocumento;
                model.FechaDeNacimiento = entity.FechaDeNacimiento;
                model.PrimerNombre = entity.PrimerNombre;
                model.SegundoNombre = entity.SegundoNombre;
                model.PrimerApellido = entity.PrimerApellido;
                model.SegundoApellido = entity.SegundoApellido;
                model.DireccionDeResidencia = entity.DireccionDeResidencia;
                model.NúmeroDeCelular = entity.NúmeroDeCelular;
                model.Email = entity.Email;
                model.PlanContratado = entity.PlanContratado;
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var entity = _context.DatosPersonales.Find(id);
            if (entity != null)
            {
                _context.DatosPersonales.Remove(entity);
                _context.SaveChanges();
            }
        }
    // Método privado para mapear de la entidad de EF a la entidad de dominio
    private static DatosPersonalesEntity MapToEntity(DatosPersonalesEntity x)
    {
        return new DatosPersonalesEntity
        {
            IdInformacionPersonal = x.IdInformacionPersonal,
            IdTipoDeDocumento = x.IdTipoDeDocumento,
            NumeroDeDocumento = x.NumeroDeDocumento,
            FechaDeNacimiento = x.FechaDeNacimiento,
            PrimerNombre = x.PrimerNombre,
            SegundoNombre = x.SegundoNombre,
            PrimerApellido = x.PrimerApellido,
            SegundoApellido = x.SegundoApellido,
            DireccionDeResidencia = x.DireccionDeResidencia,
            NúmeroDeCelular = x.NúmeroDeCelular,
            Email = x.Email,
            PlanContratado = x.PlanContratado
        };
    }
    }
}
