using System;
using DecisionesInteligentes.Colef.Sia.ApplicationServices;
using DecisionesInteligentes.Colef.Sia.Core;
using DecisionesInteligentes.Colef.Sia.Web.Controllers.Models;
using DecisionesInteligentes.Colef.Sia.Web.Extensions;
using SharpArch.Core.PersistenceSupport;

namespace DecisionesInteligentes.Colef.Sia.Web.Controllers.Mappers
{
    public class LibroMapper : AutoFormMapper<Libro, LibroForm>, ILibroMapper
    {
		readonly ICatalogoService catalogoService;
        readonly ICoautorExternoLibroMapper coautorExternoLibroMapper;
        readonly ICoautorInternoLibroMapper coautorInternoLibroMapper;
		
        public LibroMapper(IRepository<Libro> repository,
		    ICatalogoService catalogoService,
            ICoautorExternoLibroMapper coautorExternoLibroMapper,
            ICoautorInternoLibroMapper coautorInternoLibroMapper
		) 
			: base(repository)
        {
			this.catalogoService = catalogoService;
            this.coautorExternoLibroMapper = coautorExternoLibroMapper;
            this.coautorInternoLibroMapper = coautorInternoLibroMapper;
        }		
		
        protected override int GetIdFromMessage(LibroForm message)
        {
            return message.Id;
        }

        protected override void MapToModel(LibroForm message, Libro model)
        {
            model.TieneProyecto = message.TieneProyecto;
            model.Nombre = message.Nombre;
            model.ISBN = message.ISBN;
            model.Editorial = message.Editorial;
            model.NoPaginas = message.NoPaginas;
            model.Tiraje = message.Tiraje;
            model.PalabrasClave = message.PalabrasClave;
            model.CoTraductor = message.CoTraductor;
            model.Traductor = message.Traductor;

            model.FechaAceptacion = message.FechaAceptacion.FromShortDateToDateTime();
            model.FechaEdicion = message.FechaEdicion.FromShortDateToDateTime();

            model.TipoPublicacion = catalogoService.GetTipoPublicacionById(message.TipoPublicacion);
		    model.EstadoProducto = catalogoService.GetEstadoProductoById(message.EstadoProducto);
		    model.PeriodoReferencia = catalogoService.GetPeriodoReferenciaById(message.PeriodoReferencia);
		    model.Proyecto = catalogoService.GetProyectoById(message.Proyecto);
		    model.LineaTematica = catalogoService.GetLineaTematicaById(message.LineaTematica);
		    model.Pais = catalogoService.GetPaisById(message.Pais);
		    model.Idioma = catalogoService.GetIdiomaById(message.Idioma);
		    model.FormaParticipacion = catalogoService.GetFormaParticipacionById(message.FormaParticipacion);
            model.IdentificadorLibro = catalogoService.GetIdentificadorLibroById(message.IdentificadorLibro);
            model.Area = catalogoService.GetAreaById(message.Area);
            model.Disciplina = catalogoService.GetDisciplinaById(message.Disciplina);
            model.Subdisciplina = catalogoService.GetSubdisciplinaById(message.Subdisciplina);

            if(message.CoautorExternoLibro != null)
		        model.AddCoautorExterno(coautorExternoLibroMapper.Map(message.CoautorExternoLibro));

		    if(message.CoautorInternoLibro != null)
		        model.AddCoautorInterno(coautorInternoLibroMapper.Map(message.CoautorInternoLibro));
        }

        public Libro Map(LibroForm message, Usuario usuario, Investigador investigador)
        {
            var model = Map(message);

            if (model.IsTransient())
            {
                model.Investigador = investigador;
                model.CreadorPor = usuario;
            }

            model.ModificadoPor = usuario;

            return model;
        }
    }
}