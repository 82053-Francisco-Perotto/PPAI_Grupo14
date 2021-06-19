using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Grupo14.Entidades
{
	//tipo de visita 
	public class TipoVisita
	{
		private string nombre;

		public TipoVisita(string nombre)
		{
			this.nombre = nombre;
		}
		public TipoVisita()
		{

		}
		public string Nombre
		{
			get => nombre;
			set => nombre = value;
		}

	}

}
