using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Grupo14.Entidades
{

	// Tarifa 
	public class Tarifa
	{
		private DateTime fechaFinVigencia;
		private DateTime fechaInicioVigencia;
		private int monto;
		private int montoAdicionalGuia;

		public TipoDeEntrada tipoDeEntrada;
		public TipoVisita tipoVisita;


		public Tarifa()
		{

		}
		public Tarifa(DateTime fechaFinVigencia, DateTime fechaInicioVigencia, int monto, int montoAdicionalGuia)
		{
			this.fechaFinVigencia = fechaFinVigencia;
			this.fechaInicioVigencia = fechaInicioVigencia;
			this.monto = monto;
			this.montoAdicionalGuia = montoAdicionalGuia;
			// falta conocer las clases 
		}
		public int Monto
		{
			get => monto;
			set => monto = value;
		}
		public int MontoAdicionalGuia
		{
			get => montoAdicionalGuia;
			set => montoAdicionalGuia = value;
		}
		public DateTime FechaInicioVigencia
		{
			get => fechaInicioVigencia;
			set => fechaInicioVigencia = value;
		}
		public DateTime FechaFinVigencia
		{
			get => fechaFinVigencia;
			set => fechaFinVigencia = value;

		}
	}
}
