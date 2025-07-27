using System;
using System.ComponentModel.DataAnnotations;

namespace IZUMU.Clientes.UI.Models
{
    public class FechaNoMayorActualAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is DateTime fecha)
            {
                if (fecha > DateTime.Today)
                {
                    return new ValidationResult("La fecha de nacimiento no puede ser mayor a la fecha actual.");
                }
            }
            return ValidationResult.Success;
        }
    }

    public class DatosPersonales
    {
        public int IdInformacionPersonal { get; set; }
        public required string IdTipoDeDocumento { get; set; }
        public required string NumeroDeDocumento { get; set; }
        [DataType(DataType.Date)]
        [FechaNoMayorActual]
        public DateTime FechaDeNacimiento { get; set; }
        public required string PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        public required string PrimerApellido { get; set; }
        public required string SegundoApellido { get; set; }
        public required string DireccionDeResidencia { get; set; }
        public required string NúmeroDeCelular { get; set; }
        [EmailAddress(ErrorMessage = "El email no tiene un formato válido")]
        public required string Email { get; set; }
        public required int PlanContratado { get; set; }
    }
}