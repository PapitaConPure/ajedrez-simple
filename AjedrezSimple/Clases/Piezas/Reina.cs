namespace AjedrezSimple {
	public class Reina: Pieza {
		public Reina(int x, int y, ColorPieza color, Ajedrez juego) : base(x, y, color, juego) {
			this.Ícono = "♛";
			this.Nombre = "Reina";
		}

		public override bool ConfirmarMover(Movimiento movimiento) {
			if(movimiento.EsCero)
				return false;

			if(!movimiento.EsOrtogonal && !movimiento.EsDiagonal)
				return false;

			return this.AnalizarCamino(movimiento);
		}
	}
}