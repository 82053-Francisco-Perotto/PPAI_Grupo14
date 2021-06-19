using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Grupo14.Entidades
{
	public class Sesion
	{
		private DateTime fechaFin;
		private DateTime fechaInicio;
		private DateTime horaInicio;
		private DateTime horaFin;
		private Usuario usuario;

		public Sesion(DateTime fechaFin, DateTime fechaInicio, DateTime horaInicio, DateTime horaFin, Usuario usuario)
		{
		this.fechaFin = fechaFin;
		this.fechaInicio = fechaInicio;
		this.horaInicio = horaInicio;
		this.horaFin = horaFin;
		this.usuario = usuario;
		}
		public Sesion() { }
	}
}
