using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Grupo14.Entidades
{
	public class DetalleExposicion
	{
		private string lugarAsignado;

		private Obra obra;

		public DetalleExposicion(string lugarAsignado, Obra obra)
		{
			this.lugarAsignado = lugarAsignado;
			this.obra = obra;

		}
		public string LugarAsignado
		{
			get => lugarAsignado;
			set => lugarAsignado = value;
		}

		public Obra Obra
        {
			get => obra;
			set => obra = value;
        }
	}
}
