using System;
using DecisionesInteligentes.Colef.Sia.ApplicationServices;
using DecisionesInteligentes.Colef.Sia.Core;
using DecisionesInteligentes.Colef.Sia.Web.Controllers.Models;
using SharpArch.Core.PersistenceSupport;

namespace DecisionesInteligentes.Colef.Sia.Web.Controllers.Mappers
{
    public class CoautorInternoReseņaMapper : AutoFormMapper<CoautorInternoReseņa, CoautorInternoReseņaForm>, ICoautorInternoReseņaMapper
    {
        readonly IInvestigadorService investigadorService;

        public CoautorInternoReseņaMapper(IRepository<CoautorInternoReseņa> repository, IInvestigadorService investigadorService)
            : base(repository)
        {
            this.investigadorService = investigadorService;
        }

        protected override int GetIdFromMessage(CoautorInternoReseņaForm message)
        {
            return message.Id;
        }

        protected override void MapToModel(CoautorInternoReseņaForm message, CoautorInternoReseņa model)
        {
            model.Investigador = investigadorService.GetInvestigadorById(message.InvestigadorId);

            if (model.IsTransient())
            {
                model.Activo = true;
                model.CreadorEl = DateTime.Now;
            }
            model.ModificadoEl = DateTime.Now;
        }
    }
}
