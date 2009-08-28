﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DecisionesInteligentes.Colef.Sia.Core;
using DecisionesInteligentes.Colef.Sia.Core.DataInterfaces;
using NHibernate;
using NHibernate.Criterion;
using SharpArch.Core.PersistenceSupport;
using SharpArch.Data.NHibernate;

namespace DecisionesInteligentes.Colef.Sia.ApplicationServices
{
    public class CatalogoService : ICatalogoService
    {
        readonly IRepository<ProgramaEstudio> programaEstudioRepository;
        readonly IRepository<IdentificadorLibro> identificadorLibroRepository;
        readonly IRepository<Convenio> convenioRepository;
        readonly IRepository<TipoEstancia> tipoEstanciaRepository;
        readonly IRepository<TipoInstitucion> tipoInstitucionRepository;
        readonly IRepository<TipoProyecto> tipoProyectoRepository;
        readonly IRepository<TipoPublicacion> tipoPublicacionRepository;
        readonly IRepository<Sector> sectorRepository;
        readonly IRepository<Nivel> nivelRepository;
        readonly IRepository<Cargo> cargoRepository;
        readonly IRepository<Departamento> departamentoRepository;
        readonly IRepository<Puesto> puestoRepository;
        readonly IRepository<Sede> sedeRepository;
        readonly IRepository<Categoria> categoriaRepository;
        readonly IRepository<GradoAcademico> gradoAcademicoRepository;
        readonly IRepository<SNI> sniRepository;
        readonly IRepository<Estado> estadoRepository;
        readonly IRepository<Idioma> idiomaRepository;
        readonly IRepository<Pais> paisRepository;
        readonly IRepository<TipoArticulo> tipoArticuloRepository;
        readonly IRepository<Institucion> institucionRepository;
        readonly IRepository<Indice> indiceRepository;
        readonly IRepository<InvestigadorExterno> investigadorExternoRepository;
        readonly IRepository<TipoParticipante> tipoParticipanteRepository;
        readonly IRepository<LineaInvestigacion> lineaInvestigacionRepository;
        readonly IRepository<TipoActividad> tipoActividadRepository;
        readonly IRepository<Area> areaRepository;
        readonly IRepository<Disciplina> disciplinaRepository;
        readonly IRepository<Subdisciplina> subdisciplinaRepository;
        readonly IRepository<LineaTematica> lineaTematicaRepository;
        readonly IRepository<CoautorExterno> coautorExternoRepository;
        readonly IRepository<FormaParticipacion> formaParticipacionRepository;
        readonly IRepository<ResponsableExterno> responsableExternoRepository;
        readonly IRepository<TipoCapitulo> tipoCapituloRepository;
        readonly IRepository<TipoParticipacion> tipoParticipacionRepository;
        readonly IRepository<PeriodoReferencia> periodoReferenciaRepository;
        readonly IRepository<RevistaPublicacion> revistaPublicacionRepository;
        readonly IRepository<Organizacion> organizacionRepository;
        readonly IRepository<Dependencia> dependenciaRepository;
        readonly IRepository<Ambito> ambitoRepository;
        readonly IRepository<EstadoPais> estadoPaisRepository;
        readonly IRepository<Genero> generoRepository;
        readonly IRepository<MedioElectronico> medioElectronicoRepository;
        readonly IRepository<MedioImpreso> medioImpresoRepository;
        readonly IRepository<OtraParticipacion> otraParticipacionRepository;
        readonly IRepository<Proyecto> proyectoRepository;
        readonly IRepository<TipoDictamen> tipoDictamenRepository;
        readonly IRepository<TipoDistincion> tipoDistincionRepository;
        readonly IRepository<TipoEvento> tipoEventoRepository;
        readonly IRepository<TipoFinanciamiento> tipoFinanciamientoRepository;
        readonly IRepository<TipoOrgano> tipoOrganoRepository;
        readonly IRepository<TipoPresentacion> tipoPresentacionRepository;
        readonly IRepository<TipoReporte> tipoReporteRepository;
        readonly IRepository<EstadoProducto> estadoProductoRepository;
        readonly IRepository<NivelEstudio> nivelEstudioRepository;
        readonly IRepository<ProductoDerivado> productoDerivadoRepository;
        readonly IRepository<TipoResena> tipoResenaRepository;
        readonly IRepository<TipoApoyo> tipoApoyoRepository;
        readonly IRepository<SubprogramaConacyt> subprogramaConacytRepository;
        readonly IRepository<Rama> ramaRepository;
        readonly IRepository<Clase> claseRepository;

        public CatalogoService(IRepository<Cargo> cargoRepository,
            IRepository<TipoProyecto> tipoProyectoRepository,
            IRepository<IdentificadorLibro> identificadorLibroRepository,
            IRepository<Convenio> convenioRepository,
            IRepository<TipoInstitucion> tipoInstitucionRepository,
            IRepository<Departamento> departamentoRepository,
            IRepository<Puesto> puestoRepository,
            IRepository<Sede> sedeRepository,
            IRepository<Categoria> categoriaRepository,
            IRepository<GradoAcademico> gradoAcademicoRepository,
            IRepository<SNI> sniRepository,
            IRepository<Estado> estadoRepository,
            IRepository<Idioma> idiomaRepository,
            IRepository<Pais> paisRepository,
            IRepository<TipoArticulo> tipoArticuloRepository,
            IRepository<Institucion> institucionRepository,
            IRepository<Indice> indiceRepository,
            IRepository<InvestigadorExterno> investigadorExternoRepository,
            IRepository<TipoParticipante> tipoParticipanteRepository,
            IRepository<LineaInvestigacion> lineaInvestigacionRepository,
            IRepository<TipoActividad> tipoActividadRepository,
            IRepository<Area> areaRepository,
            IRepository<Disciplina> disciplinaRepository,
            IRepository<Subdisciplina> subdisciplinaRepository,
            IRepository<LineaTematica> lineaTematicaRepository,
            IRepository<CoautorExterno> coautorExternoRepository,
            IRepository<FormaParticipacion> formaParticipacionRepository,
            IRepository<ResponsableExterno> responsableExternoRepository,
            IRepository<TipoCapitulo> tipoCapituloRepository,
            IRepository<TipoParticipacion> tipoParticipacionRepository,
            IRepository<PeriodoReferencia> periodoReferenciaRepository,
            IRepository<Nivel> nivelRepository,
            IRepository<Sector> sectorRepository,
            IRepository<ProgramaEstudio> programaEstudioRepository,
            IRepository<RevistaPublicacion> revistaPublicacionRepository,
            IRepository<Organizacion> organizacionRepository,
            IRepository<Dependencia> dependenciaRepository,
            IRepository<Ambito> ambitoRepository,
            IRepository<EstadoPais> estadoPaisRepository,
            IRepository<Genero> generoRepository,
            IRepository<TipoEstancia> tipoEstanciaRepository,
            IRepository<MedioElectronico> medioElectronicoRepository,
            IRepository<MedioImpreso> medioImpresoRepository,
            IRepository<OtraParticipacion> otraParticipacionRepository,
            IRepository<Proyecto> proyectoRepository,
            IRepository<TipoDictamen> tipoDictamenRepository,
            IRepository<TipoDistincion> tipoDistincionRepository,
            IRepository<TipoEvento> tipoEventoRepository,
            IRepository<TipoFinanciamiento> tipoFinanciamientoRepository,
            IRepository<TipoOrgano> tipoOrganoRepository,
            IRepository<TipoPresentacion> tipoPresentacionRepository,
            IRepository<TipoReporte> tipoReporteRepository,
            IRepository<EstadoProducto> estadoProductoRepository,
            IRepository<TipoPublicacion> tipoPublicacionRepository,
            IRepository<NivelEstudio> nivelEstudioRepository,
            IRepository<ProductoDerivado> productoDerivadoRepository,
            IRepository<TipoResena> tipoResenaRepository,
            IRepository<TipoApoyo> tipoApoyoRepository,
            IRepository<SubprogramaConacyt> subprogramaConacytRepository,
            IRepository<Rama> ramaRepository,
            IRepository<Clase> claseRepository)
        {
            this.tipoPublicacionRepository = tipoPublicacionRepository;
            this.cargoRepository = cargoRepository;
            this.departamentoRepository = departamentoRepository;
            this.puestoRepository = puestoRepository;
            this.sedeRepository = sedeRepository;
            this.categoriaRepository = categoriaRepository;
            this.gradoAcademicoRepository = gradoAcademicoRepository;
            this.sniRepository = sniRepository;
            this.estadoRepository = estadoRepository;
            this.idiomaRepository = idiomaRepository;
            this.paisRepository = paisRepository;
            this.identificadorLibroRepository = identificadorLibroRepository;
            this.tipoInstitucionRepository = tipoInstitucionRepository;
            this.tipoArticuloRepository = tipoArticuloRepository;
            this.institucionRepository = institucionRepository;
            this.indiceRepository = indiceRepository;
            this.investigadorExternoRepository = investigadorExternoRepository;
            this.tipoParticipanteRepository = tipoParticipanteRepository;
            this.lineaInvestigacionRepository = lineaInvestigacionRepository;
            this.tipoActividadRepository = tipoActividadRepository;
            this.areaRepository = areaRepository;
            this.disciplinaRepository = disciplinaRepository;
            this.subdisciplinaRepository = subdisciplinaRepository;
            this.lineaTematicaRepository = lineaTematicaRepository;
            this.coautorExternoRepository = coautorExternoRepository;
            this.formaParticipacionRepository = formaParticipacionRepository;
            this.responsableExternoRepository = responsableExternoRepository;
            this.tipoCapituloRepository = tipoCapituloRepository;
            this.tipoParticipacionRepository = tipoParticipacionRepository;
            this.periodoReferenciaRepository = periodoReferenciaRepository;
            this.revistaPublicacionRepository = revistaPublicacionRepository;
            this.programaEstudioRepository = programaEstudioRepository;
            this.sectorRepository = sectorRepository;
            this.tipoEstanciaRepository = tipoEstanciaRepository;
            this.nivelRepository = nivelRepository;
            this.organizacionRepository = organizacionRepository;
            this.dependenciaRepository = dependenciaRepository;
            this.ambitoRepository = ambitoRepository;
            this.convenioRepository = convenioRepository;
            this.estadoPaisRepository = estadoPaisRepository;
            this.generoRepository = generoRepository;
            this.medioElectronicoRepository = medioElectronicoRepository;
            this.medioImpresoRepository = medioImpresoRepository;
            this.otraParticipacionRepository = otraParticipacionRepository;
            this.proyectoRepository = proyectoRepository;
            this.tipoDictamenRepository = tipoDictamenRepository;
            this.tipoDistincionRepository = tipoDistincionRepository;
            this.tipoEventoRepository = tipoEventoRepository;
            this.tipoFinanciamientoRepository = tipoFinanciamientoRepository;
            this.tipoOrganoRepository = tipoOrganoRepository;
            this.tipoPresentacionRepository = tipoPresentacionRepository;
            this.tipoReporteRepository = tipoReporteRepository;
            this.estadoProductoRepository = estadoProductoRepository;
            this.nivelEstudioRepository = nivelEstudioRepository;
            this.tipoProyectoRepository = tipoProyectoRepository;
            this.productoDerivadoRepository = productoDerivadoRepository;
            this.tipoResenaRepository = tipoResenaRepository;
            this.tipoApoyoRepository = tipoApoyoRepository;
            this.subprogramaConacytRepository = subprogramaConacytRepository;
            this.ramaRepository = ramaRepository;
            this.claseRepository = claseRepository;
        }

