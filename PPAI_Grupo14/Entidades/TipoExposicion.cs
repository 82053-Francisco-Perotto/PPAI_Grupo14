using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Grupo14.Entidades
{
	//clase Tipo Exposicion 
	public class TipoExposicion
	{
		private string descripcion;
		private string nombre;

		public TipoExposicion()
		{

		}
		public TipoExposicion(string descripcion, string nombre)
		{
			this.descripcion = descripcion;
			this.nombre = nombre;
		}
		public string Nombre
		{
			get => nombre;
			set => nombre = value;
		}

		public string Descripcion
		{
			get => descripcion;
			set => descripcion = value;
		}

	}

}
