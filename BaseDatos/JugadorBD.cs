using CoreSolid.Entidades;
using CoreSolid.Interfaces;

namespace CoreSolid.BaseDatos{
    ///Principio de responsabilidad unica: las interacciones de los objetos jugador con base de datos
    ///han sido separadas de su clase principal, ya que la clase sirve unicamente de modelo para la creación
    ///del objeto y esa debe ser su unica responsabilidad
    public static class JugadorBD{
        /// Crear jugador en base de datos
        public static void CrearJugador(Jugador jugador, IConexionBaseDatos conexionBaseDatos){
            conexionBaseDatos.GuardarInformacion("sqlCOnexión","Jugadores",jugador);
            Console.WriteLine($"Jugador: {jugador.Nombre} ha sido creado");
        }
        /// Obtener jugadores de base de datos, Inversión de dependencias
        public static object ObtenerJugadores(IConexionBaseDatos conexionBaseDatos){
            var jugadores = 
            conexionBaseDatos.ObtenerInformacion("SqlConexión","Jugadores");

            return jugadores;            
        }
    }
}