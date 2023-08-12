using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FINALV1
{
    /// <summary>
    /// Clase para el sistema de gestión.
    /// </summary>
    public class SistemaGestion
    {
        private List<Tesla> teslas; //lista para almacenar Objetos Teslas(X, S, Cybertruck.)
        private List<SpaceX> spacexs; //lista para almacenar Objetos SpaceX(Starship y Falcon 9.)
        private List<Tesla> teslasEliminados;//lista para almacenar Objetos Teslas eliminados (necesaria para el método eliminar)
        private List<SpaceX> spacexsEliminados; //lista para almacenar Objetos SpaceX eliminados (necesaria para el método eliminar)

        public SistemaGestion()
        {
            teslas = new List<Tesla>();
            spacexs = new List<SpaceX>();
            teslasEliminados = new List<Tesla>();
            spacexsEliminados = new List<SpaceX>();
        }

        /// <summary>
        /// Agrega un vehículo Tesla al sistema.
        /// </summary>
        /// <param name="tesla">El vehículo Tesla a agregar.</param>
        public void AgregarTesla(Tesla tesla)
        {
            teslas.Add(tesla);
        }

        /// <summary>
        /// Agrega un vehículo SpaceX al sistema.
        /// </summary>
        /// <param name="spacex">El vehículo SpaceX a agregar.</param>
        public void AgregarSpaceX(SpaceX spacex)
        {
            spacexs.Add(spacex);
        }

        /// <summary>
        /// Elimina un vehículo Tesla del sistema.
        /// </summary>
        /// <param name="tesla">El vehículo Tesla a eliminar.</param>
        public void EliminarTesla(Tesla tesla)
        {
            teslas.Remove(tesla);
            teslasEliminados.Add(tesla);
        }

        /// <summary>
        /// Elimina un vehículo SpaceX del sistema.
        /// </summary>
        /// <param name="spacex">El vehículo SpaceX a eliminar.</param>
        public void EliminarSpaceX(SpaceX spacex)
        {
            spacexs.Remove(spacex);
            spacexsEliminados.Add(spacex);
        }

        /// <summary>
        /// Verifica si un vehículo Tesla ha sido eliminado del sistema.
        /// </summary>
        /// <param name="tesla">El vehículo Tesla a verificar.</param>
        /// <returns>True si el vehículo Tesla ha sido eliminado, False en caso contrario.</returns>
        public bool TeslaEliminado(Tesla tesla)
        {
            return teslasEliminados.Contains(tesla);
        }

        /// <summary>
        /// Verifica si un vehículo SpaceX ha sido eliminado del sistema.
        /// </summary>
        /// <param name="spacex">El vehículo SpaceX a verificar.</param>
        /// <returns>True si el vehículo SpaceX ha sido eliminado, False en caso contrario.</returns>
        public bool SpaceXEliminado(SpaceX spacex)
        {
            return spacexsEliminados.Contains(spacex);
        }


        /// <summary>
        /// Realiza el escaneo de un vehículo y muestra los detalles de los service realizados.
        /// El mismo devuelve un mensaje con la cantidad de km/hs vuelo recorridos (ingresado por el usuario),
        /// el total de Service realizados,y cuantos chequeos de cada ítem fueron realizados.
        /// En el caso de los vehículos SpaceX se chequea el Sistema de Propulsión y el Sistema de Navegación
        /// ya que son los únicos ítems que especifica hs de vuelo.
        /// </summary>
        /// <param name="vehiculo">Vehículo a escanear.</param>
        public void EscanearVehiculo(Vehiculo vehiculo)
        {
            int serviceCount = 0;
            int checkCount = 0;
            string serviceInfo = "";

            if (vehiculo is Tesla)
            {
                Tesla tesla = (Tesla)vehiculo;
                double kilometraje = tesla.KilometrajeActual;
                double servicioIntervalo = tesla.Servicio;

                serviceCount = (int)(kilometraje / servicioIntervalo);

                // Control Cinturones de Seguridad: cada 1000km
                int controlCinturones = (int)(kilometraje / 1000);
                checkCount += controlCinturones;
                if (controlCinturones > 0 && serviceCount > 0)
                    serviceInfo += "(1) Control Cinturones de Seguridad: " + controlCinturones + "\n";

                // Control de Baterias: cada 2000km
                int controlBaterias = (int)(kilometraje / 2000);
                checkCount += controlBaterias;
                if (controlBaterias > 0 && serviceCount > 0)
                    serviceInfo += "(2) Control de Baterias: " + controlBaterias + "\n";

                // Control del Sistema de Navegacion: 2500km 
                int controlNavegacion = (int)(kilometraje / 2500);
                checkCount += controlNavegacion;
                if (controlNavegacion > 0 && serviceCount > 0)
                    serviceInfo += "(3) Control del Sistema de Navegacion: " + controlNavegacion + "\n";

                // Control del Sistema de Traccion: cada 3000km
                int controlTraccion = (int)(kilometraje / 3000);
                checkCount += controlTraccion;
                if (controlTraccion > 0 && serviceCount > 0)
                    serviceInfo += "(4) Control del Sistema de Traccion: " + controlTraccion + "\n";

                // Control del motor: cada 3000km
                int controlMotor = (int)(kilometraje / 3000);
                checkCount += controlMotor;
                if (controlMotor > 0 && serviceCount > 0)
                    serviceInfo += "(5) Control del motor: " + controlMotor + "\n";

                MessageBox.Show($"Se realizó el escaneo del vehículo Tesla {tesla.Modelo}.\n" +
                                $"Kilometraje: {kilometraje} km\n" +
                                $"Cantidad de servicios realizados: {serviceCount}\n" +
                                $"Detalles de servicios:\n{serviceInfo}");
            }
            else if (vehiculo is SpaceX)
            {
                SpaceX spacex = (SpaceX)vehiculo;
                double horasVuelo = spacex.HsVuelo;
                double servicioIntervalo = spacex.Servicio;

                serviceCount = (int)(horasVuelo / servicioIntervalo);

                // Control del Sistema de Propulsion: cada 1000Hs
                int controlPropulsion = (int)(servicioIntervalo / 1000);
                checkCount += controlPropulsion;
                if (controlPropulsion > 0 && serviceCount > 0)
                    serviceInfo += "(1) Control del Sistema de Propulsion: " + controlPropulsion + "\n";

                // Control del Sistema de Navegacion: 500Hs
                int controlNavegacion = (int)(horasVuelo / 500);
                checkCount += controlNavegacion;
                if (controlNavegacion > 0 && serviceCount > 0)
                    serviceInfo += "(2) Control del Sistema de Navegacion: " + controlNavegacion + "\n";

                MessageBox.Show($"Se realizó el escaneo del vehículo SpaceX {spacex.Modelo}.\n" +
                                $"Horas de vuelo: {horasVuelo} hs\n" +
                                $"Cantidad de servicios realizados: {serviceCount}\n" +
                                $"Detalles de servicios:\n{serviceInfo}");
            }
            else
            {
                MessageBox.Show("No se puede escanear el vehículo. Tipo de vehículo no válido.");
            }
        }

        /// <summary>
        /// Obtiene la carga de baterías de un vehículo Tesla, se calculan los ciclos (100%) de batería completados según
        /// el kilometraje que posea el vehículo y sobre el excendente se calcula cuanta batería le queda a esa carga.
        /// </summary>
        /// <param name="tesla">El vehículo Tesla.</param>
        /// <returns>La carga de baterías en porcentaje.</returns>
        public double ObtenerCargaBaterias(Tesla tesla)
        {
            double cantKms = tesla.KilometrajeActual;
            double autonomia = tesla.Autonomia;
            double cargaBateria;

            if (cantKms <= autonomia)
            {
                cargaBateria = 100.0 - (cantKms / autonomia) * 100.0;
            }
            else
            {
                double ciclosCompletos = Math.Floor(cantKms / autonomia);
                double distanciaRestante = cantKms % autonomia;
                cargaBateria = 100.0 - (distanciaRestante / autonomia) * 100.0;
            }

            cargaBateria = Math.Max(0.0, cargaBateria);
            cargaBateria = Math.Min(100.0, cargaBateria);

            cargaBateria = Math.Round(cargaBateria, 2);

            tesla.CombustibleActual = cargaBateria;

            return cargaBateria;
        }

        /// <summary>
        /// Obtiene la carga de combustible de un vehículo SpaceX. Al igual que en la versión Tesla se calculan los ciclos 
        /// (100%) de carga completa de combustible completados según las Hs de vuelo
        /// que posea el vehículo y sobre el excendente se calcula qué porcentaje de combustible le queda a esa carga.
        /// </summary>
        /// <param name="spacex">El vehículo SpaceX.</param>
        /// <returns>La carga de combustible en porcentaje.</returns>
        public double ObtenerCargaCombustible(SpaceX spacex)
        {
            double hsVuelo = spacex.HsVuelo;
            double autonomia = spacex.Autonomia;
            double cargaCombustible;

            if (hsVuelo <= autonomia)
            {
                cargaCombustible = 100.0 - (hsVuelo / autonomia) * 100.0;
            }
            else
            {
                double ciclosCompletos = Math.Floor(hsVuelo / autonomia);
                double distanciaRestante = hsVuelo % autonomia;
                cargaCombustible = 100.0 - (distanciaRestante / autonomia) * 100.0;
            }
            cargaCombustible = Math.Max(0.0, cargaCombustible);
            cargaCombustible = Math.Min(100.0, cargaCombustible);

            cargaCombustible = Math.Round(cargaCombustible, 2);

            spacex.CombustibleActual = cargaCombustible;

            return cargaCombustible;

        }

        /// <summary>
        /// Obtiene una lista de todos los vehículos Tesla en el sistema.
        /// </summary>
        /// <returns>La lista de vehículos Tesla.</returns>
        public List<Tesla> ObtenerTeslas()
        {
            return teslas;
        }

        /// <summary>
        /// Obtiene una lista de todos los vehículos SpaceX en el sistema.
        /// </summary>
        /// <returns>La lista de vehículos SpaceX.</returns>
        public List<SpaceX> ObtenerSpaceXs()
        {
            return spacexs;
        }
    }
}
