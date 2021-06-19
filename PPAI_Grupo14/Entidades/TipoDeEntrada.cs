using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Grupo14
{
	//tipo de entrada 
	public class TipoDeEntrada
	{
		private string nombre;

		public TipoDeEntrada()
		{

		}
		public TipoDeEntrada(string nombre)
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
