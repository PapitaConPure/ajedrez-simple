using System;
using System.Collections;

namespace AjedrezSimple {
	public class Ajedrez {
		private ArrayList piezas;
		private ArrayList historial;
		private Rey reyBlanco;
		private Rey reyNegro;

		public enum OpciónPromoción {
			Ninguno = 0,
			Torre,
			Caballero,
			Alfil,
			Reina
		}

		public Ajedrez(string formacion = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR") {
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

		public bool HaFinalizado { get; private set; }

		public Pieza.ColorPieza Ganador { get; private set; }

		public string Empate { get; private set; }

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
			Registro últimoRegistro = this.historial[this.historial.Count - 1] as Registro;
			últimoRegistro.Movimiento.Promoción = nueva;

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

			#region Comprobar si se puede escapar por movimiento directo del Rey en Jaque
			bool puedeEscapar = false;
			foreach(Pieza paso in rey.PasosVálidos)
				if(rey.PuedeMover(new Movimiento(rey.X, rey.Y, paso.X, paso.Y)))
					puedeEscapar = true;
			#endregion

			if(puedeEscapar)
				return false;

			#region Comprobar si se pueden capturar las piezas que ocasionan el Jaque inmediato
			bool puedeCapturar = false;
			Pieza[] contraAtacantes;
			foreach(Pieza jaque in jaques) {
				contraAtacantes = this.Atacantes(jaque);
				Movimiento contraAtaque = new Movimiento(0, 0, jaque.X, jaque.Y);
				foreach(Pieza contraAtacante in contraAtacantes) {
					contraAtacante.ComenzarSimulación();

					contraAtaque = contraAtaque.Desde(contraAtacante);
					if(!contraAtacante.PuedeMover(contraAtaque))
						continue;

					contraAtacante.Simular(contraAtaque);
					if(this.Atacantes(rey).Length == 0)
						puedeCapturar = true;

					contraAtacante.DetenerSimulación();
				}
			}
			#endregion

			if(puedeCapturar)
				return false;

			#region Comprobar si se puede bloquear el camino de las piezas que ocasionan el Jaque inmediato
			bool puedeBloquear = false;
			Movimiento conclusivo = new Movimiento(0, 0, rey.X, rey.Y);
			foreach(Pieza aliada in this.VerPiezas(rey.Color))
				foreach(Pieza atacante in jaques)
					foreach(Pieza bloqueable in atacante.PasosHasta(conclusivo.Desde(atacante)))
						if(aliada.PuedeMover(new Movimiento(aliada.X, aliada.Y, bloqueable.X, bloqueable.Y)))
							puedeBloquear = true;
			#endregion

			return !puedeBloquear;
		}

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
			return this.Atacantes(rey, considerarSimulado);
		}

		public Pieza[] Atacantes(int destinoX, int destinoY, Pieza.ColorPieza atacado, bool considerarSimulado = false) {
			Pieza atacada = this[destinoX, destinoY, atacado];

			if(atacada is NoPieza)
				return new Pieza[0];

			return this.Atacantes(atacada, considerarSimulado);
		}

		public Pieza[] Atacantes(Pieza atacada, bool considerarSimulado = false) {
			Pieza[] posiblesAtacantes = this.VerPiezas(atacada.ColorContrario);
			ArrayList atacantes = new ArrayList();
			Pieza atacante;

			for(int i = 0; i < posiblesAtacantes.Length && atacantes.Count < 2; i++) {
				atacante = posiblesAtacantes[i];

				if((!considerarSimulado || (!atacante.EsCapturadaEnSimulación && !atacada.EsCapturadaEnSimulación))
				&& atacante.PuedeMover(new Movimiento(atacante.X, atacante.Y, atacada.X, atacada.Y)))
					atacantes.Add(atacante);
			}

			return atacantes.ToArray(typeof(Pieza)) as Pieza[];
		}

		internal void Registrar(Registro registro) {
			if(!(registro.Captura is NoPieza))
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
			}

			this.historial.Add(registro);
		}
	}
}