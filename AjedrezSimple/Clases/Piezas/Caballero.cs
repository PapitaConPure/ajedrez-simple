using System;
using System.Collections;

namespace AjedrezSimple {
	public class Caballero: Pieza {
		public Caballero(int x, int y, ColorPieza color, Ajedrez juego) : base(x, y, color, juego) {
			this.Ícono = "♞";
			this.Nombre = "Caballero";
		}

		public override Pieza[] PasosVálidos {
			get {
				ArrayList pasos = new ArrayList();

				int dx, dy;
				for(int xx = -2; xx <= 2; xx++) {
					if(x == 0)
						continue;

					for(int yy = -2; yy <= 2; yy++) {
						if(Math.Abs(xx) + Math.Abs(yy) != 3)
							continue;

						dx = this.x + xx;
						dy = this.y + yy;

						if(dx < 0 || dx > 7 || dy < 0 || dy > 7)
							continue;

						if(this.PuedeMover(new Movimiento(this.x, this.y, dx, dy)))
							pasos.Add(this.juego[dx, dy]);
					}
				}

				return pasos.ToArray(typeof(Pieza)) as Pieza[];
			}
		}

		public override bool PuedeMover(Movimiento movimiento) {
			if(movimiento.EsCero || movimiento.Magnitud > 2)
				return false;

			if(movimiento.EsOrtogonal || movimiento.EsDiagonal)
				return false;

			return this.ProcesarDestino(movimiento) && this.VerificarNoFuturoJaque(movimiento);
		}
	}
}
