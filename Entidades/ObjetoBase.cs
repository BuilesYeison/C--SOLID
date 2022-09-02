using CoreSolid.Interfaces;

namespace CoreSolid.Entidades
{
    public abstract class ObjetoBase : IObjetoBase
    {
        public string UniqueId { get; set; } = Guid.NewGuid().ToString();
        public string Nombre { get; set; }

        public ObjetoBase(string nombre)
        {
            this.Nombre = nombre;
        }
    }
}