        protected virtual ISession Session
        {
            get
            {
                string factoryKey = SessionFactoryAttribute.GetKeyFrom(this);
                return NHibernateSession.CurrentFor(factoryKey);
            }
        }

        protected IList<T> OrderCatalog<T>(Expression<Func<T, object>> expression)
        {
            return OrderCatalog(expression, false);
        }

        protected IList<T> OrderCatalog<T>(Expression<Func<T, object>> expression, bool active)
        {
            var propertyInfo = ReflectionHelper.GetProperty(expression);

            var criteria = DetachedCriteria.For(typeof (T))
                .AddOrder(Order.Asc(propertyInfo.Name));

            if (active)
                criteria.Add(Restrictions.Eq("Activo", true));

            var list = criteria.GetExecutableCriteria(Session).List<T>();

            return list;
        }

        public Cargo GetCargoById(int id)
        {
            return cargoRepository.Get(id);
        }

        public Cargo[] GetAllCargos()
        {
            return ((List<Cargo>) OrderCatalog<Cargo>(x => x.Nombre)).ToArray();
        }

        public Cargo[] GetActiveCargos()
        {
            return ((List<Cargo>) OrderCatalog<Cargo>(x => x.Nombre, true)).ToArray();
        }

        public void SaveCargo(Cargo cargo)
        {
            if (cargo.Id == 0)
            {
                cargo.Activo = true;
                cargo.CreadorEl = DateTime.Now;
            }
            cargo.ModificadoEl = DateTime.Now;

            cargoRepository.SaveOrUpdate(cargo);
        }

        public Departamento GetDepartamentoById(int id)
        {
            return departamentoRepository.Get(id);
        }

        public Departamento[] GetAllDepartamentos()
        {
            return ((List<Departamento>) OrderCatalog<Departamento>(x => x.Nombre)).ToArray();
        }

        public Departamento[] GetActiveDepartamentos()
        {
            return ((List<Departamento>) OrderCatalog<Departamento>(x => x.Nombre, true)).ToArray();
        }

        public void SaveDepartamento(Departamento departamento)
        {
            if (departamento.Id == 0)
            {
                departamento.Activo = true;
                departamento.CreadorEl = DateTime.Now;
            }
            departamento.ModificadoEl = DateTime.Now;

            departamentoRepository.SaveOrUpdate(departamento);
        }

        public Puesto GetPuestoById(int id)
        {
            return puestoRepository.Get(id);
        }

        public Puesto[] GetAllPuestos()
        {
            return ((List<Puesto>) OrderCatalog<Puesto>(x => x.Nombre)).ToArray();
        }

        public Puesto[] GetActivePuestos()
        {
            return ((List<Puesto>) OrderCatalog<Puesto>(x => x.Nombre, true)).ToArray();
        }

        public void SavePuesto(Puesto puesto)
        {
            if (puesto.Id == 0)
            {
                puesto.Activo = true;
                puesto.CreadorEl = DateTime.Now;
            }
            puesto.ModificadoEl = DateTime.Now;

            puestoRepository.SaveOrUpdate(puesto);
        }

        public Sede GetSedeById(int id)
        {
            return sedeRepository.Get(id);
        }

        public Sede[] GetAllSedes()
        {
            return ((List<Sede>) OrderCatalog<Sede>(x => x.Nombre)).ToArray();
        }

        public Sede[] GetActiveSedes()
        {
            return ((List<Sede>) OrderCatalog<Sede>(x => x.Nombre, true)).ToArray();
        }

        public void SaveSede(Sede sede)
        {
            if (sede.Id == 0)
            {
                sede.Activo = true;
                sede.CreadorEl = DateTime.Now;
            }
            sede.ModificadoEl = DateTime.Now;

            sedeRepository.SaveOrUpdate(sede);
        }

        public Categoria GetCategoriaById(int id)
        {
            return categoriaRepository.Get(id);
        }

        public Categoria[] GetAllCategorias()
        {
            return ((List<Categoria>) OrderCatalog<Categoria>(x => x.Nombre)).ToArray();
        }

        public Categoria[] GetActiveCategorias()
        {
            return ((List<Categoria>) OrderCatalog<Categoria>(x => x.Nombre, true)).ToArray();
        }

        public void SaveCategoria(Categoria categoria)
        {
            if (categoria.Id == 0)
            {
                categoria.Activo = true;
                categoria.CreadorEl = DateTime.Now;
            }
            categoria.ModificadoEl = DateTime.Now;

            categoriaRepository.SaveOrUpdate(categoria);
        }

        public GradoAcademico GetGradoAcademicoById(int id)
        {
            return gradoAcademicoRepository.Get(id);
        }

