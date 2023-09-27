namespace AjedrezSimple {
	public sealed class NoPieza: Pieza {
		public NoPieza(int x, int y): base(x, y, ColorPieza.Ninguno, null) {
			this.Letra = ' ';
			this.Ícono = this.Nombre = "";
		}
		public NoPieza() : base(0, 0, ColorPieza.Ninguno, null) {
			this.Ícono = this.Nombre = "";
		}

		public override Pieza[] PasosVálidos {
			get {
				return new Pieza[0];
			}
		}

		public override bool PuedeMover(Movimiento m) {
			return false;
		}

		public override string ToString() {
			return "[No Es Pieza]";
		}
	}
}
