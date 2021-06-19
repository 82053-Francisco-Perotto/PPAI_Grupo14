using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Grupo14.Entidades
{

	// planta 
	public class Planta
	{
		private int numero;
		//private Sala sala;
		//private Archivo archivo;

		public Planta(int numero)
		{
			this.numero = numero;
		}
		public int Numero
		{
			get => numero;
			set => numero = value;
		}
		public Planta() { }

	}

}
