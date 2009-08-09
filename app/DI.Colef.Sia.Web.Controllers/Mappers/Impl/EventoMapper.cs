using DecisionesInteligentes.Colef.Sia.ApplicationServices;
using DecisionesInteligentes.Colef.Sia.Core;
using DecisionesInteligentes.Colef.Sia.Web.Controllers.Models;
using DecisionesInteligentes.Colef.Sia.Web.Extensions;
using SharpArch.Core.PersistenceSupport;

namespace DecisionesInteligentes.Colef.Sia.Web.Controllers.Mappers
{
    public class EventoMapper : AutoFormMapper<Evento, EventoForm>, IEventoMapper
    {
        readonly ICatalogoService catalogoService;
        readonly ITipoParticipacionEventoMapper tipoParticipacionEventoMapper;
        readonly ICoautorExternoEventoMapper coautorExternoEventoMapper;
        readonly ICoautorInternoEventoMapper coautorInternoEventoMapper;

        public EventoMapper(IRepository<Evento> repository, ICatalogoService catalogoService,
            ITipoParticipacionEventoMapper tipoParticipacionEventoMapper, ICoautorExternoEventoMapper coautorExternoEventoMapper,
            ICoautorInternoEventoMapper coautorInternoEventoMapper
        )
            : base(repository)
        {
            this.catalogoService = catalogoService;
            this.tipoParticipacionEventoMapper = tipoParticipacionEventoMapper;
            this.coautorExternoEventoMapper = coautorExternoEventoMapper;
            this.coautorInternoEventoMapper = coautorInternoEventoMapper;
        }

        protected override int GetIdFromMessage(EventoForm message)
        {
            return message.Id;
        }

        protected override void MapToModel(EventoForm message, Evento model)
        {
            model.Nombre = message.Nombre;
            model.Titulo = message.Titulo;
            model.Invitacion = message.Invitacion;
            model.Lugar = message.Lugar;

            model.FechaInicial = message.FechaInicial.FromShortDateToDateTime();
            model.FechaFinal = message.FechaFinal.FromShortDateToDateTime();

            model.Ambito = catalogoService.GetAmbitoById(message.Ambito);
            model.TipoEvento = catalogoService.GetTipoEventoById(message.TipoEvento);
            model.Institucion = catalogoService.GetInstitucionById(message.Institucion);
            model.LineaTematica = catalogoService.GetLineaTematicaById(message.LineaTematica);
            model.TipoFinanciamiento = catalogoService.GetTipoFinanciamientoById(message.TipoFinanciamiento);

            if (message.TipoParticipacionEvento != null)
                model.AddTipo(tipoParticipacionEventoMapper.Map(message.TipoParticipacionEvento));
            if (message.CoautorExternoEvento != null)
                model.AddCoautorExterno(coautorExternoEventoMapper.Map(message.CoautorExternoEvento));
            if (message.CoautorInternoEvento != null)
                model.AddCoautorInterno(coautorInternoEventoMapper.Map(message.CoautorInternoEvento));
        }

        public Evento Map(EventoForm message, Usuario usuario, Investigador investigador)
        {
            var model = Map(message);

            if (model.IsTransient())
            {
                //model.Investigador = investigador;
                model.CreadorPor = usuario;
                //model.CoautorExternoArticulos[0].CreadorPor = usuario;
                //model.CoautorInternoArticulos[0].CreadorPor = usuario;
            }

            model.ModificadoPor = usuario;

            return model;
        }
    }
}
