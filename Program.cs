using System;
using CoreSolid.BaseDatos;
using CoreSolid.Entidades;

namespace CoreSolid{
    ///Proyecto donde se evidencian todos los principios SOLID
    //Principio de responsabilidad unica en la clase 'JugadorBD.cs'
    //Principio de substitución de Liskov: en este archivo
    //Principio abierto/cerrado y segregación de interfaces: Entidad Espada.cs, Escudo.cs
    //Principio de inversión de dependencias: Interfáz IConexionBaseDatos, Clases MongoDataBase, SqlDataBase, JugadorBD, este archivo 
    class Program{
        private static void Main(string[] args)
        {
            Jugador jugadorNovato = new Jugador(nombre:"Yeison");
            jugadorNovato.Inventario.AddRange(new List<Item>(){
                new Escudo("Madera", TiposItem.Común,250),
                new Escudo("Platino", TiposItem.Raro,2050),
                new Espada("Amanecer",TiposItem.Epico,12500),
                new Espada("Piedra",TiposItem.Común,250)
            });         

            ///Principio de substitución de Liskov: Cuando necesite consultar el precio de este item, no
            //es necesario verificar el tipo de objeto para obtener su metodo que me retorne el precio.
            //como este metodo es heredado, lo implemento en cada subclase y así sin tener que verificar
            //el objeto me traerá el precio del item. Por lo que la superclase substituye la subclase
            foreach(Item item in jugadorNovato.Inventario){
                Console.WriteLine(item.ConsultarPrecioItem());                
            }

            ///Inversión de dependencias: independientemente del tipo de base de datos que se usa
            //el sistema se adapta para evitar grandes cambios en el código
            SqlDataBase baseDatos = new SqlDataBase();//MongoDataBase baseDatos = new MongoDataBase();
            Console.WriteLine(JugadorBD.ObtenerJugadores(baseDatos));
        }        
    }
}

