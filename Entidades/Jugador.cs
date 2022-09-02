namespace CoreSolid.Entidades{
    public class Jugador:ObjetoBase{
        public int Nivel { get; set; } = 0;
        public List<Item> Inventario { get; set; } = new List<Item>();

        public Jugador(string nombre) : base(nombre)
        {
        }
        public void ActualizarNivel(int nivel){
            this.Nivel += nivel;
        }
    }
}