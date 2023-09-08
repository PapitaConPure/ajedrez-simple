namespace AjedrezSimple {
	public class Rey: Pieza {
		public Rey(int x, int y, ColorPieza color, Ajedrez juego) : base(x, y, color, juego) {
			this.Ícono = "♚";
			this.Nombre = "Rey";
			this.HaMovido = false;
		}

		public bool HaMovido { get; private set; }

		public override bool ConfirmarMover(Movimiento movimiento) {
			if(movimiento.EsCero || movimiento.Magnitud > 1)
				return false;

			bool seMovió = this.AnalizarDestino(movimiento);
			this.HaMovido |= seMovió;
			return seMovió;
		}
	}
}