namespace AjedrezSimple {
	public class Caballero: Pieza {
		public Caballero(int x, int y, ColorPieza color, Ajedrez juego) : base(x, y, color, juego) {
			this.Ícono = "♞";
			this.Nombre = "Caballero";
		}

		public override bool ConfirmarMover(Movimiento movimiento) {
			if(movimiento.EsCero || movimiento.Magnitud > 2)
				return false;

			if(movimiento.EsOrtogonal || movimiento.EsDiagonal)
				return false;

			return this.AnalizarDestino(movimiento);
		}
	}
}
