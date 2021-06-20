using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Grupo14.Entidades
{
    public class Exposicion
    {
        private List<PublicoDestino> publicosDestino;
        private string nombre;

        //private List<DetalleExposicion> _detalleExposicion;
        //private DateTime fechaFin;
        //private DateTime fechaFinReplanificada;
        //private DateTime fechaInicio;
        //private DateTime fechaInicioReplanificada;
        private DateTime horaApertura;
        private DateTime horaCierre;
        //private TipoExposicion tipoExposicion;
        //private Empleado empleadoCreo;
        ////falta constructor.

        //public Exposicion(string nombre)
        //{
        //	this.nombre = nombre;
        //	this.AgregarDetalleExposicion = _detalleExposicion;
        //}

        public Exposicion()
        {

        }

        //public TipoExposicion TipoExposicion
        //{
        //	get => tipoExposicion;
        //	set => tipoExposicion = value;
        //}

        public DateTime HoraCierre
        {
        	get => horaCierre;
        	set => horaCierre = value;
        }

        public DateTime HoraApertura
        {
        	get => horaApertura;
       	    set => horaApertura = value;
        }


        //public DateTime FechaInicioReplanificada
        //{
        //	get => fechaInicioReplanificada;
        //	set => fechaInicioReplanificada = value;
        //}

        //public DateTime FechaInicio
        //{
        //	get => fechaInicio;
        //	set => fechaInicio = value;
        //}

        public string Nombre
        {
        	get => nombre;
        	set => nombre = value; 
        }

        public List<PublicoDestino> PublicosDestino
        {
            get => publicosDestino;
            set => publicosDestino = value;
        }

        //public DateTime FechaFin
        //{
        //	get => fechaFin;
        //	set => fechaFin = value;
        //}
        //public DateTime FechaFinReplanificada
        //{
        //	get => fechaFinReplanificada;
        //	set => fechaFinReplanificada = value;
        //}

        //public void AgregarDetalleExposicion(DetalleExposicion nuevoDetalle)
        //{
        //	_detalleExposicion.Add(nuevoDetalle);
        //}

        ////metodo para asegurar el encapsulamiento 
        //public IReadOnlyCollection<DetalleExposicion> DetalleExposiciones
        //{
        //	get
        //	{
        //		return _detalleExposicion.AsReadOnly();
        //	}
        //}
    }
}
