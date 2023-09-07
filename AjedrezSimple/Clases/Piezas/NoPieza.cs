namespace AjedrezSimple {
	public class NoPieza: Pieza {
		public NoPieza(int x, int y): base(x, y, ColorPieza.Ninguna, null) {
			this.Ícono = this.Nombre = "";
		}
		public NoPieza() : base(0, 0, ColorPieza.Ninguna, null) {
			this.Ícono = this.Nombre = "";
		}

		public override bool PuedeMover(Movimiento m) {
			return false;
		}

		public override string ToString() {
			return "[No Es Pieza]";
		}
	}
}
