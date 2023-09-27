using System;
using System.Collections;

namespace AjedrezSimple {
	public abstract class Pieza {
		private static int totalSimulacionesApiladas = 0;
		private readonly ArrayList simulaciones;
		protected int x;
		protected int y;
		private int últimoX;
		private int últimoY;
		protected Ajedrez juego;

		public enum ColorPieza {
			Ninguno = -1,
			Negro = 0,
			Blanco = 1,
		}

		public Pieza(int x, int y, ColorPieza color, Ajedrez juego) {
			this.últimoX = this.x = x;
			this.últimoY = this.y = y;
			this.Color = color;
			this.juego = juego;
			this.simulaciones = new ArrayList();
		}

		public static Pieza Ninguna {
			get { return new NoPieza(); }
		}

		public int X {
			get { return this.x; }
		}

		public int Y {
			get { return this.y; }
		}

		public ColorPieza Color { get; private set; }

		public ColorPieza ColorContrario {
			get {
				if(this.Color == ColorPieza.Blanco)
					return ColorPieza.Negro;

				if(this.Color == ColorPieza.Negro)
					return ColorPieza.Blanco;

				return ColorPieza.Ninguno;
			}
		}

		public char Letra { get; protected set; }

		public string Ícono { get; protected set; }

		public string Nombre { get; protected set; }

		public bool EsVacía {
			get { return this is NoPieza; }
		}

		public bool EsCapturadaEnSimulación { get; private set; }

		public abstract Pieza[] PasosVálidos { get; }

		public static string ANotación(int x, int y) {
			return $"{(char)('a' + x)}{1 + y}";
		}

		public static void APosición(string notación, out int x, out int y) {
			x = Convert.ToInt32((notación.ToLower()[0] - 'a').ToString());
			y = Convert.ToInt32(notación[1].ToString()) - 1;
		}

		public bool Mover(int destinoX, int destinoY) {
			Movimiento movimiento = new Movimiento(this.x, this.y, destinoX, destinoY);

			if(!this.PuedeMover(movimiento))
				return false;

			this.EfectuarCambios(movimiento);

			return true;
		}

		public int VerÚltimaPosición(out int origenX, out int origenY) {
			origenX = this.últimoX;
			origenY = this.últimoY;
			return this.últimoX + this.últimoY * 8;
		}

		#region Simulaciones (Esto puede ser cambiado por un mejor sistema después)
		internal void ComenzarSimulación() {
			this.simulaciones.Add(new ArrayList());
			totalSimulacionesApiladas++;
		}

		internal void Simular(Movimiento movimiento) {
			ArrayList simulación = this.simulaciones[this.simulaciones.Count - 1] as ArrayList;
			movimiento = movimiento.Copia;
			movimiento.Captura = Ninguna;

			this.x = movimiento.DestinoX;
			this.y = movimiento.DestinoY;
			simulación.Add(movimiento);

			Pieza[] atacadas = this.juego.VerPiezas(movimiento.DestinoX, movimiento.DestinoY, this.ColorContrario);
			Pieza atacada = null;
			int c = 0;

			while(c < atacadas.Length && atacada == null) {
				atacada = atacadas[c++];
				if(atacada.EsCapturadaEnSimulación)
					atacada = null;
			}

			if(atacadas.Length == 0)
				return;

			atacada.EsCapturadaEnSimulación = true;
			movimiento.Captura = atacada;
		}

		internal void Desimular() {
			ArrayList simulación = this.simulaciones[this.simulaciones.Count - 1] as ArrayList;

			int último = simulación.Count - 1;
			Movimiento movimiento = simulación[último] as Movimiento;
			this.x -= movimiento.DiferenciaX;
			this.y -= movimiento.DiferenciaY;
			movimiento.Captura.EsCapturadaEnSimulación = false;
			simulación.RemoveAt(último);
		}

		internal void DetenerSimulación() {
			ArrayList simulación = this.simulaciones[this.simulaciones.Count - 1] as ArrayList;

			int cnt = simulación.Count;
			Movimiento movimiento;
			while(cnt-- > 0) {
				movimiento = simulación[cnt] as Movimiento;
				this.x -= movimiento.DiferenciaX;
				this.y -= movimiento.DiferenciaY;
				movimiento.Captura.EsCapturadaEnSimulación = false;
			}

			this.simulaciones.Remove(simulación);
			totalSimulacionesApiladas--;
		}
		#endregion

		#region Cálculos de Caminos y Viajes
		internal Pieza[] PasosHasta(Movimiento movimiento, bool hastaColisión = false) {
			if(!movimiento.EsOrtogonal && !movimiento.EsDiagonal)
				return new Pieza[0];

			int ox = this.x;
			int oy = this.y;
			int m = movimiento.Magnitud;

			if(m == 0)
				return new Pieza[0];

			int dx, dy;
			Pieza[] pasos = new Pieza[m];
			Pieza aux;
			for(int i = 0; i < m; i++) {
				dx = ox + movimiento.SentidoH * (i + 1);
				dy = oy + movimiento.SentidoV * (i + 1);
				aux = this.juego[dx, dy];

				if(ox < 0 || ox > 7 || oy < 0 || oy > 7 || (hastaColisión && !this.PuedeMover(new Movimiento(ox, oy, dx, dy))))
					m = i;
				else
					pasos[i] = aux;
			}

			Pieza[] resultado = new Pieza[m];
			Array.Copy(pasos, 0, resultado, 0, m);
			return resultado;
		}

		internal Pieza[] PasosHasta(int destinoX, int destinoY, bool hastaColisión = false) {
			return this.PasosHasta(new Movimiento(this.x, this.y, destinoX, destinoY), hastaColisión);
		}

		protected bool ProcesarCamino(Movimiento movimiento) {
			if(this.juego.Colisiones(this.x, this.y, movimiento).Length > 0)
				return false;

			return this.ProcesarDestino(movimiento);
		}

		protected bool ProcesarDestino(Movimiento movimiento) {
			Pieza piezaDestino = this.juego[movimiento.DestinoX, movimiento.DestinoY];

			if(piezaDestino.Color == this.Color && !piezaDestino.EsCapturadaEnSimulación)
				return false;

			if(piezaDestino.Color == this.ColorContrario)
				movimiento.Captura = piezaDestino;

			return true;
		}
		#endregion

		protected bool VerificarNoFuturoJaque(Movimiento movimiento) {
			if(totalSimulacionesApiladas > 0)
				return true;

			this.ComenzarSimulación();

			this.Simular(movimiento);
			bool reyEstáSeguro = true;
			if(this.juego.JaquesHacia(this.Color, true).Length > 0)
				reyEstáSeguro = false;

			this.DetenerSimulación();

			return reyEstáSeguro;
		}

		protected virtual void EfectuarCambios(Movimiento movimiento) {
			Registro registro = new Registro(this, movimiento, this.juego);

			this.últimoX = this.x;
			this.últimoY = this.y;
			this.x = movimiento.DestinoX;
			this.y = movimiento.DestinoY;

			this.juego.Registrar(registro);
		}

		public abstract bool PuedeMover(Movimiento movimiento);

		public override string ToString() {
			return $"{this.Ícono} ({ANotación(this.x, this.y)})";
		}
	}
}
