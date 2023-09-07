namespace AjedrezSimple {
	public class Rey: Pieza {
		public Rey(int x, int y, ColorPieza color, Ajedrez juego) : base(x, y, color, juego) {
			this.Ícono = "♚";
			this.Nombre = "Rey";
		}

		public override bool ConfirmarMover(Movimiento movimiento) {
			if(movimiento.EsCero || movimiento.Magnitud > 1)
				return false;

			return this.AnalizarDestino(movimiento);
		}
	}
}