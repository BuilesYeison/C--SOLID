using CoreSolid.Interfaces;

namespace CoreSolid.Entidades
{
    ///Principio de segregación de interfaces: La espada es considerada un item, pero no todos
    //los items hacen daño, así que se crea una nueva interface para los items que sean armas y hagan
    //daño. De esta forma no tenemos que implementar en todos los tipo items metodos o propiedades
    //innecesarias
    public class Espada : Item , IArma, IItem
    {
        public Espada(string nombre, TiposItem tipo, decimal precio) : base(nombre, tipo, precio)
        {
        }

        public void HacerDaño(int daño){
            Console.WriteLine("Daño hecho");
        }

        ///Principio de substitución de Liskov: Cuando necesite consultar el precio de este item, no
        //es necesario verificar el tipo de objeto para obtener su metodo que me retorne el precio.
        //como este metodo es heredado, lo implemento en esta subclase y así sin tener que verificar
        //el objeto me traerá el precio del item. Por lo que la superclase substituye la subclase
        public override string ConsultarPrecioItem(){
            return $"La espada {this.Nombre} de tipo {this.Tipo}, tiene un precio de {this.Precio}";
        }

        ///Principio abierto-cerrado: Esta clase extiende de una clase padre llamada item que ya
        //establece por defecto un metodo para cambiar el tipo del item
        //pero para las espadas quiero un comportamiento diferente del metodo, entonces cambio como se 
        //comporta este metodo en la subclase espada pero en la clase padre Item sigue siendo cerrado
        //a modificaciones
        public override void CambiarTipo(TiposItem tipo)
        {
            Console.WriteLine("La espada subió de nivel y por tanto su tipo");
            this.Tipo=tipo;
        }
    }
}