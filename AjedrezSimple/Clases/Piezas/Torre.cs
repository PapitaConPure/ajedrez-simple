using System;
using System.Collections;

namespace AjedrezSimple {
	public class Torre: Pieza {
		public Torre(int x, int y, ColorPieza color, Ajedrez juego) : base(x, y, color, juego) {
			this.Letra = 'R';
			this.Ícono = "♜";
			this.Nombre = "Torre";
			this.SeHaMovido = false;
		}

		public bool SeHaMovido { get; private set; }

		public override Pieza[] PasosVálidos {
			get {
				ArrayList pasos = new ArrayList();
				int xmin = Math.Max(0, this.x - 7);
				int ymin = Math.Max(0, this.y - 7);
				int xmax = Math.Min(this.x + 7, 7);
				int ymax = Math.Min(this.y + 7, 7);

				this.AgregarLegalesHasta(pasos, xmin, this.y);
				this.AgregarLegalesHasta(pasos, xmax, this.y);
				this.AgregarLegalesHasta(pasos, this.x, ymin);
				this.AgregarLegalesHasta(pasos, this.x, ymax);

				return pasos.ToArray(typeof(Pieza)) as Pieza[];
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

		private void AgregarLegalesHasta(ArrayList pasos, int destinoX, int destinoY) {
			foreach(Pieza paso in this.PasosHasta(destinoX, destinoY, false))
				if(this.PuedeMover(new Movimiento(this.x, this.y, paso.X, paso.Y)))
					pasos.Add(paso);
		}
	}
}
