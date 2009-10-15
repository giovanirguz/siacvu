using System;
using System.Collections.Generic;
using DecisionesInteligentes.Colef.Sia.Core.NHibernateValidator;
using NHibernate.Validator.Constraints;
using SharpArch.Core.DomainModel;
using SharpArch.Core.NHibernateValidator;

namespace DecisionesInteligentes.Colef.Sia.Core
{
    [HasUniqueDomainSignature]
    [ParticipacionMedioValidator]
    public class ParticipacionMedio : Entity, IBaseEntity
    {
        const int tipoProducto = 10; // 10 Representa Participacion Medio

        public ParticipacionMedio()
        {
            ArchivoParticipacionMedios = new List<ArchivoParticipacionMedio>();
            FirmaParticipacionMedios = new List<FirmaParticipacionMedio>();
        }

        public virtual void AddArchivo(Archivo archivo)
        {
            archivo.TipoProducto = tipoProducto;
            ArchivoParticipacionMedios.Add((ArchivoParticipacionMedio) archivo);
        }

        public virtual void AddFirma(Firma firma)
        {
            firma.TipoProducto = tipoProducto;
            FirmaParticipacionMedios.Add((FirmaParticipacionMedio)firma);
        }

        public virtual void DeleteFirma(Firma firma)
        {
            FirmaParticipacionMedios.Remove((FirmaParticipacionMedio)firma);
        }

        public virtual void DeleteArchivo(Archivo archivo)
        {
            ArchivoParticipacionMedios.Remove((ArchivoParticipacionMedio) archivo);
        }

        [Valid]
        public virtual IList<ArchivoParticipacionMedio> ArchivoParticipacionMedios { get; private set; }

        [Valid]
        public virtual IList<FirmaParticipacionMedio> FirmaParticipacionMedios { get; private set; }

		[DomainSignature]
		[NotNullNotEmpty]
		public virtual string Titulo { get; set; }

        [NotNull]
        public virtual Usuario Usuario { get; set; }

        public virtual Departamento Departamento { get; set; }

        public virtual Sede Sede { get; set; }

        public virtual int Puntuacion { get; set; }
		
		public virtual string Nombre { get; set; }

        public virtual string EspecificacionMedioImpreso { get; set; }

        public virtual string EspecificacionMedioElectronico { get; set; }
        
		public virtual MedioImpreso MedioImpreso { get; set; }

		public virtual MedioElectronico MedioElectronico { get; set; }
        
		public virtual Genero Genero { get; set; }

		public virtual string Tema { get; set; }

		public virtual PeriodoReferencia PeriodoReferencia { get; set; }

		public virtual Proyecto Proyecto { get; set; }

        public virtual DirigidoA DirigidoA { get; set; }

		public virtual LineaTematica LineaTematica { get; set; }

		public virtual Ambito Ambito { get; set; }

        public virtual DateTime FechaDifusion { get; set; }

		public virtual Pais Pais { get; set; }

		public virtual EstadoPais EstadoPais { get; set; }

		public virtual string Ciudad { get; set; }

        public virtual string NotaPeriodistica { get; set; }

        public virtual string PalabraClave1 { get; set; }

        public virtual string PalabraClave2 { get; set; }

        public virtual string PalabraClave3 { get; set; }

		public virtual Usuario CreadorPor { get; set; }

		public virtual DateTime CreadorEl { get; set; }

		public virtual Usuario ModificadoPor { get; set; }

		public virtual DateTime ModificadoEl { get; set; }

		public virtual bool Activo { get; set; }
    }
}
