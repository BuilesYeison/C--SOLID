using CoreSolid.Interfaces;

namespace CoreSolid.BaseDatos
{
    public class MongoDataBase: IConexionBaseDatos
    {
        public object ObtenerInformacion(string conexion, string tabla){
            Console.WriteLine("Consultando en Mongo");
            List<string> cosas = new List<string>();
            return cosas;
        }

        public void GuardarInformacion(string conexion, string tabla, object objGuardar){
            Console.WriteLine($"Guardando en Mongo {objGuardar}");
        }
    }
}