using System;

namespace AjedrezSimple {
	public class Rey: Pieza {
		public Rey(int x, int y, ColorPieza color, Ajedrez juego) : base(x, y, color, juego) {
			this.Ícono = "♚";
			this.Nombre = "Rey";
			this.SeHaMovido = false;
		}

		public bool SeHaMovido { get; private set; }

		public override bool ConfirmarMover(Movimiento movimiento) {
			if(movimiento.EsCero || movimiento.DistanciaX > 2 || movimiento.DistanciaY > 1)
				return false;

			if(movimiento.DistanciaX == 2)
				if(movimiento.EsVertical || !this.ProcesarEnroque(movimiento))
					return false;

			bool seMovió = this.AnalizarDestino(movimiento);
			this.SeHaMovido |= seMovió;
			return seMovió;
		}

		private bool ProcesarEnroque(Movimiento movimiento) {
			if(this.SeHaMovido)
				return false;

			int dirección = movimiento.SentidoH;
			int búsquedaX;
			if(dirección < 0)
				búsquedaX = 0;
			else
				búsquedaX = 7;

			Pieza pieza = this.juego[búsquedaX, this.y, this.Color];
			if(!(pieza is Torre))
				return false;

			Torre torre = pieza as Torre;
			if(torre.SeHaMovido)
				return false;

			int distancia;
			bool enroqueVálido = torre.ConcluirEnroque(this.x + dirección, out distancia);
			if(distancia > 2)
				movimiento.Enroque = Movimiento.TipoEnroque.Largo;
			else
				movimiento.Enroque = Movimiento.TipoEnroque.Corto;

			return enroqueVálido;
		}
	}
}