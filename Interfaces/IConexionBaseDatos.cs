using CoreSolid.Entidades;

namespace CoreSolid.Interfaces
{
    ///Inversión de dependencias: independientemente de la base de datos que se use se debe adaptar
    ///a esta interfáz para que el sistema se adapte y no toque cambiar todo el sistema de guardado a db
    public interface IConexionBaseDatos
    {
         object ObtenerInformacion(string conexion, string tabla);
         void GuardarInformacion(string conexion, string tabla, object objGuardar);
    }
}