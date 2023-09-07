namespace AjedrezSimple {
	public class Torre: Pieza {
		public Torre(int x, int y, ColorPieza color, Ajedrez juego) : base(x, y, color, juego) {
			this.Ícono = "♜";
			this.Nombre = "Torre";
		}

		public override bool ConfirmarMover(Movimiento movimiento) {
			if(movimiento.EsCero)
				return false;

			if(!movimiento.EsOrtogonal)
				return false;

			return this.AnalizarCamino(movimiento);
		}
	}
}
