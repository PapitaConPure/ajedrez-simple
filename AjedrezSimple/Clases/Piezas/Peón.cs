using System.Collections;

namespace AjedrezSimple {
	public class Peón: Pieza {
		public Peón(int x, int y, ColorPieza color, Ajedrez juego): base(x, y, color, juego) {
			this.Ícono = "♙";
			this.Nombre = "Peón";
			this.HizoDobleEncaque = false;
		}

		public bool HizoDobleEncaque { get; private set; }

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

		public override Pieza[] PasosVálidos {
			get {
				ArrayList pasos = new ArrayList();

				int frente = 1;
				if(this.Color == ColorPieza.Negro)
					frente = -1;
				Movimiento[] pruebas = new Movimiento[] {
					new Movimiento(this.x, this.y, this.x, this.y + frente),
					new Movimiento(this.x, this.y, this.x, this.y + frente * 2),
					new Movimiento(this.x, this.y, this.x - 1, this.y + frente),
					new Movimiento(this.x, this.y, this.x + 1, this.y + frente),
				};

				foreach(Movimiento prueba in pruebas)
					if(this.PuedeMover(prueba))
						pasos.Add(this.juego[prueba.DestinoX, prueba.DestinoY]);

				return pasos.ToArray(typeof(Pieza)) as Pieza[];
			}
		}

		public override bool PuedeMover(Movimiento movimiento) {
			if(movimiento.EsSoloHorizontal || !movimiento.EsAlFrente(this.Color))
				return false;

			if(movimiento.DistanciaX > 1 || movimiento.DistanciaY > 2)
				return false;

			if(!this.EnPosiciónInicial && movimiento.DistanciaY > 1)
				return false;

			if(movimiento.EsDiagonal) {
				if(movimiento.DistanciaX != 1)
					return false;

				Pieza atacadaDirecta = this.juego[movimiento.DestinoX, movimiento.DestinoY, this.ColorContrario];

				if(!atacadaDirecta.EsVacía)
					movimiento.Captura = atacadaDirecta;
				else if(!this.ProcesarEnPassant(movimiento))
					return false;
			} else if(movimiento.EsSoloVertical) {
				if(this.juego.Colisiones(this.x, this.y, movimiento, true).Length > 0)
					return false;
			} else
				return false;

			return this.VerificarNoFuturoJaque(movimiento);
		}

		public void OlvidarDobleEncaque() {
			this.HizoDobleEncaque = false;
		}

		private bool ProcesarEnPassant(Movimiento movimiento) {
			Pieza pieza = this.juego[movimiento.DestinoX, movimiento.DestinoY - movimiento.FrenteColor(this.Color), this.ColorContrario];

			if(!(pieza is Peón))
				return false;

			if(!(pieza as Peón).HizoDobleEncaque)
				return false;

			movimiento.Captura = pieza;
			movimiento.EnPassant = true;
			return true;
		}

		protected override void EfectuarCambios(Movimiento movimiento) {
			this.HizoDobleEncaque = movimiento.DistanciaY == 2;
			base.EfectuarCambios(movimiento);
		}
	}
}