        public GradoAcademico[] GetAllGradoAcademicos()
        {
            return ((List<GradoAcademico>) OrderCatalog<GradoAcademico>(x => x.Nombre)).ToArray();
        }

        public GradoAcademico[] GetActiveGrados()
        {
            return ((List<GradoAcademico>) OrderCatalog<GradoAcademico>(x => x.Nombre, true)).ToArray();
        }

        public void SaveGradoAcademico(GradoAcademico gradoAcademico)
        {
            if (gradoAcademico.Id == 0)
            {
                gradoAcademico.Activo = true;
                gradoAcademico.CreadorEl = DateTime.Now;
            }
            gradoAcademico.ModificadoEl = DateTime.Now;

            gradoAcademicoRepository.SaveOrUpdate(gradoAcademico);
        }

        public SNI GetSNIById(int id)
        {
            return sniRepository.Get(id);
        }

        public SNI[] GetAllSNIs()
        {
            return ((List<SNI>) OrderCatalog<SNI>(x => x.Nombre)).ToArray();
        }

        public SNI[] GetActiveSNIs()
        {
            return ((List<SNI>) OrderCatalog<SNI>(x => x.Nombre, true)).ToArray();
        }

        public void SaveSNI(SNI sni)
        {
            if (sni.Id == 0)
            {
                sni.Activo = true;
                sni.CreadorEl = DateTime.Now;
            }
            sni.ModificadoEl = DateTime.Now;

            sniRepository.SaveOrUpdate(sni);
        }

        public Estado GetEstadoById(int id)
        {
            return estadoRepository.Get(id);
        }

        public Estado[] GetAllEstados()
        {
            return ((List<Estado>) OrderCatalog<Estado>(x => x.Nombre)).ToArray();
        }

        public Estado[] GetActiveEstados()
        {
            return ((List<Estado>) OrderCatalog<Estado>(x => x.Nombre, true)).ToArray();
        }

        public void SaveEstado(Estado estado)
        {
            if (estado.Id == 0)
            {
                estado.Activo = true;
                estado.CreadorEl = DateTime.Now;
            }
            estado.ModificadoEl = DateTime.Now;

            estadoRepository.SaveOrUpdate(estado);
        }

        public Idioma GetIdiomaById(int id)
        {
            return idiomaRepository.Get(id);
        }

        public Idioma[] GetAllIdiomas()
        {
            return ((List<Idioma>) OrderCatalog<Idioma>(x => x.Nombre)).ToArray();
        }

        public Idioma[] GetActiveIdiomas()
        {
            return ((List<Idioma>) OrderCatalog<Idioma>(x => x.Nombre, true)).ToArray();
        }

        public void SaveIdioma(Idioma idioma)
        {
            if (idioma.Id == 0)
            {
                idioma.Activo = true;
                idioma.CreadorEl = DateTime.Now;
            }
            idioma.ModificadoEl = DateTime.Now;

            idiomaRepository.SaveOrUpdate(idioma);
        }

        public Pais GetPaisById(int id)
        {
            return paisRepository.Get(id);
        }

        public Pais[] GetAllPaises()
        {
            return ((List<Pais>) OrderCatalog<Pais>(x => x.Nombre)).ToArray();
        }

        public Pais[] GetActivePaises()
        {
            return ((List<Pais>) OrderCatalog<Pais>(x => x.Nombre, true)).ToArray();
        }

        public void SavePais(Pais pais)
        {
            if (pais.Id == 0)
            {
                pais.Activo = true;
                pais.CreadorEl = DateTime.Now;
            }
            pais.ModificadoEl = DateTime.Now;

            paisRepository.SaveOrUpdate(pais);
        }

        public TipoArticulo GetTipoArticuloById(int id)
        {
            return tipoArticuloRepository.Get(id);
        }

        public TipoArticulo[] GetAllTipoArticulos()
        {
            return ((List<TipoArticulo>) OrderCatalog<TipoArticulo>(x => x.Nombre)).ToArray();
        }

        public TipoArticulo[] GetActiveArticulos()
        {
            return ((List<TipoArticulo>) OrderCatalog<TipoArticulo>(x => x.Nombre, true)).ToArray();
        }

        public void SaveTipoArticulo(TipoArticulo tipoArticulo)
        {
            if (tipoArticulo.Id == 0)
            {
                tipoArticulo.Activo = true;
                tipoArticulo.CreadorEl = DateTime.Now;
            }
            tipoArticulo.ModificadoEl = DateTime.Now;

            tipoArticuloRepository.SaveOrUpdate(tipoArticulo);
        }

        public Institucion GetInstitucionById(int id)
        {
            return institucionRepository.Get(id);
        }

        public Institucion[] GetAllInstituciones()
        {
            return ((List<Institucion>) OrderCatalog<Institucion>(x => x.Nombre)).ToArray();
        }

        public Institucion[] GetActiveInstituciones()
        {
            return ((List<Institucion>) OrderCatalog<Institucion>(x => x.Nombre, true)).ToArray();
        }

        public void SaveInstitucion(Institucion institucion)
        {
            if (institucion.Id == 0)
            {
                institucion.Activo = true;
                institucion.CreadorEl = DateTime.Now;
            }
            institucion.ModificadoEl = DateTime.Now;

            institucionRepository.SaveOrUpdate(institucion);
        }

        public Indice GetIndiceById(int id)
        {
            return indiceRepository.Get(id);
        }

        public Indice[] GetAllIndices()
        {
            return ((List<Indice>) OrderCatalog<Indice>(x => x.Nombre)).ToArray();
        }

        public Indice[] GetActiveIndices()
        {
            return ((List<Indice>) OrderCatalog<Indice>(x => x.Nombre, true)).ToArray();
        }

        public void SaveIndice(Indice indice)
        {
            if (indice.Id == 0)
            {
                indice.Activo = true;
                indice.CreadorEl = DateTime.Now;
            }
            indice.ModificadoEl = DateTime.Now;

            indiceRepository.SaveOrUpdate(indice);
        }

        public InvestigadorExterno GetInvestigadorExternoById(int id)
        {
            return investigadorExternoRepository.Get(id);
        }

        public InvestigadorExterno[] GetAllInvestigadorExternos()
        {
            return ((List<InvestigadorExterno>) OrderCatalog<InvestigadorExterno>(x => x.Nombre)).ToArray();
        }

        public InvestigadorExterno[] GetActiveInvestigadorExternos()
        {
            return ((List<InvestigadorExterno>) OrderCatalog<InvestigadorExterno>(x => x.Nombre, true)).ToArray();
        }

        public void SaveInvestigadorExterno(InvestigadorExterno investigadorExterno)
        {
            if (investigadorExterno.Id == 0)
            {
                investigadorExterno.Activo = true;
                investigadorExterno.CreadorEl = DateTime.Now;
            }
            investigadorExterno.ModificadoEl = DateTime.Now;

            investigadorExternoRepository.SaveOrUpdate(investigadorExterno);
        }

        public TipoParticipante GetTipoParticipanteById(int id)
        {
            return tipoParticipanteRepository.Get(id);
        }

        public TipoParticipante[] GetAllTipoParticipantes()
        {
            return ((List<TipoParticipante>) OrderCatalog<TipoParticipante>(x => x.Nombre)).ToArray();
        }

        public TipoParticipante[] GetActiveParticipantes()
        {
            return ((List<TipoParticipante>) OrderCatalog<TipoParticipante>(x => x.Nombre, true)).ToArray();
        }

        public void SaveTipoParticipante(TipoParticipante tipoParticipante)
        {
            if (tipoParticipante.Id == 0)
            {
                tipoParticipante.Activo = true;
                tipoParticipante.CreadorEl = DateTime.Now;
            }
            tipoParticipante.ModificadoEl = DateTime.Now;

            tipoParticipanteRepository.SaveOrUpdate(tipoParticipante);
        }

        public LineaInvestigacion GetLineaInvestigacionById(int id)
        {
            return lineaInvestigacionRepository.Get(id);
        }

