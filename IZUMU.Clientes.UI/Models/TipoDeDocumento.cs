public class TipoDeDocumento
{
    public required string Id { get; set; }
    public required string Descripcion { get; set; }

    public static List<TipoDeDocumento> ObtenerTiposPredefinidos()
    {
        return new List<TipoDeDocumento>
        {
            new TipoDeDocumento { Id = "RC", Descripcion = "Registro Civil" },
            new TipoDeDocumento { Id = "TI", Descripcion = "Tarjeta de Identidad" },
            new TipoDeDocumento { Id = "CC", Descripcion = "Cédula de Ciudadanía" },
            new TipoDeDocumento { Id = "DIE", Descripcion = "Documento de Identificación Extranjero" }
        };
    }
}