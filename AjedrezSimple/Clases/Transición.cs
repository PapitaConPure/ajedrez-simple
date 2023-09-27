using System;
using System.Windows.Forms;

namespace AjedrezSimple {
	public class Transición {
		private readonly double tps;
		private readonly int tickInicial;
		private readonly int maxTicksInicial;
		private readonly Curva curvaInicial;

		private int ticks;
		private int sentido;
		private int maxTicks;
		private Curva curva;

		private readonly Timer timer;
		private EventHandler suscriptoActual;

		public enum Curva {
			Lineal = 0,
			SuaveEntrada2,
			SuaveEntrada3,
			SuaveSalida2,
			SuaveSalida3,
			Suave2,
			Suave3,
		}

		public Transición(double ticksPorSegundo, double duraciónEnSegundos, Curva métodoDeSuavizado, int tickInicial) {
			this.tps = ticksPorSegundo;
			this.ticks = this.tickInicial = tickInicial;
			this.maxTicks = this.maxTicksInicial = (int)Math.Round(duraciónEnSegundos * ticksPorSegundo);
			this.curva = this.curvaInicial = métodoDeSuavizado;
			this.sentido = 1;

			this.timer = new Timer();
			this.timer.Interval = (int)Math.Round(1000 / this.tps);
			this.suscriptoActual = null;
		}

		internal Transición Reestablecer() {
			this.ticks = this.tickInicial;
			this.maxTicks = this.maxTicksInicial;
			this.curva = this.curvaInicial;
			this.sentido = 1;

			return this;
		}

		public Transición(double ticksPorSegundo, double duraciónEnSegundos, Curva métodoDeSuavizado)
			: this(ticksPorSegundo, duraciónEnSegundos, métodoDeSuavizado, 0) {}

		public Transición(double ticksPorSegundo, double duraciónEnSegundos)
			: this(ticksPorSegundo, duraciónEnSegundos, Curva.Lineal, 0) {}

		public Transición(double duraciónEnSegundos): this(30, duraciónEnSegundos, Curva.Lineal, 0) {}

		public Transición(): this(30, 1, Curva.Lineal, 0) {}

		public double this[double tick] {
			get {
				if(this.sentido > 0)
					return this.Curvar(tick / this.maxTicks);
				else
					return this.Curvar(1 - tick / this.maxTicks);
			}
		}

		public bool EnEjecución {
			get { return this.timer.Enabled; }
		}

		public Transición Comenzar(EventHandler suscriptor_Tick) {
			if(this.suscriptoActual != null)
				this.timer.Tick -= this.suscriptoActual;

			this.ticks = 0;
			this.suscriptoActual = suscriptor_Tick;
			this.timer.Tick += suscriptor_Tick;
			this.timer.Enabled = true;
			this.timer.Start();

			return this;
		}

		public double AvanzarTick() {
			if(this.ticks >= this.maxTicks) {
				this.Detener();
				return this[this.maxTicks];
			}

			return this[this.ticks++];
		}

		public Transición Detener() {
			if(this.suscriptoActual != null)
				this.timer.Tick -= this.suscriptoActual;

			this.timer.Stop();
			this.timer.Enabled = false;
			this.suscriptoActual = null;

			return this;
		}

		public Transición Escalar(double escala) {
			this.maxTicks = (int)(this.maxTicks * escala);
			return this;
		}

		public Transición Estirar(double duraciónEnSegundos) {
			this.maxTicks = (int)Math.Round(duraciónEnSegundos * this.tps);
			return this;
		}

		public Transición Deformar(Curva nuevaCurva) {
			this.curva= nuevaCurva;
			return this;
		}

		public Transición Invertir() {
			this.sentido *= -1;
			return this;
		}

		private double Curvar(double progreso) {
			switch(this.curva) {
			default:
				return progreso;
			case Curva.SuaveEntrada2:
				return Math.Pow(progreso, 2);
			case Curva.SuaveEntrada3:
				return Math.Pow(progreso, 3);
			case Curva.SuaveSalida2:
				return 1 - Math.Pow(1 - progreso, 2);
			case Curva.SuaveSalida3:
				return 1 - Math.Pow(1 - progreso, 3);
			case Curva.Suave2:
				return Math.Pow(progreso, 2) * (3 - 2 * progreso);
			case Curva.Suave3:
				return Math.Pow(progreso, 3) * (progreso * (progreso * 6 - 15) + 10);
			}
		}
	}
}
