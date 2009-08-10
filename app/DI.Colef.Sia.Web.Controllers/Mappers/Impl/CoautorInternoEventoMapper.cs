using System;
using DecisionesInteligentes.Colef.Sia.ApplicationServices;
using DecisionesInteligentes.Colef.Sia.Core;
using DecisionesInteligentes.Colef.Sia.Web.Controllers.Models;
using SharpArch.Core.PersistenceSupport;

namespace DecisionesInteligentes.Colef.Sia.Web.Controllers.Mappers
{
    public class CoautorInternoEventoMapper : AutoFormMapper<CoautorInternoEvento, CoautorInternoEventoForm>, ICoautorInternoEventoMapper
    {
        readonly IInvestigadorService investigadorService;

        public CoautorInternoEventoMapper(IRepository<CoautorInternoEvento> repository, IInvestigadorService investigadorService)
            : base(repository)
        {
            this.investigadorService = investigadorService;
        }

        protected override int GetIdFromMessage(CoautorInternoEventoForm message)
        {
            return message.Id;
        }

        protected override void MapToModel(CoautorInternoEventoForm message, CoautorInternoEvento model)
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
