using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Grupo14.Entidades
{
	public class Usuario
	{
		private int caducidad;
		private string nombre;
		private string contraseña;

		//private Empleado empleado;

		public Usuario(int caducidad, string nombre, string contraseña)
		{
			this.caducidad = caducidad;
			this.nombre = nombre;
			this.contraseña = contraseña;
			//this.empleado = empleado;
		}
	}
}
