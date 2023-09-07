using System;
using System.Collections;

namespace AjedrezSimple {
	public class Ajedrez {
		private ArrayList piezas;
		private ArrayList historial;

		public enum OpciónPromoción {
			Ninguno = 0,
			Torre,
			Caballero,
			Alfil,
			Reina
		}

		public Ajedrez(string formacion) {
			this.piezas = new ArrayList();
			this.historial = new ArrayList();

			int rep;
			int x = 0;
			int y = 7;
			bool valido;
			Pieza.ColorPieza color;
			Pieza pieza = null;
			foreach(char c in formacion) {
				if(c == '/') {
					x = 0;
					y--;
				} else if(char.IsDigit(c)) {
					rep = Convert.ToInt32(c.ToString());
					x += rep;
				} else {
					if(char.IsUpper(c))
						color = Pieza.ColorPieza.Blanco;
					else
						color = Pieza.ColorPieza.Negro;

					valido = true;
					switch(c.ToString().ToLower()[0]) {
					case 'r': pieza = new Torre(x, y, color, this); break;
					case 'n': pieza = new Caballero(x, y, color, this); break;
					case 'b': pieza = new Alfil(x, y, color, this); break;
					case 'q': pieza = new Reina(x, y, color, this); break;
					case 'k': pieza = new Rey(x, y, color, this); break;
					case 'p': pieza = new Peón(x, y, color, this); break;
					default: valido = false; break;
					}

					if(valido)
						this.piezas.Add(pieza);

					x++;
				}
			}
		}

		public Pieza[] Piezas {
			get {
				Pieza[] arr = new Pieza[this.piezas.Count];
				int c = 0;

				foreach(Pieza pieza in this.piezas)
					arr[c++] = pieza;

				return arr;
			}
		}

		public Registro[] Historial {
			get {
				Registro[] arr = new Registro[this.historial.Count];
				int c = 0;

				foreach(Registro registro in this.historial)
					arr[c++] = registro;

				return arr;
			}
		}

		public Pieza this[int x, int y] {
			get {
				Pieza encontrada = null;
				bool éxito = false;

				foreach(Pieza pieza in this.piezas)
					if(pieza.X == x && pieza.Y == y) {
						encontrada = pieza;
						éxito = true;
					}

				if(!éxito)
					encontrada = new NoPieza(x, y);

				return encontrada;
			}
		}

		public Pieza this[int x, int y, Pieza.ColorPieza color] {
			get {
				if(color == Pieza.ColorPieza.Ninguno)
					return new NoPieza(x, y);

				Pieza encontrada = null;
				bool éxito = false;

				foreach(Pieza pieza in this.piezas)
					if(pieza.Color == color && pieza.X == x && pieza.Y == y) {
						encontrada = pieza;
						éxito = true;
					}

				if(!éxito)
					encontrada = new NoPieza(x, y);

				return encontrada;
			}
		}

		public void IniciarNuevoTurno(Pieza.ColorPieza turno) {
			foreach(Pieza pieza in this.piezas) {
				if(pieza.Color != turno)
					continue;

				if(pieza is Peón) {
					Peón peón = pieza as Peón;
					peón.HizoDobleEncaque = false;
				}
			}
		}

		public bool PromocionarPeón(Peón peón, OpciónPromoción opción) {
			Pieza nueva;

			switch(opción) {
			case OpciónPromoción.Torre:     nueva = new Torre(peón.X, peón.Y, peón.Color, this);     break;
			case OpciónPromoción.Caballero: nueva = new Caballero(peón.X, peón.Y, peón.Color, this); break;
			case OpciónPromoción.Alfil:     nueva = new Alfil(peón.X, peón.Y, peón.Color, this);     break;
			case OpciónPromoción.Reina:     nueva = new Reina(peón.X, peón.Y, peón.Color, this);     break;
			default: return false;
			}

			int índice = this.piezas.IndexOf(peón);

			if(índice < 0)
				return false;

			this.piezas[índice] = nueva;

			return true;
		}

		public Pieza VerPieza(string posición) {
			int[] pos = Pieza.APosición(posición);
			int x = pos[0];
			int y = pos[1];

			return this[x, y];
		}

		public Pieza VerPieza(string x, int y) {
			return this[x.ToLower()[0] - 'a', y - 1];
		}

		public Pieza VerPieza(int x, int y) {
			return this[x - 1, y - 1];
		}

		public Pieza[] Colisiones(int ox, int oy, Movimiento m, bool contarColisiónFinal = false) {
			ArrayList colisiones = new ArrayList();

			int sx = Math.Sign(m.DiferenciaX);
			int sy = Math.Sign(m.DiferenciaY);
			int mx, my, i;
			Pieza encontrada;
			Pieza aux;

			foreach(Pieza pieza in this.piezas) {
				encontrada = null;

				if(m.EsDiagonal) {
					i = m.Magnitud;
					mx = my = 1;
				} else if(m.EsSoloHorizontal) {
					i = m.DistanciaX;
					mx = 1;
					my = 0;
				} else if(m.EsSoloVertical) {
					i = m.DistanciaY;
					mx = 0;
					my = 1;
				} else
					continue;

				if(!contarColisiónFinal)
					i--;

				while(i > 0 && encontrada == null) {
					aux = this[ox + mx * sx * i, oy + my * sy * i];
					if(!(aux is NoPieza))
						encontrada = aux;

					i--;
				}

				if(encontrada != null)
					colisiones.Add(encontrada);
			}

			Pieza[] convertido = new Pieza[colisiones.Count];
			int c = 0;

			foreach(Pieza pieza in colisiones)
				convertido[c++] = pieza;

			return convertido;
		}

		internal void Registrar(Registro registro) {
			this.historial.Add(registro);

			if(!(registro.Captura is NoPieza))
				this.piezas.Remove(registro.Captura);
		}
	}
}