using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Grupo14.Entidades
{
	public class SectorDeposito
	{
		private string nombre;

		public SectorDeposito()
		{

		}
		public SectorDeposito(string nombre)
		{
			this.nombre = nombre;
		}
		public string Nombre
		{
			get => nombre;
			set => nombre = value;
		}

	}

}
