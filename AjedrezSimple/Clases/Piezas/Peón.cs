using System;

namespace AjedrezSimple {
	public class Peón: Pieza {
		public Peón(int x, int y, ColorPieza color, Ajedrez juego) : base(x, y, color, juego) {
			this.Ícono = "♙";
			this.Nombre = "Peón";
		}

		public bool HizoDobleEncaque { get; set; }

		public bool EnPosiciónInicial {
			get { return this.y == 1 || this.y == 6; }
		}

		public override bool PuedeMover(Movimiento movimiento) {
			if(!movimiento.EsVertical || !movimiento.EsHaciaDelante(this.Color))
				return false;

			if(movimiento.DistanciaX > 1 || movimiento.DistanciaY > 2)
				return false;

			if(!this.EnPosiciónInicial && movimiento.DistanciaY > 1)
				return false;

			if(movimiento.EsDiagonal) {
				if(movimiento.DistanciaX != 1)
					return false;

				Pieza pieza = this.juego[movimiento.DestinoX, movimiento.DestinoY, this.ColorContrario];
				if(!(pieza is NoPieza))
					movimiento.Captura = pieza;
				else if(!this.ProcesarEnPassant(pieza, movimiento))
					return false;
			} else if(movimiento.EsSoloVertical) {
				if(this.juego.Colisiones(this.x, this.y, movimiento, true).Length > 0)
					return false;
			} else
				return false;

			this.HizoDobleEncaque = movimiento.DistanciaY == 2;
			return true;
		}

		private bool ProcesarEnPassant(Pieza medioPaso, Movimiento movimiento) {
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
