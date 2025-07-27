using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IZUMU.Clientes.Infrastructure.Entities
{
    [Table("DatosPersonales")]
    public class DatosPersonalesEntity
    {
        [Key]
        public int IdInformacionPersonal { get; set; }
        public string IdTipoDeDocumento { get; set; } = string.Empty;
        public string NumeroDeDocumento { get; set; } = string.Empty;
        public DateTime FechaDeNacimiento { get; set; }
        public string PrimerNombre { get; set; } = string.Empty;
        public string? SegundoNombre { get; set; }
        public string PrimerApellido { get; set; } = string.Empty;
        public string SegundoApellido { get; set; } = string.Empty;
        public string DireccionDeResidencia { get; set; } = string.Empty;
        public string NúmeroDeCelular { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int PlanContratado { get; set; }
    }
}
