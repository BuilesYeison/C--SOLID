using CoreSolid.Interfaces;

namespace CoreSolid.BaseDatos
{
    public class SqlDataBase: IConexionBaseDatos
    {
        public object ObtenerInformacion(string conexion, string tabla){
            Console.WriteLine("Consultando en sql");
            List<string> cosas = new List<string>();
            return cosas;
        }

        public void GuardarInformacion(string conexion, string tabla, object objGuardar){
            Console.WriteLine($"Guardando en sql {objGuardar}");
        }
    }
}