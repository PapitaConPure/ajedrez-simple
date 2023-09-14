using System;
using System.Collections;

namespace AjedrezSimple {
	public class Ajedrez {
		private readonly ArrayList piezas;
		private readonly ArrayList historial;
		private readonly Rey reyBlanco;
		private readonly Rey reyNegro;

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

			this.HaFinalizado = false;
			this.Ganador = Pieza.ColorPieza.Ninguno;

			int rep;
			int x = 0;
			int y = 7;
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

					switch(c.ToString().ToLower()[0]) {
					case 'r': pieza = new Torre(x, y, color, this); break;
					case 'n': pieza = new Caballero(x, y, color, this); break;
					case 'b': pieza = new Alfil(x, y, color, this); break;
					case 'q': pieza = new Reina(x, y, color, this); break;
					case 'k': pieza = new Rey(x, y, color, this); break;
					case 'p': pieza = new Peón(x, y, color, this); break;
					}

					this.piezas.Add(pieza);
					if(pieza is Rey) {
						if(color == Pieza.ColorPieza.Blanco)
							this.reyBlanco = pieza as Rey;
						else
							this.reyNegro = pieza as Rey;
					}

					x++;
				}
			}
		}

		public Ajedrez(): this("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR") {}

		#region Propiedades de Partida
		public bool HaFinalizado { get; private set; }

		public Pieza.ColorPieza Ganador { get; private set; }

		public string Empate { get; private set; }

		public Registro ÚltimoRegistro {
			get { return this.historial[this.historial.Count - 1] as Registro; }
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
		#endregion

		#region Búsqueda y Resolución de Piezas
		public Pieza[] Piezas {
			get {
				Pieza[] arr = new Pieza[this.piezas.Count];
				int c = 0;

				foreach(Pieza pieza in this.piezas)
					arr[c++] = pieza;

				return arr;
			}
		}

		public Pieza this[int x, int y] {
			get {
				if(x < 0 || x > 7 || y < 0 || y > 7)
					return new NoPieza(x, y);

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
				if(x < 0 || x > 7 || y < 0 || y > 7 || color == Pieza.ColorPieza.Ninguno)
					return new NoPieza(x, y);

				Pieza encontrada = null;
				bool éxito = false;

				foreach(Pieza pieza in this.VerPiezas(color))
					if(pieza.X == x && pieza.Y == y) {
						encontrada = pieza;
						éxito = true;
					}

				if(!éxito)
					encontrada = new NoPieza(x, y);

				return encontrada;
			}
		}
		#endregion

		#region Acciones de Turno
		public void IniciarNuevoTurno(Pieza.ColorPieza turno) {
			foreach(Pieza pieza in this.piezas) {
				if(pieza.Color != turno)
					continue;

				if(pieza is Peón)
					(pieza as Peón).OlvidarDobleEncaque();
			}
		}

		public bool PromocionarPeón(Peón peón, OpciónPromoción opción) {
			Pieza nueva;

			switch(opción) {
			case OpciónPromoción.Torre:     nueva = new Torre    (peón.X, peón.Y, peón.Color, this); break;
			case OpciónPromoción.Caballero: nueva = new Caballero(peón.X, peón.Y, peón.Color, this); break;
			case OpciónPromoción.Alfil:     nueva = new Alfil    (peón.X, peón.Y, peón.Color, this); break;
			case OpciónPromoción.Reina:     nueva = new Reina    (peón.X, peón.Y, peón.Color, this); break;
			default: return false;
			}

			#region Insertar nueva pieza en el lugar del Peón
			int índice = this.piezas.IndexOf(peón);

			if(índice < 0)
				return false;

			this.piezas[índice] = nueva;
			#endregion

			Registro registro = this.ÚltimoRegistro;
			registro.Movimiento.Promoción = nueva;

			Pieza[] jaques = this.JaquesHacia(peón.ColorContrario);
			if(jaques.Length > 0) {
				registro.EsJaque = true;
				if(this.ComprobarJaqueMate(jaques)) {
					registro.EsJaqueMate = true;
					this.HaFinalizado = true;
					this.Ganador = registro.Emisora.Color;
				}
			}

			return true;
		}
		#endregion

		#region Ver Piezas
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

		public Rey VerRey(Pieza.ColorPieza color) {
			if(color == Pieza.ColorPieza.Blanco)
				return this.reyBlanco;
			else
				return this.reyNegro;
		}

		public Pieza[] VerPiezas(int x, int y, Pieza.ColorPieza color = Pieza.ColorPieza.Ninguno) {
			ArrayList piezas = new ArrayList();

			foreach(Pieza pieza in this.piezas)
				if(pieza.X == x && pieza.Y == y && pieza.ColorContrario != color)
					piezas.Add(pieza);

			return piezas.ToArray(typeof(Pieza)) as Pieza[];
		}

		public Pieza[] VerPiezas(Pieza.ColorPieza color = Pieza.ColorPieza.Ninguno) {
			if(color == Pieza.ColorPieza.Ninguno)
				return new Pieza[0];

			ArrayList piezas = new ArrayList();

			foreach(Pieza pieza in this.piezas)
				if(pieza.Color == color)
					piezas.Add(pieza);

			return piezas.ToArray(typeof(Pieza)) as Pieza[];
		}
		#endregion

		#region Escenarios Finales
		public bool ComprobarReyAhogado(Pieza.ColorPieza color) {
			bool estáAhogado = true;

			Pieza[] piezas = this.VerPiezas(color);
			Pieza pieza;
			int p = 0;
			while(estáAhogado && p < piezas.Length) {
				pieza = piezas[p++];

				if(pieza.PasosVálidos.Length > 0)
					estáAhogado = false;
			}

			return estáAhogado;
		}

		public bool ComprobarJaqueMate(Pieza[] jaques) {
			Rey rey = this.VerRey(jaques[0].ColorContrario);

			if(rey.PasosVálidos.Length > 0)
				return false;

			if(jaques.Length == 1 && this.Atacantes(jaques[0], 1).Length > 0)
				return false;

			#region Comprobar si se puede bloquear el camino de las piezas que ocasionan el Jaque inmediato
			bool puedeBloquearTodo = true;
			bool puedeBloquear;
			Movimiento conclusivo = new Movimiento(0, 0, rey.X, rey.Y);
			Pieza[] pasos;
			Pieza paso;
			Pieza[] aliadas = this.VerPiezas(rey.Color);
			Pieza defensora;
			foreach(Pieza jaque in jaques) {
				puedeBloquear = false;
				pasos = jaque.PasosHasta(conclusivo.Desde(jaque));

				for(int p = 0; p < pasos.Length && !puedeBloquear; p++) {
					paso = pasos[p];
					for(int a = 0; a < aliadas.Length && !puedeBloquear; a++) {
						defensora = aliadas[a];

						if(defensora.PuedeMover(new Movimiento(defensora.X, defensora.Y, paso.X, paso.Y)))
							puedeBloquear = true;
					}
				}

				if(!puedeBloquear)
					puedeBloquearTodo = false;
			}
			#endregion

			return !puedeBloquearTodo;
		}

		public bool ComprobarInsuficienciaMaterial() {
			bool esInsuficiente = true;
			bool huboCaballero = false;
			int bits;
			int bitsAlfilesBlancos = 0;
			int bitsAlfilesNegros = 0;
			bool casillaBlanca;

			int cnt = this.piezas.Count;
			int i = 0;
			while(i < cnt && esInsuficiente) {
				Pieza pieza = this.piezas[i++] as Pieza;

				if(pieza is Rey)
					continue;

				if(pieza is Caballero) {
					esInsuficiente = !huboCaballero;
					huboCaballero = true;
				} else if(pieza is Alfil) {
					if(pieza.Color == Pieza.ColorPieza.Blanco)
						bits = 1;
					else
						bits = 2;

					casillaBlanca = (pieza.X + pieza.Y) % 2 == 0;
					if(casillaBlanca) {
						bitsAlfilesBlancos |= bits;
						if(bitsAlfilesBlancos == 3)
							esInsuficiente = false;
					} else {
						bitsAlfilesNegros |= bits;
						if(bitsAlfilesNegros == 3)
							esInsuficiente = false;
					}
				} else
					esInsuficiente = false;
			}

			return esInsuficiente;
		}
		#endregion

		#region Interacciones entre Piezas
		public Pieza[] Colisiones(int ox, int oy, Movimiento m, bool contarColisiónFinal = false) {
			ArrayList colisiones = new ArrayList();

			if(!m.EsOrtogonal && !m.EsDiagonal)
				return new Pieza[0];

			int i;
			Pieza encontrada, aux;
			foreach(Pieza pieza in this.piezas) {
				i = m.Magnitud;
				encontrada = null;

				if(!contarColisiónFinal)
					i--;

				while(i > 0 && encontrada == null) {
					aux = this[ox + m.SentidoH * i, oy + m.SentidoV * i];
					if(!aux.EsVacía)
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

		public Pieza[] JaquesHacia(Pieza.ColorPieza colorReyAtacado, bool considerarSimulado = false) {
			Rey rey = this.VerRey(colorReyAtacado);
			return this.Atacantes(rey, 2, considerarSimulado);
		}

		public Pieza[] Atacantes(Pieza atacada, int límiteAtacantes = 16, bool considerarSimulado = false) {
			Pieza[] posiblesAtacantes = this.VerPiezas(atacada.ColorContrario);
			ArrayList atacantes = new ArrayList();
			Pieza atacante;

			for(int i = 0; i < posiblesAtacantes.Length && atacantes.Count < límiteAtacantes; i++) {
				atacante = posiblesAtacantes[i];

				if((!considerarSimulado || (!atacante.EsCapturadaEnSimulación && !atacada.EsCapturadaEnSimulación))
				&& atacante.PuedeMover(new Movimiento(atacante.X, atacante.Y, atacada.X, atacada.Y)))
					atacantes.Add(atacante);
			}

			return atacantes.ToArray(typeof(Pieza)) as Pieza[];
		}
		#endregion

		internal void Registrar(Registro registro) {
			if(!registro.Captura.EsVacía)
				this.piezas.Remove(registro.Captura);

			Pieza[] jaques = this.JaquesHacia(registro.Emisora.ColorContrario);
			if(jaques.Length > 0) {
				registro.EsJaque = true;
				if(this.ComprobarJaqueMate(jaques)) {
					registro.EsJaqueMate = true;
					this.HaFinalizado = true;
					this.Ganador = registro.Emisora.Color;
				}
			} else if(this.ComprobarReyAhogado(registro.Emisora.ColorContrario)) {
				registro.EsReyAhogado = true;
				this.HaFinalizado = true;
				this.Empate = "Rey Ahogado";
			} else if(this.ComprobarInsuficienciaMaterial()) {
				this.HaFinalizado = true;
				this.Empate = "Insuficiencia Material";
			}

			this.historial.Add(registro);
		}
	}
}