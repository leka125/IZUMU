using IZUMU.Clientes.UI.Models;
using IZUMU.Clientes.Infrastructure.Entities;

namespace IZUMU.Clientes.UI.Mapper
{
    public static class DatosPersonalesMapper
    {
        public static DatosPersonalesEntity ToDto(DatosPersonales model)
        {
            return new DatosPersonalesEntity
            {
                IdInformacionPersonal = model.IdInformacionPersonal,
                IdTipoDeDocumento = model.IdTipoDeDocumento,
                NumeroDeDocumento = model.NumeroDeDocumento,
                FechaDeNacimiento = model.FechaDeNacimiento,
                PrimerNombre = model.PrimerNombre,
                SegundoNombre = model.SegundoNombre,
                PrimerApellido = model.PrimerApellido,
                SegundoApellido = model.SegundoApellido,
                DireccionDeResidencia = model.DireccionDeResidencia,
                NúmeroDeCelular = model.NúmeroDeCelular,
                Email = model.Email,
                PlanContratado = model.PlanContratado
            };
        }

        public static DatosPersonales ToModel(DatosPersonalesEntity entity)
        {
            return new DatosPersonales
            {
                IdInformacionPersonal = entity.IdInformacionPersonal,
                IdTipoDeDocumento = entity.IdTipoDeDocumento,
                NumeroDeDocumento = entity.NumeroDeDocumento,
                FechaDeNacimiento = entity.FechaDeNacimiento,
                PrimerNombre = entity.PrimerNombre,
                SegundoNombre = entity.SegundoNombre,
                PrimerApellido = entity.PrimerApellido,
                SegundoApellido = entity.SegundoApellido,
                DireccionDeResidencia = entity.DireccionDeResidencia,
                NúmeroDeCelular = entity.NúmeroDeCelular,
                Email = entity.Email,
                PlanContratado = entity.PlanContratado
            };
        }
    }
}
