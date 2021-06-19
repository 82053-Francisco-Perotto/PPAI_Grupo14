using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Grupo14.Entidades
{
	public class Empleado
	{
		private string apellido;
		private string nombre;
		private string mail;
		private string codigoValidacion;
		private string domicilio;
		private DateTime fechaIngreso;
		private DateTime fechaNacimiento;
		private int sexo;
		private string telefono;
		private Cargo cargo;
		private List<HorarioEmpleado> _horarioEmpleado;

		public Empleado()
		{

		}
		public Empleado(string apellido, string nombre, string mail, string telefono, int sexo, DateTime fechaIngreso, DateTime fechaNacimiento, Cargo cargo)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			this.mail = mail;
			this.telefono = telefono;
			this.sexo = sexo;
			this.fechaIngreso = fechaIngreso;
			this.fechaNacimiento = fechaNacimiento;
			this.codigoValidacion = codigoValidacion;
			this.domicilio = domicilio;
			this.cargo = cargo;
		}
		//faltan algunos set/get  
		public string Nombre
		{
			get => nombre;
			set => nombre = value;
		}
		public string Apellido
		{
			get => apellido;
			set => apellido = value;
		}
		public string Mail
		{
			get => mail;
			set => mail = value;
		}

		public void AgregarHorario(HorarioEmpleado nuevoHorario)
		{
			_horarioEmpleado.Add(nuevoHorario);
		}
		//metodo para asegurar el encapsulamiento 
		public IReadOnlyCollection<HorarioEmpleado> Horarios
		{
			get
			{
				return _horarioEmpleado.AsReadOnly();
			}
		}
	}
}
