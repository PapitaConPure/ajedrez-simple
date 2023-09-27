using System;
using System.Collections;

namespace AjedrezSimple {
	public class Rey: Pieza {
		private Torre parejaDeEnroque;
		private int respuestaDeEnroque;
		private bool bajoPrueba;

		public Rey(int x, int y, ColorPieza color, Ajedrez juego) : base(x, y, color, juego) {
			this.Letra = 'K';
			this.Ícono = "♚";
			this.Nombre = "Rey";
			this.SeHaMovido = false;
			this.bajoPrueba = false;
		}

		public bool SeHaMovido { get; private set; }

		public override Pieza[] PasosVálidos {
			get {
				ArrayList pasos = new ArrayList();
				int xmin = Math.Max(0, this.x - 2);
				int ymin = Math.Max(0, this.y - 1);
				int xmax = Math.Min(this.x + 2, 7);
				int ymax = Math.Min(this.y + 1, 7);

				Movimiento m;
				for(int xx = xmin; xx <= xmax; xx++)
					for(int yy = ymin; yy <= ymax; yy++) {
						m = new Movimiento(this.x, this.y, xx, yy);
						if(xx == this.x && yy == this.y) continue;
						if(m.DistanciaX == 2) {
							if(yy != this.y) continue;
							if(this.SeHaMovido) continue;
						}

						bajoPrueba = true;
						if(this.PuedeMover(m))
							pasos.Add(this.juego[xx, yy]);
					}
				bajoPrueba = false;

				return pasos.ToArray(typeof(Pieza)) as Pieza[];
			}
		}

		public override bool PuedeMover(Movimiento movimiento) {
			if(movimiento.EsCero || movimiento.DistanciaX > 2 || movimiento.DistanciaY > 1)
				return false;

			if(movimiento.DistanciaX == 2)
				if(movimiento.EsVertical || !this.ProcesarEnroque(movimiento))
					return false;

			return this.NoPoneEnJaque(movimiento) && this.ProcesarDestino(movimiento);
		}

		private bool NoPoneEnJaque(Movimiento movimiento) {
			Rey otroRey = this.juego.VerRey(this.ColorContrario);
			if(otroRey.X == movimiento.DestinoX && otroRey.Y == movimiento.DestinoY)
				return true;

			this.ComenzarSimulación();
			this.Simular(movimiento);

			Pieza[] oponentes = this.juego.VerPiezas(this.ColorContrario);
			Pieza oponente;
			bool esSeguro = true;
			int cnt = oponentes.Length;

			for(int i = 0; esSeguro && i < cnt; i++) {
				oponente = oponentes[i];

				if(oponente.PuedeMover(movimiento.Desde(oponente)))
					esSeguro = false;
			}

			this.DetenerSimulación();

			return esSeguro;
		}

		private bool ProcesarEnroque(Movimiento movimiento) {
			this.parejaDeEnroque = null;
			this.respuestaDeEnroque = 0;

			if(this.SeHaMovido || this.juego.Atacantes(this, 1).Length > 0)
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
			if(torre.SeHaMovido || torre.Y != this.y)
				return false;

			int dx = movimiento.DestinoX - dirección;
			if(!torre.PuedeMover(new Movimiento(torre.X, torre.Y, dx, this.y)))
				return false;

			if(!this.bajoPrueba) {
				if(dirección < 0)
					movimiento.Enroque = Movimiento.TipoEnroque.Largo;
				else
					movimiento.Enroque = Movimiento.TipoEnroque.Corto;
				this.parejaDeEnroque = torre;
				this.respuestaDeEnroque = dx;
			}

			return true;
		}

		protected override void EfectuarCambios(Movimiento movimiento) {
			if(movimiento.Enroque != Movimiento.TipoEnroque.Ninguno && this.parejaDeEnroque is Torre)
				this.parejaDeEnroque.ConcluirEnroque(this.respuestaDeEnroque);

			this.SeHaMovido = true;
			base.EfectuarCambios(movimiento);
		}
	}
}