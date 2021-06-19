using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Grupo14.Entidades
{
	public class Sede
	{
		//1 .. * composicion 
		private List<HorarioSede> horarioSede;
		// 0 a .. * composicion 
		private List<Tarifa>  tarifa;
		//  0 a .. * composicion
		private List<Exposicion> _exposicion;
		//  1 a .. * composicion
		private List<Planta>planta;
		//  0 a .. * composicion
		//private List<Coleccion> coleccion;
		private Deposito deposito;	

		// private List<Empleado>ººººººººººººººººººººººº empleadoCreo
		private int cantMaxVisitantes;
		private int cantMaxPorGuia;
		private string nombre;




		public Sede(int cantMaxVisitantes, int cantMaxPorGuia, string nombre, Deposito deposito)
		{
			this.cantMaxVisitantes = cantMaxVisitantes;
			this.cantMaxPorGuia = cantMaxPorGuia;
			this.nombre = nombre;
			//this.deposito = deposito;
		}

		public Sede()
		{

		}

		//public Deposito Deposito
		//{
		//	get => deposito;
		//	set => deposito = value;
		//}

		public string Nombre
		{
			get => nombre;
			set => nombre = value;
		}
		public int CantMaxVisitantes
		{
			get => cantMaxVisitantes;
			set => cantMaxVisitantes = value;
		}
		public int CantMaxPorGuia
		{
			get => cantMaxPorGuia;
			set => cantMaxPorGuia = value;
		}

		public void AgregarExposicion(Exposicion nuevaExposicion)
		{
			_exposicion.Add(nuevaExposicion);
		}
		//metodo para asegurar el encapsulamiento 
		public IReadOnlyCollection<Exposicion> Exposiciones
		{
			get
			{
				return _exposicion.AsReadOnly();
			}
		}
	}
}
