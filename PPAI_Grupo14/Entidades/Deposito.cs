using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Grupo14.Entidades
{

	public class Deposito
	{
		// denominacion puede ser int ?  
		private string denominacion;
		private int numero;
		private SectorDeposito sectorDeposito;

		public Deposito()
		{

		}

		public Deposito(string denominacion, int numero)
		{
			this.denominacion = denominacion;
			this.numero = numero;
		}

		public string Denominacion
		{
			get => denominacion;
			set => denominacion = value;
		}
		public int Numero
		{
			get => numero;
			set => numero = value;
		}
	}

}
