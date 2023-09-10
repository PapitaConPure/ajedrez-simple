using System;
using System.Collections;

namespace AjedrezSimple {
	public class Torre: Pieza {
		public Torre(int x, int y, ColorPieza color, Ajedrez juego) : base(x, y, color, juego) {
			this.Ícono = "♜";
			this.Nombre = "Torre";
			this.SeHaMovido = false;
		}

		public bool SeHaMovido { get; private set; }

		public override Pieza[] PasosVálidos {
			get {
				ArrayList caminos = new ArrayList();
				int xmin = Math.Max(0, this.x - 7);
				int ymin = Math.Max(0, this.y - 7);
				int xmax = Math.Min(this.x + 7, 7);
				int ymax = Math.Min(this.y + 7, 7);

				caminos.Add(this.PasosHasta(xmin, this.y, true));
				caminos.Add(this.PasosHasta(xmax, this.y, true));
				caminos.Add(this.PasosHasta(this.x, ymin, true));
				caminos.Add(this.PasosHasta(this.x, ymax, true));

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

			if(!movimiento.EsOrtogonal)
				return false;

			return this.ProcesarCamino(movimiento) && this.VerificarNoFuturoJaque(movimiento);
		}

		internal void ConcluirEnroque(int destinoX) {
			if(this.SeHaMovido) return;
			this.SeHaMovido = true;
			this.x = destinoX;
		}

		protected override void EfectuarCambios(Movimiento movimiento) {
			this.SeHaMovido = true;
			base.EfectuarCambios(movimiento);
		}
	}
}
