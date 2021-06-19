using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Grupo14
{
	//escuela 
	public class Escuela
	{
		private string mail;
		private string nombre;
		private string telefFijo;
		private string telefCelular;
		private string domicilio;
		// deberia ser calle y nroCalle 

		public Escuela(string mail, string nombre, string telefFijo, string telefCelular, string domicilio)
		{
			this.mail = mail;
			this.nombre = nombre;
			this.telefFijo = telefFijo;
			this.telefCelular = telefCelular;
			this.domicilio = domicilio;
		}
		public Escuela()
		{

		}

		public string Nombre
		{
			//deberia ser mostrarNombre ?
			get => nombre;
			set => nombre = value;
		}

		public string Mail
		{
			get => mail;
			set => mail = value;
		}
		public string TelefFijo
		{
			get => telefFijo;
			set => telefFijo = value;
		}

		public string TelefCelular
		{
			get => telefCelular;
			set => telefCelular = value;
		}

		public string Domicilio
		{
			get => domicilio;
			set => domicilio = value;
		}

	}

}