        public LineaInvestigacion[] GetAllLineaInvestigaciones()
        {
            return ((List<LineaInvestigacion>) OrderCatalog<LineaInvestigacion>(x => x.Nombre)).ToArray();
        }

        public LineaInvestigacion[] GetActiveLineaInvestigaciones()
        {
            return ((List<LineaInvestigacion>) OrderCatalog<LineaInvestigacion>(x => x.Nombre, true)).ToArray();
        }

        public void SaveLineaInvestigacion(LineaInvestigacion lineaInvestigacion)
        {
            if (lineaInvestigacion.Id == 0)
            {
                lineaInvestigacion.Activo = true;
                lineaInvestigacion.CreadorEl = DateTime.Now;
            }
            lineaInvestigacion.ModificadoEl = DateTime.Now;

            lineaInvestigacionRepository.SaveOrUpdate(lineaInvestigacion);
        }

        public TipoActividad GetTipoActividadById(int id)
        {
            return tipoActividadRepository.Get(id);
        }

        public TipoActividad[] GetAllTipoActividades()
        {
            return ((List<TipoActividad>) OrderCatalog<TipoActividad>(x => x.Nombre)).ToArray();
        }

        public TipoActividad[] GetActiveActividades()
        {
            return ((List<TipoActividad>) OrderCatalog<TipoActividad>(x => x.Nombre, true)).ToArray();
        }

        public void SaveTipoActividad(TipoActividad tipoActividad)
        {
            if (tipoActividad.Id == 0)
            {
                tipoActividad.Activo = true;
                tipoActividad.CreadorEl = DateTime.Now;
            }
            tipoActividad.ModificadoEl = DateTime.Now;

            tipoActividadRepository.SaveOrUpdate(tipoActividad);
        }

        public Area GetAreaById(int id)
        {
            return areaRepository.Get(id);
        }

        public Area[] GetAllAreas()
        {
            return ((List<Area>) OrderCatalog<Area>(x => x.Nombre)).ToArray();
        }

        public Area[] GetActiveAreas()
        {
            return ((List<Area>) OrderCatalog<Area>(x => x.Nombre, true)).ToArray();
        }

        public void SaveArea(Area area)
        {
            if (area.Id == 0)
            {
                area.Activo = true;
                area.CreadorEl = DateTime.Now;
            }
            area.ModificadoEl = DateTime.Now;

            areaRepository.SaveOrUpdate(area);
        }

        public Disciplina GetDisciplinaById(int id)
        {
            return disciplinaRepository.Get(id);
        }

        public Disciplina[] GetAllDisciplinas()
        {
            return ((List<Disciplina>) OrderCatalog<Disciplina>(x => x.Nombre)).ToArray();
        }

        public Disciplina[] GetActiveDisciplinas()
        {
            return ((List<Disciplina>) OrderCatalog<Disciplina>(x => x.Nombre, true)).ToArray();
        }

        public void SaveDisciplina(Disciplina disciplina)
        {
            if (disciplina.Id == 0)
            {
                disciplina.Activo = true;
                disciplina.CreadorEl = DateTime.Now;
            }
            disciplina.ModificadoEl = DateTime.Now;

            disciplinaRepository.SaveOrUpdate(disciplina);
        }

        public Subdisciplina GetSubdisciplinaById(int id)
        {
            return subdisciplinaRepository.Get(id);
        }

        public Subdisciplina[] GetAllSubdisciplinas()
        {
            return ((List<Subdisciplina>) OrderCatalog<Subdisciplina>(x => x.Nombre)).ToArray();
        }

        public Subdisciplina[] GetActiveSubdisciplinas()
        {
            return ((List<Subdisciplina>) OrderCatalog<Subdisciplina>(x => x.Nombre, true)).ToArray();
        }

        public void SaveSubdisciplina(Subdisciplina subdisciplina)
        {
            if (subdisciplina.Id == 0)
            {
                subdisciplina.Activo = true;
                subdisciplina.CreadorEl = DateTime.Now;
            }
            subdisciplina.ModificadoEl = DateTime.Now;

            subdisciplinaRepository.SaveOrUpdate(subdisciplina);
        }

        public LineaTematica GetLineaTematicaById(int id)
        {
            return lineaTematicaRepository.Get(id);
        }

        public LineaTematica[] GetAllLineaTematicas()
        {
            return ((List<LineaTematica>) OrderCatalog<LineaTematica>(x => x.Nombre)).ToArray();
        }

        public LineaTematica[] GetActiveLineaTematicas()
        {
            return ((List<LineaTematica>) OrderCatalog<LineaTematica>(x => x.Nombre, true)).ToArray();
        }

        public void SaveLineaTematica(LineaTematica lineaTematica)
        {
            if (lineaTematica.Id == 0)
            {
                lineaTematica.Activo = true;
                lineaTematica.CreadorEl = DateTime.Now;
            }
            lineaTematica.ModificadoEl = DateTime.Now;

            lineaTematicaRepository.SaveOrUpdate(lineaTematica);
        }

        public CoautorExterno GetCoautorExternoById(int id)
        {
            return coautorExternoRepository.Get(id);
        }

        public CoautorExterno[] GetAllCoautorExternos()
        {
            return ((List<CoautorExterno>) OrderCatalog<CoautorExterno>(x => x.Nombre)).ToArray();
        }

        public CoautorExterno[] GetActiveCoautorExternos()
        {
            return ((List<CoautorExterno>) OrderCatalog<CoautorExterno>(x => x.Nombre, true)).ToArray();
        }

        public void SaveCoautorExterno(CoautorExterno coautorExterno)
        {
            if (coautorExterno.Id == 0)
            {
                coautorExterno.Activo = true;
                coautorExterno.CreadorEl = DateTime.Now;
            }
            coautorExterno.ModificadoEl = DateTime.Now;

            coautorExternoRepository.SaveOrUpdate(coautorExterno);
        }

        public FormaParticipacion GetFormaParticipacionById(int id)
        {
            return formaParticipacionRepository.Get(id);
        }

        public FormaParticipacion[] GetAllFormaParticipaciones()
        {
            return ((List<FormaParticipacion>) OrderCatalog<FormaParticipacion>(x => x.Nombre)).ToArray();
        }

        public FormaParticipacion[] GetActiveFormaParticipaciones()
        {
            return ((List<FormaParticipacion>) OrderCatalog<FormaParticipacion>(x => x.Nombre, true)).ToArray();
        }

        public void SaveFormaParticipacion(FormaParticipacion formaParticipacion)
        {
            if (formaParticipacion.Id == 0)
            {
                formaParticipacion.Activo = true;
                formaParticipacion.CreadorEl = DateTime.Now;
            }
            formaParticipacion.ModificadoEl = DateTime.Now;

            formaParticipacionRepository.SaveOrUpdate(formaParticipacion);
        }

        public ResponsableExterno GetResponsableExternoById(int id)
        {
            return responsableExternoRepository.Get(id);
        }

        public ResponsableExterno[] GetAllResponsableExternos()
        {
            return ((List<ResponsableExterno>) OrderCatalog<ResponsableExterno>(x => x.Nombre)).ToArray();
        }

        public ResponsableExterno[] GetActiveResponsableExternos()
        {
            return ((List<ResponsableExterno>) OrderCatalog<ResponsableExterno>(x => x.Nombre, true)).ToArray();
        }

        public void SaveResponsableExterno(ResponsableExterno responsableExterno)
        {
            if (responsableExterno.Id == 0)
            {
                responsableExterno.Activo = true;
                responsableExterno.CreadorEl = DateTime.Now;
            }
            responsableExterno.ModificadoEl = DateTime.Now;

            responsableExternoRepository.SaveOrUpdate(responsableExterno);
        }

        public TipoCapitulo GetTipoCapituloById(int id)
        {
            return tipoCapituloRepository.Get(id);
        }

        public TipoCapitulo[] GetAllTipoCapitulos()
        {
            return ((List<TipoCapitulo>) OrderCatalog<TipoCapitulo>(x => x.Nombre)).ToArray();
        }

        public TipoCapitulo[] GetActiveTipoCapitulos()
        {
            return ((List<TipoCapitulo>) OrderCatalog<TipoCapitulo>(x => x.Nombre, true)).ToArray();
        }

