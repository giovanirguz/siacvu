using DecisionesInteligentes.Colef.Sia.ApplicationServices;
using DecisionesInteligentes.Colef.Sia.Core;
using DecisionesInteligentes.Colef.Sia.Web.Controllers.Models;
using SharpArch.Core.PersistenceSupport;

namespace DecisionesInteligentes.Colef.Sia.Web.Controllers.Mappers
{
    public class InstitucionMapper : AutoFormMapper<Institucion, InstitucionForm>, IInstitucionMapper
    {
        readonly ICatalogoService catalogoService;
        public InstitucionMapper(IRepository<Institucion> repository, ICatalogoService catalogoService)
            : base(repository)
        {
            this.catalogoService = catalogoService;
        }

        protected override int GetIdFromMessage(InstitucionForm message)
        {
            return message.Id;
        }

        protected override void MapToModel(InstitucionForm message, Institucion model)
        {
            model.Nombre = message.Nombre;
            model.Responsable = message.Responsable;
            model.Email = message.Email;

            model.Pais = catalogoService.GetPaisById(message.Pais);
        }
    }
}
