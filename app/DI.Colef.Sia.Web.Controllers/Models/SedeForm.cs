namespace DecisionesInteligentes.Colef.Sia.Web.Controllers.Models
{
    public class SedeForm
    {		
		public int Id { get; set; }
		public string Nombre { get; set; }
		public bool Activo { get; set; }
        public string Modificacion { get; set; }

        public int DireccionRegional { get; set; }
        public int DireccionRegionalId { get; set; }
        public string DireccionRegionalNombre { get; set; }

        public DireccionRegionalForm[] DireccionesRegionales { get; set; }
    }
}
