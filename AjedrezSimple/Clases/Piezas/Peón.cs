using System;

namespace AjedrezSimple {
	public class Peón: Pieza {
		public Peón(int x, int y, ColorPieza color, Ajedrez juego): base(x, y, color, juego) {
			this.Ícono = "♙";
			this.Nombre = "Peón";
			this.HizoDobleEncaque = false;
		}

		public bool HizoDobleEncaque { get; set; }

		public bool EnPosiciónInicial {
			get {
				if(this.Color == ColorPieza.Blanco)
					return this.y == 1;
				else
					return this.y == 6;
			}
		}

		public bool EnPosiciónFinal {
			get {
				if(this.Color == ColorPieza.Blanco)
					return this.y == 7;
				else
					return this.y == 0;
			}
		}

		public override bool ConfirmarMover(Movimiento movimiento) {
			if(movimiento.EsSoloHorizontal || !movimiento.EsHaciaDelante(this.Color))
				return false;

			if(movimiento.DistanciaX > 1 || movimiento.DistanciaY > 2)
				return false;

			if(!this.EnPosiciónInicial && movimiento.DistanciaY > 1)
				return false;

			if(movimiento.EsDiagonal) {
				if(movimiento.DistanciaX != 1)
					return false;

				Pieza atacadaDirecta = this.juego[movimiento.DestinoX, movimiento.DestinoY, this.ColorContrario];

				if(!(atacadaDirecta is NoPieza))
					movimiento.Captura = atacadaDirecta;
				else if(!this.ProcesarEnPassant(movimiento))
					return false;
			} else {
				if(this.juego.Colisiones(this.x, this.y, movimiento, true).Length > 0)
					return false;

				this.HizoDobleEncaque = movimiento.DistanciaY == 2;
			}

			return true;
		}

		private bool ProcesarEnPassant(Movimiento movimiento) {
			Pieza pieza = this.juego[movimiento.DestinoX, movimiento.DestinoY - movimiento.Dirección(this.Color), this.ColorContrario];

			if(!(pieza is Peón))
				return false;

			if(!(pieza as Peón).HizoDobleEncaque)
				return false;

			movimiento.Captura = pieza;
			movimiento.EnPassant = true;
			return true;
		}
	}
}
