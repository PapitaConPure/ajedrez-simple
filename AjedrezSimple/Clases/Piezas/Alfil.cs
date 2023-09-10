using System;
using System.Collections;

namespace AjedrezSimple {
	public class Alfil: Pieza {
		public Alfil(int x, int y, ColorPieza color, Ajedrez juego) : base(x, y, color, juego) {
			this.Ícono = "♝";
			this.Nombre = "Alfil";
		}

		public override Pieza[] PasosVálidos {
			get {
				ArrayList caminos = new ArrayList();
				int xmin = Math.Max(0, this.x - 7);
				int ymin = Math.Max(0, this.y - 7);
				int xmax = Math.Min(this.x + 7, 7);
				int ymax = Math.Min(this.y + 7, 7);
				int ne = Math.Min(this.x - xmin, ymax - this.y);
				int se = Math.Min(this.x - xmin, this.y - ymin);
				int no = Math.Min(xmax - this.x, ymax - this.y);
				int so = Math.Min(xmax - this.x, this.y - ymin);
				caminos.Add(this.PasosHasta(this.x - ne, this.y + ne, true));
				caminos.Add(this.PasosHasta(this.x - se, this.y - se, true));
				caminos.Add(this.PasosHasta(this.x + no, this.y + no, true));
				caminos.Add(this.PasosHasta(this.x + so, this.y - so, true));

				int l = 0;
				foreach(Pieza[] pasos in caminos)
					l += pasos.Length;

				Pieza[] resultado = new Pieza[l];

				int r = 0;
				foreach(Pieza[] pasos in caminos) {
					pasos.CopyTo(resultado, r);
					r += pasos.Length;
				}

				return resultado;
			}
		}

		public override bool PuedeMover(Movimiento movimiento) {
			if(movimiento.EsCero)
				return false;

			if(!movimiento.EsDiagonal)
				return false;

			return this.ProcesarCamino(movimiento) && this.VerificarNoFuturoJaque(movimiento);
		}
	}
}
