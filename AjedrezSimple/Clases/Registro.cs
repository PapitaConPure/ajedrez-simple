namespace AjedrezSimple {
	public class Registro {
		public Registro(Pieza emisora, Movimiento movimiento, Ajedrez juego) {
			this.Emisora = emisora;
			this.OrigenX = emisora.X;
			this.OrigenY = emisora.Y;
			this.Movimiento = movimiento;
			this.HayAmbiguedad = false;
			this.DesambiguableX = true;
			this.DesambiguableY = true;

			foreach(Pieza pieza in juego.Piezas) {
				if(pieza == emisora || pieza.Color != emisora.Color || pieza.GetType() != emisora.GetType())
					continue;

				if(!pieza.PuedeMover(new Movimiento(pieza.X, pieza.Y, this.Movimiento.DestinoX, this.Movimiento.DestinoY)))
					continue;

				this.HayAmbiguedad = true;

				if(pieza.X == emisora.X)
					this.DesambiguableX = false;

				if(pieza.Y == emisora.Y)
					this.DesambiguableY = false;
			}
		}

		public Pieza Emisora { get; private set; }

		public int OrigenX { get; private set; }

		public int OrigenY { get; private set; }

		public Movimiento Movimiento { get; private set; }

		public bool HayAmbiguedad { get; private set; }

		public bool DesambiguableX { get; private set; }

		public bool DesambiguableY { get; private set; }

		public Pieza Captura {
			get { return this.Movimiento.Captura; }
		}

		public Pieza Promoción {
			get { return this.Movimiento.Promoción; }
		}

		public Movimiento.TipoEnroque Enroque {
			get { return this.Movimiento.Enroque; }
		}

		public bool EnPassant {
			get { return this.Movimiento.EnPassant; }
		}
		public Pieza.ColorPieza Turno {
			get { return this.Emisora.Color; }
		}

		public string Notación() {
			string ret = this.Emisora.Ícono;

			if(this.HayAmbiguedad) {
				string notaciónOrigen = Pieza.ANotación(this.OrigenX, this.OrigenY);
				if(this.DesambiguableX)
					ret += notaciónOrigen[0];
				else if(this.DesambiguableY)
					ret += notaciónOrigen[1];
				else
					ret += notaciónOrigen;
			}

			if(!(this.Captura is NoPieza))
				ret += "x";

			ret += Pieza.ANotación(this.Movimiento.DestinoX, this.Movimiento.DestinoY);

			if(this.EnPassant)
				ret += " e.p";

			return ret;
		}

		public override string ToString() {
			return this.Notación();
		}
	}
}