        public void SaveTipoCapitulo(TipoCapitulo tipoCapitulo)
        {
            if (tipoCapitulo.Id == 0)
            {
                tipoCapitulo.Activo = true;
                tipoCapitulo.CreadorEl = DateTime.Now;
            }
            tipoCapitulo.ModificadoEl = DateTime.Now;

            tipoCapituloRepository.SaveOrUpdate(tipoCapitulo);
        }

        public TipoParticipacion GetTipoParticipacionById(int id)
        {
            return tipoParticipacionRepository.Get(id);
        }

        public TipoParticipacion[] GetAllTipoParticipaciones()
        {
            return ((List<TipoParticipacion>) OrderCatalog<TipoParticipacion>(x => x.Nombre)).ToArray();
        }

        public TipoParticipacion[] GetActiveTipoParticipaciones()
        {
            return ((List<TipoParticipacion>) OrderCatalog<TipoParticipacion>(x => x.Nombre, true)).ToArray();
        }

        public void SaveTipoParticipacion(TipoParticipacion tipoParticipacion)
        {
            if (tipoParticipacion.Id == 0)
            {
                tipoParticipacion.Activo = true;
                tipoParticipacion.CreadorEl = DateTime.Now;
            }
            tipoParticipacion.ModificadoEl = DateTime.Now;

            tipoParticipacionRepository.SaveOrUpdate(tipoParticipacion);
        }

        public PeriodoReferencia GetPeriodoReferenciaById(int id)
        {
            return periodoReferenciaRepository.Get(id);
        }

        public PeriodoReferencia[] GetAllPeriodoReferencias()
        {
            return ((List<PeriodoReferencia>) OrderCatalog<PeriodoReferencia>(x => x.Orden)).ToArray();
        }

        public PeriodoReferencia[] GetActivePeriodoReferencias()
        {
            return ((List<PeriodoReferencia>) OrderCatalog<PeriodoReferencia>(x => x.Orden, true)).ToArray();
        }

        public PeriodoReferencia GetCurrentPeriodoReferencia()
        {
            var criteria = Session.CreateCriteria(typeof (PeriodoReferencia))
                .SetProjection(Projections.ProjectionList()
                                   .Add(Projections.Max("Orden")))
                .List();

            var periodo = new Dictionary<string, object> { { "Orden", criteria[0] } };

            return periodoReferenciaRepository.FindOne(periodo); 
        }

        public void SavePeriodoReferencia(PeriodoReferencia periodoReferencia)
        {
            if (periodoReferencia.Id == 0)
            {
                periodoReferencia.Activo = true;
                periodoReferencia.CreadorEl = DateTime.Now;
            }
            periodoReferencia.ModificadoEl = DateTime.Now;

            periodoReferenciaRepository.SaveOrUpdate(periodoReferencia);
        }

        public RevistaPublicacion GetRevistaPublicacionById(int id)
        {
            return revistaPublicacionRepository.Get(id);
        }

        public RevistaPublicacion[] GetAllRevistaPublicaciones()
        {
            return ((List<RevistaPublicacion>) OrderCatalog<RevistaPublicacion>(x => x.Titulo)).ToArray();
        }

        public RevistaPublicacion[] GetActiveRevistaPublicaciones()
        {
            return ((List<RevistaPublicacion>) OrderCatalog<RevistaPublicacion>(x => x.Titulo, true)).ToArray();
        }

        public void SaveRevistaPublicacion(RevistaPublicacion revistaPublicacion)
        {
            if (revistaPublicacion.Id == 0)
            {
                revistaPublicacion.Activo = true;
                revistaPublicacion.CreadorEl = DateTime.Now;
                revistaPublicacion.Puntuacion = 0;
            }

            revistaPublicacion.ModificadoEl = DateTime.Now;

            revistaPublicacionRepository.SaveOrUpdate(revistaPublicacion);
        }

        public ProgramaEstudio GetProgramaEstudioById(int id)
        {
            return programaEstudioRepository.Get(id);
        }

        public ProgramaEstudio[] GetAllProgramaEstudios()
        {
            return ((List<ProgramaEstudio>) OrderCatalog<ProgramaEstudio>(x => x.Nombre)).ToArray();
        }

        public ProgramaEstudio[] GetActiveProgramaEstudios()
        {
            return ((List<ProgramaEstudio>) OrderCatalog<ProgramaEstudio>(x => x.Nombre, true)).ToArray();
        }

        public void SaveProgramaEstudio(ProgramaEstudio programaEstudio)
        {
            if (programaEstudio.Id == 0)
            {
                programaEstudio.Activo = true;
                programaEstudio.CreadorEl = DateTime.Now;
            }
            programaEstudio.ModificadoEl = DateTime.Now;

            programaEstudioRepository.SaveOrUpdate(programaEstudio);
        }

        public Sector GetSectorById(int id)
        {
            return sectorRepository.Get(id);
        }

        public Sector[] GetAllSectores()
        {
            return ((List<Sector>) OrderCatalog<Sector>(x => x.Nombre)).ToArray();
        }

        public Sector[] GetActiveSectores()
        {
            return ((List<Sector>) OrderCatalog<Sector>(x => x.Nombre, true)).ToArray();
        }

        public void SaveSector(Sector sector)
        {
            if (sector.Id == 0)
            {
                sector.Activo = true;
                sector.CreadorEl = DateTime.Now;
            }
            sector.ModificadoEl = DateTime.Now;

            sectorRepository.SaveOrUpdate(sector);
        }

        public Nivel GetNivelById(int id)
        {
            return nivelRepository.Get(id);
        }

        public Nivel[] GetAllNiveles()
        {
            return ((List<Nivel>) OrderCatalog<Nivel>(x => x.Nombre)).ToArray();
        }

        public Nivel[] GetActiveNiveles()
        {
            return ((List<Nivel>) OrderCatalog<Nivel>(x => x.Nombre, true)).ToArray();
        }

        public void SaveNivel(Nivel nivel)
        {
            if (nivel.Id == 0)
            {
                nivel.Activo = true;
                nivel.CreadorEl = DateTime.Now;
            }
            nivel.ModificadoEl = DateTime.Now;

            nivelRepository.SaveOrUpdate(nivel);
        }

        public Organizacion GetOrganizacionById(int id)
        {
            return organizacionRepository.Get(id);
        }

        public Organizacion[] GetAllOrganizaciones()
        {
            return ((List<Organizacion>) OrderCatalog<Organizacion>(x => x.Nombre)).ToArray();
        }

        public Organizacion[] GetActiveOrganizaciones()
        {
            return ((List<Organizacion>) OrderCatalog<Organizacion>(x => x.Nombre, true)).ToArray();
        }

        public void SaveOrganizacion(Organizacion organizacion)
        {
            if (organizacion.Id == 0)
            {
                organizacion.Activo = true;
                organizacion.CreadorEl = DateTime.Now;
            }
            organizacion.ModificadoEl = DateTime.Now;

            organizacionRepository.SaveOrUpdate(organizacion);
        }

        public Dependencia GetDependenciaById(int id)
        {
            return dependenciaRepository.Get(id);
        }

        public Dependencia[] GetAllDependencias()
        {
            return ((List<Dependencia>) OrderCatalog<Dependencia>(x => x.Nombre)).ToArray();
        }

        public Dependencia[] GetActiveDependencias()
        {
            return ((List<Dependencia>) OrderCatalog<Dependencia>(x => x.Nombre, true)).ToArray();
        }

        public void SaveDependencia(Dependencia dependencia)
        {
            if (dependencia.Id == 0)
            {
                dependencia.Activo = true;
                dependencia.CreadorEl = DateTime.Now;
            }
            dependencia.ModificadoEl = DateTime.Now;

            dependenciaRepository.SaveOrUpdate(dependencia);
        }

        public Ambito GetAmbitoById(int id)
        {
            return ambitoRepository.Get(id);
        }

        public Ambito[] GetAllAmbitos()
        {
            return ((List<Ambito>) OrderCatalog<Ambito>(x => x.Nombre)).ToArray();
        }

