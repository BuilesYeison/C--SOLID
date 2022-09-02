using CoreSolid.Interfaces;

namespace CoreSolid.Entidades
{
    ///Principio de segregación de interfaces: El escudo es considerado un item, pero no todos
    //los items cubren del daño, así que se crea una nueva interface para los items que sean armaduras
    //protejan del daño. De esta forma no tenemos que implementar en todos los tipo items metodos o     
    //propiedades innecesarias
    public class Escudo : Item, IArmadura, IItem
    {
        public Escudo(string nombre, TiposItem tipo, decimal precio) : base(nombre, tipo, precio)
        {
        }

        public void BloquearDaño(int daño){
            Console.WriteLine("Daño bloqueado");
        }

        
        public override string ConsultarPrecioItem(){
            return $"El escudo {this.Nombre} de tipo {this.Tipo}, tiene un precio de {this.Precio}";
        }

        ///Principio abierto-cerrado: Esta clase extiende de una clase padre llamada item que ya
        //establece por defecto un metodo para cambiar el tipo del item
        //pero para los escudos quiero un comportamiento diferente del metodo, entonces cambio como se 
        //comporta este metodo en la subclase escudo pero en la clase padre Item sigue siendo cerrado
        //a modificaciones
        public override void CambiarTipo(TiposItem tipo)
        {
            Console.WriteLine("El escudo subió de nivel y por tanto su tipo");
            this.Tipo=tipo;
        }
    }
}