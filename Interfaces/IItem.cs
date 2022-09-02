using CoreSolid.Entidades;

namespace CoreSolid.Interfaces{
    public interface IItem : IObjetoBase{
        decimal Precio{get;set;}
        TiposItem Tipo{get;set;}
        string ConsultarPrecioItem();
        void CambiarTipo(TiposItem tipo);
    }
}