        public Ambito[] GetActiveAmbitos()
        {
            return ((List<Ambito>) OrderCatalog<Ambito>(x => x.Nombre, true)).ToArray();
        }

        public void SaveAmbito(Ambito ambito)
        {
            if (ambito.Id == 0)
            {
                ambito.Activo = true;
                ambito.CreadorEl = DateTime.Now;
            }
            ambito.ModificadoEl = DateTime.Now;

            ambitoRepository.SaveOrUpdate(ambito);
        }

        public EstadoPais GetEstadoPaisById(int id)
        {
            return estadoPaisRepository.Get(id);
        }

        public EstadoPais[] GetAllEstadoPaises()
        {
            return ((List<EstadoPais>) OrderCatalog<EstadoPais>(x => x.Nombre)).ToArray();
        }

        public EstadoPais[] GetActiveEstadoPaises()
        {
            return ((List<EstadoPais>) OrderCatalog<EstadoPais>(x => x.Nombre, true)).ToArray();
        }

        public void SaveEstadoPais(EstadoPais estadoPais)
        {
            if (estadoPais.Id == 0)
            {
                estadoPais.Activo = true;
                estadoPais.CreadorEl = DateTime.Now;
            }
            estadoPais.ModificadoEl = DateTime.Now;

            estadoPaisRepository.SaveOrUpdate(estadoPais);
        }

        public Genero GetGeneroById(int id)
        {
            return generoRepository.Get(id);
        }

        public Genero[] GetAllGeneros()
        {
            return ((List<Genero>) OrderCatalog<Genero>(x => x.Nombre)).ToArray();
        }

        public Genero[] GetActiveGeneros()
        {
            return ((List<Genero>) OrderCatalog<Genero>(x => x.Nombre, true)).ToArray();
        }

        public void SaveGenero(Genero genero)
        {
            if (genero.Id == 0)
            {
                genero.Activo = true;
                genero.CreadorEl = DateTime.Now;
            }
            genero.ModificadoEl = DateTime.Now;

            generoRepository.SaveOrUpdate(genero);
        }

        public MedioElectronico GetMedioElectronicoById(int id)
        {
            return medioElectronicoRepository.Get(id);
        }

        public MedioElectronico[] GetAllMedioElectronicos()
        {
            return ((List<MedioElectronico>) OrderCatalog<MedioElectronico>(x => x.Nombre)).ToArray();
        }

        public MedioElectronico[] GetActiveMedioElectronicos()
        {
            return ((List<MedioElectronico>) OrderCatalog<MedioElectronico>(x => x.Nombre, true)).ToArray();
        }

        public void SaveMedioElectronico(MedioElectronico medioElectronico)
        {
            if (medioElectronico.Id == 0)
            {
                medioElectronico.Activo = true;
                medioElectronico.CreadorEl = DateTime.Now;
            }
            medioElectronico.ModificadoEl = DateTime.Now;

            medioElectronicoRepository.SaveOrUpdate(medioElectronico);
        }

        public MedioImpreso GetMedioImpresoById(int id)
        {
            return medioImpresoRepository.Get(id);
        }

        public MedioImpreso[] GetAllMedioImpresos()
        {
            return ((List<MedioImpreso>) OrderCatalog<MedioImpreso>(x => x.Nombre)).ToArray();
        }

        public MedioImpreso[] GetActiveMedioImpresos()
        {
            return ((List<MedioImpreso>) OrderCatalog<MedioImpreso>(x => x.Nombre, true)).ToArray();
        }

        public void SaveMedioImpreso(MedioImpreso medioImpreso)
        {
            if (medioImpreso.Id == 0)
            {
                medioImpreso.Activo = true;
                medioImpreso.CreadorEl = DateTime.Now;
            }
            medioImpreso.ModificadoEl = DateTime.Now;

            medioImpresoRepository.SaveOrUpdate(medioImpreso);
        }

        public OtraParticipacion GetOtraParticipacionById(int id)
        {
            return otraParticipacionRepository.Get(id);
        }

        public OtraParticipacion[] GetAllOtraParticipaciones()
        {
            return ((List<OtraParticipacion>) OrderCatalog<OtraParticipacion>(x => x.Nombre)).ToArray();
        }

        public OtraParticipacion[] GetActiveOtraParticipaciones()
        {
            return ((List<OtraParticipacion>) OrderCatalog<OtraParticipacion>(x => x.Nombre, true)).ToArray();
        }

        public void SaveOtraParticipacion(OtraParticipacion otraParticipacion)
        {
            if (otraParticipacion.Id == 0)
            {
                otraParticipacion.Activo = true;
                otraParticipacion.CreadorEl = DateTime.Now;
            }
            otraParticipacion.ModificadoEl = DateTime.Now;

            otraParticipacionRepository.SaveOrUpdate(otraParticipacion);
        }

        public Proyecto GetProyectoById(int id)
        {
            return proyectoRepository.Get(id);
        }

        public Proyecto[] GetAllProyectos()
        {
            return ((List<Proyecto>) OrderCatalog<Proyecto>(x => x.Nombre)).ToArray();
        }

        public Proyecto[] GetActiveProyectos()
        {
            return ((List<Proyecto>) OrderCatalog<Proyecto>(x => x.Nombre, true)).ToArray();
        }

        public void SaveProyecto(Proyecto proyecto)
        {
            if (proyecto.Id == 0)
            {
                proyecto.Activo = true;
                proyecto.CreadorEl = DateTime.Now;
            }
            proyecto.ModificadoEl = DateTime.Now;

            proyectoRepository.SaveOrUpdate(proyecto);
        }

        public TipoDictamen GetTipoDictamenById(int id)
        {
            return tipoDictamenRepository.Get(id);
        }

        public TipoDictamen[] GetAllTipoDictamenes()
        {
            return ((List<TipoDictamen>) OrderCatalog<TipoDictamen>(x => x.Nombre)).ToArray();
        }

        public TipoDictamen[] GetActiveTipoDictamenes()
        {
            return ((List<TipoDictamen>) OrderCatalog<TipoDictamen>(x => x.Nombre, true)).ToArray();
        }

        public void SaveTipoDictamen(TipoDictamen tipoDictamen)
        {
            if (tipoDictamen.Id == 0)
            {
                tipoDictamen.Activo = true;
                tipoDictamen.CreadorEl = DateTime.Now;
            }
            tipoDictamen.ModificadoEl = DateTime.Now;

            tipoDictamenRepository.SaveOrUpdate(tipoDictamen);
        }

        public TipoDistincion GetTipoDistincionById(int id)
        {
            return tipoDistincionRepository.Get(id);
        }

        public TipoDistincion[] GetAllTipoDistinciones()
        {
            return ((List<TipoDistincion>) OrderCatalog<TipoDistincion>(x => x.Nombre)).ToArray();
        }

        public TipoDistincion[] GetActiveTipoDistinciones()
        {
            return ((List<TipoDistincion>) OrderCatalog<TipoDistincion>(x => x.Nombre, true)).ToArray();
        }

        public void SaveTipoDistincion(TipoDistincion tipoDistincion)
        {
            if (tipoDistincion.Id == 0)
            {
                tipoDistincion.Activo = true;
                tipoDistincion.CreadorEl = DateTime.Now;
            }
            tipoDistincion.ModificadoEl = DateTime.Now;

            tipoDistincionRepository.SaveOrUpdate(tipoDistincion);
        }

        public TipoEvento GetTipoEventoById(int id)
        {
            return tipoEventoRepository.Get(id);
        }

        public TipoEvento[] GetAllTipoEventos()
        {
            return ((List<TipoEvento>) OrderCatalog<TipoEvento>(x => x.Nombre)).ToArray();
        }

        public TipoEvento[] GetActiveTipoEventos()
        {
            return ((List<TipoEvento>) OrderCatalog<TipoEvento>(x => x.Nombre, true)).ToArray();
        }

        public void SaveTipoEvento(TipoEvento tipoEvento)
        {
            if (tipoEvento.Id == 0)
            {
                tipoEvento.Activo = true;
                tipoEvento.CreadorEl = DateTime.Now;
            }
            tipoEvento.ModificadoEl = DateTime.Now;

            tipoEventoRepository.SaveOrUpdate(tipoEvento);
        }

