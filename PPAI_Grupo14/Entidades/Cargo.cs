using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Grupo14.Entidades
{
	public class Cargo
	{
		private string nombre;
		private string descripcion;
		private int codigoValidacion;
		private int cuit;
		private string dni;
		private DateTime fechaIngreso;
		private DateTime fechaNacimiento;
		private string domicilio; // deberia ser calle y nroCalle
		private int sexo;
		private string telefono;

		public Cargo(int codigoValidacion, string telefono, int sexo, int cuit, string nombre, string descripcion, string domicilio, DateTime fechaIngreso, DateTime fechaNacimiento)
		{
			this.nombre = nombre;
			this.descripcion = descripcion;
			this.domicilio = domicilio;
			this.sexo = sexo;
			this.cuit = cuit;
			this.telefono = telefono;
			this.codigoValidacion = codigoValidacion;
			this.fechaIngreso = fechaIngreso;
			this.fechaNacimiento = fechaNacimiento;
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

		public string Domicilio
		{
			get => domicilio;
			set => domicilio = value;
		}

		public DateTime FechaNacimiento
		{
			get => fechaNacimiento;
			set => fechaNacimiento = value;
		}

		public DateTime FechaIngreso
		{
			get => fechaIngreso;
			set => fechaIngreso = value;
		}

		public string Telefono
		{
			get => telefono;
			set => telefono = value;
		}

		public int CodigoValidacion
		{
			get => codigoValidacion;
			set => codigoValidacion = value;
		}

		public int Cuit
		{
			get => cuit;
			set => cuit = value;
		}

		public Cargo()
		{

		}
		

		

		

		public int Sexo
		{
			get => sexo;
			set => sexo = value;
		}
	}
}
