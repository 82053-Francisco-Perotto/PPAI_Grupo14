using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Grupo14.Entidades
{
	public class HorarioEmpleado
	{
		private DateTime horaIngreso;
		private DateTime horaSalida;
		public HorarioEmpleado(DateTime horaIngreso, DateTime horaSalida)
		{
			this.horaIngreso = horaIngreso;
			this.horaSalida = horaSalida;
		}
	}
}
