using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Grupo14.Entidades
{
	//publicoDestino 
	public class PublicoDestino
	{
		private string nombre;
		private string caracteristicas;

		public PublicoDestino(string nombre,string  caracteristicas)
		{
			this.nombre = nombre;
			this.caracteristicas = caracteristicas;

		}
		public PublicoDestino()
		{

		}
		public string Nombre
		{
			get => nombre;
			set => nombre = value;
		}
		public string Caracteristicas
		{
			get => caracteristicas;
			set => caracteristicas = value;
		}

	}

}
