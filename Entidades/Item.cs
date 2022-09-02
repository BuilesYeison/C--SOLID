using CoreSolid.Interfaces;

namespace CoreSolid.Entidades
{
    public abstract class Item : ObjetoBase, IItem
    {        
        public TiposItem Tipo { get; set; }
        public decimal Precio { get; set; }
        protected Item(string nombre,TiposItem tipo, decimal precio) : base(nombre)
        {
            this.Tipo = tipo;
            this.Precio = precio;
        }

        
        public abstract string ConsultarPrecioItem();

        //palabra clave virtual permite que subclases derivada de estas tengan permitido
        //modificar este metodo
        public virtual void CambiarTipo(TiposItem tipo){
            this.Tipo = tipo;
        }
    }
}