namespace AjedrezSimple {
	public class Alfil: Pieza {
		public Alfil(int x, int y, ColorPieza color, Ajedrez juego) : base(x, y, color, juego) {
			this.Ícono = "♝";
			this.Nombre = "Alfil";
		}

		public override bool ConfirmarMover(Movimiento movimiento) {
			if(movimiento.EsCero)
				return false;

			if(!movimiento.EsDiagonal)
				return false;

			return this.AnalizarCamino(movimiento);
		}
	}
}
