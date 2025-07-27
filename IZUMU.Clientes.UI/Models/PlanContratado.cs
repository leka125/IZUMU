namespace IZUMU.Clientes.UI.Models
{
    public class PlanContratado
    {
        public int Id { get; set; }
        public required string Descripcion { get; set; }

        public static List<PlanContratado> ObtenerPlanesPredefinidos()
        {
            return new List<PlanContratado>
            {
                new PlanContratado { Id = 1, Descripcion = "Plan Básico" },
                new PlanContratado { Id = 2, Descripcion = "P.O.S" },
                new PlanContratado { Id = 3, Descripcion = "P.O.S.S" },
                new PlanContratado { Id = 4, Descripcion = "Sin Plan" }
            };
        }
    }
}