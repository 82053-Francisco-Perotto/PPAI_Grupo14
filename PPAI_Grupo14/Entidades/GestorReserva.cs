using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Grupo14.Entidades
{
	public class GestorReserva
	{
		private int cantidadVisitantes;
		private Escuela escuela;
		private List<Exposicion> exposicionesSeleccionadas;
		private int aux;
		private List<Empleado> guiasSeleccionados;
		private Sede sedeSeleccionada;

		public GestorReserva()
		{

		}

		public void AgregarEmpleado(Empleado nuevoEmpleado)
		{
			guiasSeleccionados.Add(nuevoEmpleado);
		}
		//metodo para asegurar el encapsulamiento 
		public IReadOnlyCollection<Empleado> GuiasSeleccionados
		{
			get
			{
				return guiasSeleccionados.AsReadOnly();
			}
		}
		public void AgregarExposicion(Exposicion nuevaExposicion)
		{
			exposicionesSeleccionadas.Add(nuevaExposicion);
		}
		//metodo para asegurar el encapsulamiento 
		public IReadOnlyCollection<Exposicion> ExposicionesSeleccionadas
		{
			get
			{
				return exposicionesSeleccionadas.AsReadOnly();
			}
		}
		public Escuela EscuelaSeleccionada
		{
			get => escuela;
			set => escuela = value;
		}
		public Sede SedeSeleccionada
		{
			get => sedeSeleccionada;
			set => sedeSeleccionada = value;
		}
		public int CantidadVisitantes
		{
			get => cantidadVisitantes;
			set => cantidadVisitantes = value;
		}

	}
}