        public TipoFinanciamiento GetTipoFinanciamientoById(int id)
        {
            return tipoFinanciamientoRepository.Get(id);
        }

        public TipoFinanciamiento[] GetAllTipoFinanciamientos()
        {
            return ((List<TipoFinanciamiento>) OrderCatalog<TipoFinanciamiento>(x => x.Nombre)).ToArray();
        }

        public TipoFinanciamiento[] GetActiveTipoFinanciamientos()
        {
            return ((List<TipoFinanciamiento>) OrderCatalog<TipoFinanciamiento>(x => x.Nombre, true)).ToArray();
        }

        public void SaveTipoFinanciamiento(TipoFinanciamiento tipoFinanciamiento)
        {
            if (tipoFinanciamiento.Id == 0)
            {
                tipoFinanciamiento.Activo = true;
                tipoFinanciamiento.CreadorEl = DateTime.Now;
            }
            tipoFinanciamiento.ModificadoEl = DateTime.Now;

            tipoFinanciamientoRepository.SaveOrUpdate(tipoFinanciamiento);
        }

        public TipoOrgano GetTipoOrganoById(int id)
        {
            return tipoOrganoRepository.Get(id);
        }

        public TipoOrgano[] GetAllTipoOrganos()
        {
            return ((List<TipoOrgano>) OrderCatalog<TipoOrgano>(x => x.Nombre)).ToArray();
        }

        public TipoOrgano[] GetActiveTipoOrganos()
        {
            return ((List<TipoOrgano>) OrderCatalog<TipoOrgano>(x => x.Nombre, true)).ToArray();
        }

        public void SaveTipoOrgano(TipoOrgano tipoOrgano)
        {
            if (tipoOrgano.Id == 0)
            {
                tipoOrgano.Activo = true;
                tipoOrgano.CreadorEl = DateTime.Now;
            }
            tipoOrgano.ModificadoEl = DateTime.Now;

            tipoOrganoRepository.SaveOrUpdate(tipoOrgano);
        }

        public TipoPresentacion GetTipoPresentacionById(int id)
        {
            return tipoPresentacionRepository.Get(id);
        }

        public TipoPresentacion[] GetAllTipoPresentaciones()
        {
            return ((List<TipoPresentacion>) OrderCatalog<TipoPresentacion>(x => x.Nombre)).ToArray();
        }

        public TipoPresentacion[] GetActiveTipoPresentaciones()
        {
            return ((List<TipoPresentacion>) OrderCatalog<TipoPresentacion>(x => x.Nombre, true)).ToArray();
        }

        public void SaveTipoPresentacion(TipoPresentacion tipoPresentacion)
        {
            if (tipoPresentacion.Id == 0)
            {
                tipoPresentacion.Activo = true;
                tipoPresentacion.CreadorEl = DateTime.Now;
            }
            tipoPresentacion.ModificadoEl = DateTime.Now;

            tipoPresentacionRepository.SaveOrUpdate(tipoPresentacion);
        }

        public TipoReporte GetTipoReporteById(int id)
        {
            return tipoReporteRepository.Get(id);
        }

        public TipoReporte[] GetAllTipoReportes()
        {
            return ((List<TipoReporte>) OrderCatalog<TipoReporte>(x => x.Nombre)).ToArray();
        }

        public TipoReporte[] GetActiveTipoReportes()
        {
            return ((List<TipoReporte>) OrderCatalog<TipoReporte>(x => x.Nombre, true)).ToArray();
        }

        public void SaveTipoReporte(TipoReporte tipoReporte)
        {
            if (tipoReporte.Id == 0)
            {
                tipoReporte.Activo = true;
                tipoReporte.CreadorEl = DateTime.Now;
            }
            tipoReporte.ModificadoEl = DateTime.Now;

            tipoReporteRepository.SaveOrUpdate(tipoReporte);
        }

        public EstadoProducto GetEstadoProductoById(int id)
        {
            return estadoProductoRepository.Get(id);
        }

        public EstadoProducto[] GetAllEstadoProductos()
        {
            return ((List<EstadoProducto>) OrderCatalog<EstadoProducto>(x => x.Nombre)).ToArray();
        }

        public EstadoProducto[] GetActiveEstadoProductos()
        {
            return ((List<EstadoProducto>) OrderCatalog<EstadoProducto>(x => x.Nombre, true)).ToArray();
        }

        public void SaveEstadoProducto(EstadoProducto estadoProducto)
        {
            if (estadoProducto.Id == 0)
            {
                estadoProducto.Activo = true;
                estadoProducto.CreadorEl = DateTime.Now;
            }
            estadoProducto.ModificadoEl = DateTime.Now;

            estadoProductoRepository.SaveOrUpdate(estadoProducto);
        }

        public NivelEstudio GetNivelEstudioById(int id)
        {
            return nivelEstudioRepository.Get(id);
        }

        public NivelEstudio[] GetAllNivelEstudios()
        {
            return ((List<NivelEstudio>) OrderCatalog<NivelEstudio>(x => x.Nombre)).ToArray();
        }

        public NivelEstudio[] GetActiveNivelEstudios()
        {
            return ((List<NivelEstudio>) OrderCatalog<NivelEstudio>(x => x.Nombre, true)).ToArray();
        }

        public void SaveNivelEstudio(NivelEstudio nivelEstudio)
        {
            if (nivelEstudio.Id == 0)
            {
                nivelEstudio.Activo = true;
                nivelEstudio.CreadorEl = DateTime.Now;
            }
            nivelEstudio.ModificadoEl = DateTime.Now;

            nivelEstudioRepository.SaveOrUpdate(nivelEstudio);
        }

        public TipoPublicacion GetTipoPublicacionById(int id)
        {
            return tipoPublicacionRepository.Get(id);
        }

        public TipoPublicacion[] GetAllTipoPublicacions()
        {
            return ((List<TipoPublicacion>) OrderCatalog<TipoPublicacion>(x => x.Nombre)).ToArray();
        }

        public TipoPublicacion[] GetActiveTipoPublicacions()
        {
            return ((List<TipoPublicacion>) OrderCatalog<TipoPublicacion>(x => x.Nombre, true)).ToArray();
        }

        public void SaveTipoPublicacion(TipoPublicacion tipoPublicacion)
        {
            if (tipoPublicacion.Id == 0)
            {
                tipoPublicacion.Activo = true;
                tipoPublicacion.CreadorEl = DateTime.Now;
            }
            tipoPublicacion.ModificadoEl = DateTime.Now;

            tipoPublicacionRepository.SaveOrUpdate(tipoPublicacion);
        }

        public TipoProyecto GetTipoProyectoById(int id)
        {
            return tipoProyectoRepository.Get(id);
        }

        public TipoProyecto[] GetAllTipoProyectos()
        {
            return ((List<TipoProyecto>) OrderCatalog<TipoProyecto>(x => x.Nombre)).ToArray();
        }

        public TipoProyecto[] GetActiveTipoProyectos()
        {
            return ((List<TipoProyecto>) OrderCatalog<TipoProyecto>(x => x.Nombre, true)).ToArray();
        }

        public void SaveTipoProyecto(TipoProyecto tipoProyecto)
        {
            if (tipoProyecto.Id == 0)
            {
                tipoProyecto.Activo = true;
                tipoProyecto.CreadorEl = DateTime.Now;
            }
            tipoProyecto.ModificadoEl = DateTime.Now;

            tipoProyectoRepository.SaveOrUpdate(tipoProyecto);
        }

        public TipoInstitucion GetTipoInstitucionById(int id)
        {
            return tipoInstitucionRepository.Get(id);
        }

        public TipoInstitucion[] GetAllTipoInstituciones()
        {
            return ((List<TipoInstitucion>) OrderCatalog<TipoInstitucion>(x => x.Nombre)).ToArray();
        }

        public TipoInstitucion[] GetActiveTipoInstituciones()
        {
            return ((List<TipoInstitucion>) OrderCatalog<TipoInstitucion>(x => x.Nombre, true)).ToArray();
        }

