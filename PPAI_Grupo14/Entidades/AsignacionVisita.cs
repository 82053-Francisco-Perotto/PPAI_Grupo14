using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Grupo14.Entidades
{
	public class AsignacionVisita
	{
		private DateTime fechaHoraInicio;
		private DateTime fechaHoraFin;
		private Empleado guiaAsignado;

		public AsignacionVisita(DateTime fechaHoraInicio, DateTime fechaHoraFin, Empleado empleado)
		{
			this.fechaHoraInicio = fechaHoraInicio;
			this.fechaHoraFin = fechaHoraFin;
			this.guiaAsignado = empleado;
		}
		public DateTime FechaHoraInicio
		{
			get => fechaHoraInicio;
			set => fechaHoraInicio = value;
		}
		public DateTime FechaHoraFin
		{
			get => fechaHoraFin;
			set => fechaHoraFin = value;
		}

		public Empleado GuiaAsignado
        {
			get => guiaAsignado;
			set => guiaAsignado = value;
        }
	}
}
