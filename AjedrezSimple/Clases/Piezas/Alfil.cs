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
				ArrayList pasos = new ArrayList();
				int xmin = Math.Max(0, this.x - 7);
				int ymin = Math.Max(0, this.y - 7);
				int xmax = Math.Min(this.x + 7, 7);
				int ymax = Math.Min(this.y + 7, 7);

				int ne = Math.Min(this.x - xmin, ymax - this.y);
				int se = Math.Min(this.x - xmin, this.y - ymin);
				int no = Math.Min(xmax - this.x, ymax - this.y);
				int so = Math.Min(xmax - this.x, this.y - ymin);
				this.AgregarLegalesHasta(pasos, this.x - ne, this.y + ne);
				this.AgregarLegalesHasta(pasos, this.x - se, this.y - se);
				this.AgregarLegalesHasta(pasos, this.x + no, this.y + no);
				this.AgregarLegalesHasta(pasos, this.x + so, this.y - so);

				return pasos.ToArray(typeof(Pieza)) as Pieza[];
			}
		}

		public override bool PuedeMover(Movimiento movimiento) {
			if(movimiento.EsCero)
				return false;

			if(!movimiento.EsDiagonal)
				return false;

			return this.ProcesarCamino(movimiento) && this.VerificarNoFuturoJaque(movimiento);
		}

		private void AgregarLegalesHasta(ArrayList pasos, int destinoX, int destinoY) {
			foreach(Pieza paso in this.PasosHasta(destinoX, destinoY, false))
				if(this.PuedeMover(new Movimiento(this.x, this.y, paso.X, paso.Y)))
					pasos.Add(paso);
		}
	}
}
