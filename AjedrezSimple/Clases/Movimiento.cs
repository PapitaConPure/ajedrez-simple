using System;

namespace AjedrezSimple {
	public class Movimiento {
		private readonly int diferenciaX;
		private readonly int diferenciaY;
		private readonly int destinoX;
		private readonly int destinoY;
		private readonly int distanciaX;
		private readonly int distanciaY;
		public enum TipoEnroque {
			Ninguno = 0,
			Corto = 2,
			Largo = 3,
		}

		public Movimiento(int x, int y, int destinoX, int destinoY) {
			this.diferenciaX = destinoX - x;
			this.diferenciaY = destinoY - y;
			this.destinoX = destinoX;
			this.destinoY = destinoY;
			this.distanciaX = Math.Abs(this.diferenciaX);
			this.distanciaY = Math.Abs(this.diferenciaY);
			this.Captura = this.Promoción = new NoPieza(x, y);
			this.Enroque = TipoEnroque.Ninguno;
			this.EnPassant = false;
		}

		public Pieza Captura { get; set; }

		public Pieza Promoción { get; set; }

		public TipoEnroque Enroque { get; set; }

		public bool EnPassant { get; set; }

		public int DiferenciaX {
			get { return this.diferenciaX; }
		}

		public int DiferenciaY {
			get { return this.diferenciaY; }
		}

		public int DestinoX {
			get { return this.destinoX; }
		}

		public int DestinoY {
			get { return this.destinoY; }
		}

		public int DistanciaX {
			get { return this.distanciaX; }
		}

		public int DistanciaY {
			get { return this.distanciaY; }
		}

		public int Magnitud {
			get { return Math.Max(this.distanciaX, this.distanciaY); }
		}

		public bool EsCero {
			get { return this.diferenciaX == 0 && this.diferenciaY == 0; }
		}

		public bool EsHorizontal {
			get { return this.diferenciaX != 0; }
		}

		public bool EsVertical {
			get { return this.diferenciaY != 0; }
		}

		public bool EsSoloHorizontal {
			get { return this.diferenciaX != 0 && this.diferenciaY == 0; }
		}

		public bool EsSoloVertical {
			get { return this.diferenciaX == 0 && this.diferenciaY != 0; }
		}

		public bool EsOrtogonal {
			get { return this.distanciaX == 0 ^ this.distanciaY == 0; }
		}

		public bool EsDiagonal {
			get { return this.distanciaX == this.distanciaY; }
		}

		public bool EsHaciaDelante(Pieza.ColorPieza color) {
			return this.diferenciaY * this.Dirección(color) > 0;
		}

		public int Dirección(Pieza.ColorPieza color) {
			int dir = 0;

			if(color == Pieza.ColorPieza.Blanco)
				dir = 1;
			if(color == Pieza.ColorPieza.Negro)
				dir = -1;

			return dir;
		}
	}
}