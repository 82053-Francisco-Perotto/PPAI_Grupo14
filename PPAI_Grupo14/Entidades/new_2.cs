
//CARGO 
public class Cargo()
{
	private string nombre;
	private string descripcion;
	private int codigoValidacion;
	private int cuit;
	private string dni;
	private datetime fechaIngreso;
	private datetime fechaNacimiento;
	private string domicilio; // deberia ser calle y nroCalle
	private int sexo;
	private string telefono;
	
	public string Domicilio
	{
		get => domicilio;
		set => domicilio = value;
	}
	public datetime FechaNacimiento
    {
            get => fechaNacimiento;
            set => fechaNacimiento = value;
    }
	public datetime FechaIngreso
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
	public int cuit
	{
	        get => cuit;
            set => cuit = value;
    }
	public string Domicilio
	{
	        get => domicilio;
            set => domicilio = value;
    }
	public Cargo()
	{
		
	}
	public Cargo(int codigoValidacion,string telefono, int sexo,int cuit,string nombre,string descripcion,string domicilio,datetime fechaIngreso,datetime fechaNacimiento)
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
	
	public int Sexo
	{
	        get => sexo;
            set => sexo = value;
    }
}

//Horario Empleado
public class HorarioEmpleado
{
	private DateTime horaIngreso;
	private DateTime horaSalida;
	public HorarioEmpleado(DateTime horaIngreso,DateTime horaSalida)
	{
		this.horaIngreso = horaIngreso;
		this.horaSalida = horaSalida;
	}
}


public class AsignacionVisita
{
	private DateTime fechaHoraInicio;
	private DateTime fechaHoraFin;
	private Empleado guiaAsignado;
	
	public AsignacionVisita(DateTime fechaHoraInicio,DateTime fechaHoraFin,Empleado empleado)
	{
		this.fechaHoraInicio = fechaHoraInicio;
		this.fechaHoraFin = fechaHoraFin;
		this.guiaAsignado = empleado;		
	}
	public DateTime FechaHoraInicio
	{   get => fechaHoraInicio;
        set => fechaHoraInicio = value;    		
	}
	public DateTime FechaHoraFin
	{   get => fechaHoraFin;
        set => fechaHoraFin = value;    		
	}
	
}

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

public class Sesion
{
	private DateTime fechaFin;
	private DateTime fechaInicio;
	private DateTime horaInicio;
	private DateTime horaFin;
	
	private Usuario usuario;
	public Sesion(DateTime fechaFin;DateTime fechaInicio;DateTime horaInicio;DateTime horaFin, Usuario usuario)
	{
		this.fechaFin = fechaFin;
		this.fechaHoraInicio = fechaHoraInicio;
		this.horaInicio = horaInicio;
		this.horaFin = horaFin;
		this.usuario = usuario;
	}
	public Sesion(){}
	
}

public class Usuario
{
	private int caducidad;
	private string nombre;
	private string contraseña;
	
	//private Empleado empleado;
	
	public class Usuario(int caducidad,string nombre,string contraseña)
	{
		this.caducidad = caducidad;
		this.nombre = nombre;
		this.contraseña = contraseña;
		//this.empleado = empleado;
	}
}

public class DetalleExposicion
{
	private string lugarAsignado;
	
	private Obra obra;
	
	public DetalleExposicion(string lugarAsignado,Obra obra)
	{
		this.lugarAsignado;
		this.obra = obra;
		
	}
	public string LugarAsignado
	{
	        get => lugarAsignado;
            set => lugarAsignado = value;
    }
}

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
		guiasSeleccionados.Add( nuevoEmpleado);
	}
	//metodo para asegurar el encapsulamiento 
	public IReadOnlyCollection <Empleado> GuiasSeleccionados
	{
		get
		{
			return guiasSeleccionadoss.AsReadOnly();
		}
	}
	public void AgregarExposicion( Exposicion nuevaExposicion)
	{
		exposicionesSeleccionadas.Add(nuevaExposicion);
	}
	//metodo para asegurar el encapsulamiento 
	public IReadOnlyCollection <Exposicion> ExposicionesSeleccionadas
	{
		get
		{
			return exposicionesSeleccionadas.AsReadOnly();
		}
	}
	public Escuela  EscuelaSeleccionada
	{
	        get => escuela;
            set => escuela = value;
    }
	public Sede  SedeSeleccionada
	{
	        get => sedeSeleccionada;
            set => sedeSeleccionada = value;
    }
	public int  CantidadVisitantes  
	{
	        get => cantidadVisitantes;
            set => cantidadVisitantes = value;
    }
	
}
public class Sede
{
	// 1 .. * composicion 
	//private List<HorarioSede> horarioSede;
	// 0 a .. * composicion 
	//private List<Tarifa>  tarifa;
	//  0 a .. * composicion
	private List<Exposicion> _exposicion;
	//  1 a .. * composicion
	//private List<Planta>planta;
	//  0 a .. * composicion
	//private List<Coleccion> coleccion;
	//private Deposito deposito;	
	
	// private List<Empleado>ººººººººººººººººººººººº empleadoCreo
	private int cantMaxVisitantes;
	private int  cantMaxPorGuia;
	private string nombre;

	
	
	
	public Sede( int cantMaxVisitantes,int cantMaxPorGuia,string nombre,Deposito deposito)
	{
		this.cantMaxVisitantes = cantMaxVisitantes;
		this.cantMaxPorGuia = cantMaxPorGuia;
		this.nombre = nombre;
		this.deposito= deposito;	
	}
	
	public Sede()
	{
		
	}
	
	public Deposito
	{
	        get => nombre;
            set => nombre = value;
    		
	}
	public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
	public  int CantMaxVisitantes
        {
            get => cantMaxVisitantes;
            set => cantMaxVisitantes = value;
        }
	public int CantMaxPorGuia 
        {
            get => cantMaxPorGuia;
            set => cantMaxPorGuia = value;
        }
		
	public void AgregarExposicion( Exposicion nuevaExposicion)
	{
		_exposicion.Add(nuevaExposicion);
	}
	//metodo para asegurar el encapsulamiento 
	public IReadOnlyCollection <Exposicion> Exposiciones
	{
		get
		{
			return _exposicion.AsReadOnly();
		}
	}
}

// Empleado 
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
	public Empleado(string apellido,string nombre,string mail,string telefono,int sexo,DateTime fechaIngreso,DateTime fechaNacimiento,Cargo cargo)
	{
		this.nombre = nombre;
		this.apellido = apellido;
		this.mail = mail ; 
		this.telefono = telefono;
		this.sexo = sexo;
		this.fechaIngreso = fechaIngreso;
		this.fechaNacimiento = fechaNacimiento;
		this.codigoValidacion = codigoValidacion
		this.domicilio = domicilio;
		this.cargo = cargo
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
	public IReadOnlyCollection <HorarioEmpleado> Horarios
	{
		get
		{
			return _horarioEmpleado.AsReadOnly();
		}
	}
}
