namespace AjedrezSimple {
	public class Torre: Pieza {
		public Torre(int x, int y, ColorPieza color, Ajedrez juego) : base(x, y, color, juego) {
			this.Ícono = "♜";
			this.Nombre = "Torre";
			this.HaMovido = false;
		}

		public bool HaMovido { get; private set; }

		public override bool ConfirmarMover(Movimiento movimiento) {
			if(movimiento.EsCero)
				return false;

			if(!movimiento.EsOrtogonal)
				return false;

			bool seMovió = this.AnalizarCamino(movimiento);
			this.HaMovido |= seMovió;
			return seMovió;
		}
	}
}