        public void SaveTipoInstitucion(TipoInstitucion tipoInstitucion)
        {
            if (tipoInstitucion.Id == 0)
            {
                tipoInstitucion.Activo = true;
                tipoInstitucion.CreadorEl = DateTime.Now;
            }
            tipoInstitucion.ModificadoEl = DateTime.Now;

            tipoInstitucionRepository.SaveOrUpdate(tipoInstitucion);
        }

        public TipoEstancia GetTipoEstanciaById(int id)
        {
            return tipoEstanciaRepository.Get(id);
        }

        public TipoEstancia[] GetAllTipoEstancias()
        {
            return ((List<TipoEstancia>) OrderCatalog<TipoEstancia>(x => x.Nombre)).ToArray();
        }

        public TipoEstancia[] GetActiveTipoEstancias()
        {
            return ((List<TipoEstancia>) OrderCatalog<TipoEstancia>(x => x.Nombre, true)).ToArray();
        }

        public void SaveTipoEstancia(TipoEstancia tipoEstancia)
        {
            if (tipoEstancia.Id == 0)
            {
                tipoEstancia.Activo = true;
                tipoEstancia.CreadorEl = DateTime.Now;
            }
            tipoEstancia.ModificadoEl = DateTime.Now;

            tipoEstanciaRepository.SaveOrUpdate(tipoEstancia);
        }

        public Convenio GetConvenioById(int id)
        {
            return convenioRepository.Get(id);
        }

        public Convenio[] GetAllConvenios()
        {
            return ((List<Convenio>) OrderCatalog<Convenio>(x => x.Nombre)).ToArray();
        }

        public Convenio[] GetActiveConvenios()
        {
            return ((List<Convenio>) OrderCatalog<Convenio>(x => x.Nombre, true)).ToArray();
        }

        public void SaveConvenio(Convenio convenio)
        {
            if (convenio.Id == 0)
            {
                convenio.Activo = true;
                convenio.CreadorEl = DateTime.Now;
            }
            convenio.ModificadoEl = DateTime.Now;

            convenioRepository.SaveOrUpdate(convenio);
        }

        public IdentificadorLibro GetIdentificadorLibroById(int id)
        {
            return identificadorLibroRepository.Get(id);
        }

        public IdentificadorLibro[] GetAllIdentificadorLibros()
        {
            return ((List<IdentificadorLibro>) OrderCatalog<IdentificadorLibro>(x => x.Nombre)).ToArray();
        }

        public IdentificadorLibro[] GetActiveIdentificadorLibros()
        {
            return ((List<IdentificadorLibro>) OrderCatalog<IdentificadorLibro>(x => x.Nombre, true)).ToArray();
        }

        public void SaveIdentificadorLibro(IdentificadorLibro identificadorLibro)
        {
            if (identificadorLibro.Id == 0)
            {
                identificadorLibro.Activo = true;
                identificadorLibro.CreadorEl = DateTime.Now;
            }
            identificadorLibro.ModificadoEl = DateTime.Now;

            identificadorLibroRepository.SaveOrUpdate(identificadorLibro);
        }

        public ProductoDerivado GetProductoDerivadoById(int id)
        {
            return productoDerivadoRepository.Get(id);
        }

        public ProductoDerivado[] GetAllProductoDerivados()
        {
            return ((List<ProductoDerivado>) OrderCatalog<ProductoDerivado>(x => x.Nombre)).ToArray();
        }

        public ProductoDerivado[] GetActiveProductoDerivados()
        {
            return ((List<ProductoDerivado>) OrderCatalog<ProductoDerivado>(x => x.Nombre, true)).ToArray();
        }

        public void SaveProductoDerivado(ProductoDerivado productoDerivado)
        {
            if (productoDerivado.Id == 0)
            {
                productoDerivado.Activo = true;
                productoDerivado.CreadorEl = DateTime.Now;
            }
            productoDerivado.ModificadoEl = DateTime.Now;

            productoDerivadoRepository.SaveOrUpdate(productoDerivado);
        }

        public TipoResena GetTipoResenaById(int id)
        {
            return tipoResenaRepository.Get(id);
        }

        public TipoResena[] GetAllTipoResenas()
        {
            return ((List<TipoResena>)OrderCatalog<TipoResena>(x => x.Nombre)).ToArray();
        }

        public TipoResena[] GetActiveTipoResenas()
        {
            return ((List<TipoResena>)OrderCatalog<TipoResena>(x => x.Nombre, true)).ToArray();
        }

        public void SaveTipoResena(TipoResena tipoResena)
        {
            if (tipoResena.Id == 0)
            {
                tipoResena.Activo = true;
                tipoResena.CreadorEl = DateTime.Now;
            }
            tipoResena.ModificadoEl = DateTime.Now;

            tipoResenaRepository.SaveOrUpdate(tipoResena);
        }

        public TipoApoyo GetTipoApoyoById(int id)
        {
            return tipoApoyoRepository.Get(id);
        }

        public TipoApoyo[] GetAllTipoApoyos()
        {
            return ((List<TipoApoyo>) OrderCatalog<TipoApoyo>(x => x.Nombre)).ToArray();
        }

        public TipoApoyo[] GetActiveTipoApoyos()
        {
            return ((List<TipoApoyo>)OrderCatalog<TipoApoyo>(x => x.Nombre, true)).ToArray();
        }

        public void SaveTipoApoyo(TipoApoyo tipoApoyo)
        {
            if (tipoApoyo.Id == 0)
            {
                tipoApoyo.Activo = true;
                tipoApoyo.CreadorEl = DateTime.Now;
            }
            tipoApoyo.ModificadoEl = DateTime.Now;

            tipoApoyoRepository.SaveOrUpdate(tipoApoyo);
        }

        public SubprogramaConacyt GetSubprogramaConacytById(int id)
        {
            return subprogramaConacytRepository.Get(id);
        }

        public SubprogramaConacyt[] GetAllSubprogramasConacyt()
        {
            return ((List<SubprogramaConacyt>) OrderCatalog<SubprogramaConacyt>(x => x.Nombre)).ToArray();
        }

        public SubprogramaConacyt[] GetActiveSubprogramasConacyt()
        {
            return ((List<SubprogramaConacyt>) OrderCatalog<SubprogramaConacyt>(x => x.Nombre, true)).ToArray();
        }

        public void SaveSubprogramaConacyt(SubprogramaConacyt subprogramaConacyt)
        {
            if (subprogramaConacyt.Id == 0)
            {
                subprogramaConacyt.Activo = true;
                subprogramaConacyt.CreadorEl = DateTime.Now;
            }
            subprogramaConacyt.ModificadoEl = DateTime.Now;

            subprogramaConacytRepository.SaveOrUpdate(subprogramaConacyt);
        }

        public Rama GetRamaById(int id)
        {
            return ramaRepository.Get(id);
        }

        public Rama[] GetAllRamas()
        {
            return ((List<Rama>) OrderCatalog<Rama>(x => x.Nombre)).ToArray();
        }

        public Rama[] GetActiveRamas()
        {
            return ((List<Rama>)OrderCatalog<Rama>(x => x.Nombre, true)).ToArray();
        }

        public void SaveRama(Rama rama)
        {
            if (rama.Id == 0)
            {
                rama.Activo = true;
                rama.CreadorEl = DateTime.Now;
            }
            rama.ModificadoEl = DateTime.Now;

            ramaRepository.SaveOrUpdate(rama);
        }

        public Clase GetClaseById(int id)
        {
            return claseRepository.Get(id);
        }

        public Clase[] GetAllClases()
        {
            return ((List<Clase>) OrderCatalog<Clase>(x => x.Nombre)).ToArray();
        }

        public Clase[] GetActiveClases()
        {
            return ((List<Clase>) OrderCatalog<Clase>(x => x.Nombre, true)).ToArray();
        }

        public void SaveClase(Clase clase)
        {
            if (clase.Id == 0)
            {
                clase.Activo = true;
                clase.CreadorEl = DateTime.Now;
            }
            clase.ModificadoEl = DateTime.Now;

            claseRepository.SaveOrUpdate(clase);
        }
    }
}
