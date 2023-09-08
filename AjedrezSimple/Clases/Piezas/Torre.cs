namespace AjedrezSimple {
	public class Torre: Pieza {
		public Torre(int x, int y, ColorPieza color, Ajedrez juego) : base(x, y, color, juego) {
			this.Ícono = "♜";
			this.Nombre = "Torre";
			this.SeHaMovido = false;
		}

		public bool SeHaMovido { get; private set; }

		public override bool ConfirmarMover(Movimiento movimiento) {
			if(movimiento.EsCero)
				return false;

			if(!movimiento.EsOrtogonal)
				return false;

			bool seMovió = this.AnalizarCamino(movimiento);
			this.SeHaMovido |= seMovió;
			return seMovió;
		}

		internal bool ConcluirEnroque(int destinoX, out int distancia) {
			Movimiento movimiento = new Movimiento(this.x, this.y, destinoX, this.y);
			distancia = movimiento.DiferenciaX;

			if(!(this.juego[destinoX, this.y] is NoPieza))
				return false;

			if(!this.ConfirmarMover(movimiento))
				return false;

			this.x = destinoX;
			return true;
		}
	}
}
