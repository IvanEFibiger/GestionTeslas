namespace FINALV1
{
    /// <summary>
    /// Clase principal del vehículo.
    /// </summary>
    public abstract class Vehiculo
    {
        /// <summary>
        /// Obtiene o establece el modelo del vehículo.
        /// </summary>
        public string Modelo { get; set; }

        /// <summary>
        /// Obtiene o establece el año del vehículo.
        /// </summary>
        public int Año { get; set; }

        /// <summary>
        /// Obtiene o establece el color del vehículo.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Obtiene o establece el propietario del vehículo.
        /// </summary>
        public string Propietario { get; set; }

        /// <summary>
        /// Obtiene o establece el nivel de combustible actual del vehículo.
        /// </summary>
        public double CombustibleActual { get; set; }

        /// <summary>
        /// Obtiene o establece la autonomía del vehículo.
        /// </summary>
        public double Autonomia { get; set; }

        /// <summary>
        /// Constructor de la clase Vehiculo.
        /// </summary>
        /// <param name="modelo">El modelo del vehículo.</param>
        /// <param name="año">El año del vehículo.</param>
        /// <param name="color">El color del vehículo.</param>
        /// <param name="propietario">El propietario del vehículo.</param>
        /// <param name="combustibleActual">El nivel de combustible actual del vehículo.</param>
        /// <param name="autonomia">La autonomía del vehículo.</param>
        protected Vehiculo(string modelo, int año, string color, string propietario, double combustibleActual, double autonomia)
        {
            Modelo = modelo;
            Año = año;
            Autonomia = autonomia;
            Color = color;
            Propietario = propietario;
            CombustibleActual = combustibleActual;
        }
    }

    // Clase para los vehículos de Tesla
    public class Tesla : Vehiculo
    {
        public double Servicio { get; set; }
        public double KilometrajeActual { get; set; } // Nueva propiedad agregada

        public Tesla(string modelo, int año, double kilometrajeActual, string color, string propietario, double servicio, double combustibleActual, double autonomia)
            : base(modelo, año, color, propietario, combustibleActual, autonomia)
        {
            Servicio = servicio;
            KilometrajeActual = kilometrajeActual;
        }
    }

    // Clase para los vehículos de SpaceX
    public class SpaceX : Vehiculo
    {
        public double Servicio { get; set; }
        public double HsVuelo { get; set; } // Nueva propiedad agregada

        public SpaceX(string modelo, int año, double hsVuelo, string color, string propietario, double servicio, double combustibleActual, double autonomia)
            : base(modelo, año, color, propietario, combustibleActual, autonomia)
        {
            Servicio = servicio;
            HsVuelo = hsVuelo;
        }
    }

    // Clase para el modelo de Tesla: ModeloX
    public class ModeloX : Tesla
    {
        public ModeloX(string modelo, int año, double kilometrajeActual, string color, string propietario, double servicio, double combustibleActual, double autonomia)
            : base(modelo, año, kilometrajeActual, color, propietario, servicio, combustibleActual, autonomia)
        {
            Modelo = "X"; // Asignar el modelo específico
            Autonomia = 560; // Establecer la autonomía específica
            Servicio = 1000; // Establecer el servicio específico
        }
    }

    // Clase para el modelo de Tesla: ModeloS
    public class ModeloS : Tesla
    {
        public ModeloS(string modelo, int año, double kilometrajeActual, string color, string propietario, double servicio, double combustibleActual, double autonomia)
            : base(modelo, año, kilometrajeActual, color, propietario, servicio, combustibleActual, autonomia)
        {
            Modelo = "S"; // Asignar el modelo específico
            Autonomia = 650; // Establecer la autonomía específica
            Servicio = 2000; // Establecer el servicio específico
        }
    }

    // Clase para el modelo de Tesla: Cybertruck
    public class Cybertruck : Tesla
    {
        public Cybertruck(string modelo, int año, double kilometrajeActual, string color, string propietario, double servicio, double combustibleActual, double autonomia)
            : base(modelo, año, kilometrajeActual, color, propietario, servicio, combustibleActual, autonomia)
        {
            Modelo = "CYBERTRUCK"; // Asignar el modelo específico
            Autonomia = 800; // Establecer la autonomía específica
            Servicio = 3000; // Establecer el servicio específico
        }
    }

    // Clase para el modelo de SpaceX: Starship
    public class Starship : SpaceX
    {
        public Starship(string modelo, int año, double hsVuelo, string color, string propietario, double servicio, double combustibleActual, double autonomia)
            : base(modelo, año, hsVuelo, color, propietario, servicio, combustibleActual, autonomia)
        {
            Modelo = "STARSHIP"; // Asignar el modelo específico
            Autonomia = 500; // Establecer la autonomía específica
            Servicio = 1000; // Establecer el servicio específico
        }
    }

    // Clase para el modelo de SpaceX: Falcon9
    public class Falcon9 : SpaceX
    {
        public Falcon9(string modelo, int año, double hsVuelo, string color, string propietario, double servicio, double combustibleActual, double autonomia)
            : base(modelo, año, hsVuelo, color, propietario, servicio, combustibleActual, autonomia)
        {
            Modelo = "FALCON 9"; // Asignar el modelo específico
            Autonomia = 200; // Establecer la autonomía específica
            Servicio = 400; // Establecer el servicio específico
        }
    }
}
