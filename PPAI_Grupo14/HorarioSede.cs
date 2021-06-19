using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Grupo14.Entidades
{

	// horarioSede 
	public class HorarioSede
	{
		private DateTime horaApertura;
		private DateTime horaCierre;
		// 1.. * agregacion 
		private DiaSemana[] diaSemana;

		public HorarioSede(DateTime horaApertura,DateTime horaCierre, DiaSemana diaSemana)
		{

			if (diaSemana == null)
				throw new Exception("Debe selecionar un dia de semana para el horarioSede");
			this.horaApertura = horaApertura;
			this.horaCierre = horaCierre;
			this.diaSemana = new DiaSemana[7];

		}
		public HorarioSede()
		{

		}
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
		public void agregarDiaSemana(DiaSemana nuevoDiaSemana)
		{

		}
	}
 
}
