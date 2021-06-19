using PPAI_Grupo14.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Grupo14
{
    public class Obra
{
	private int alto;
	private int ancho;
	private int codigoSensor;
	private string descripcion;
	private DateTime duracionEstimada;
	private DateTime duracionResumida;
	private DateTime fechaCreacion;
	private DateTime fechaPrimerIngreso;
	private string nombre;
	private float  peso;
	private int valuacion;
	private Empleado empleadoCreo;
	
	public Obra(int alto,int ancho,int codigoSensor,string descripcion,DateTime duracionEstimada,DateTime duracionResumida,string nombre,float peso,int valuacion) 
	{
		this.alto = alto;
		this.ancho = ancho;
		this.codigoSensor = codigoSensor;
		this.descripcion = descripcion ;
		this.duracionEstimada = duracionEstimada;
		this.duracionResumida  = duracionResumida;
		this.fechaCreacion = fechaCreacion;
		this.fechaPrimerIngreso = fechaPrimerIngreso;
		this.nombre = nombre;
		this.peso = peso;
		this.valuacion = valuacion;
		
	}
	public Obra(){}
	//falta constructores 
}
}
