using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AjedrezSimple {
	public partial class FJuegoNuevo: Form {
		private double tps;
		private int ticks;
		private int maxTicks;

		public FJuegoNuevo(string título, string estado, double segundosEntrada) {
			this.InitializeComponent();
			this.lblTitle.Text = título;
			this.lblEstado.Text = estado;

			this.tps = 60;
			this.ticks = 0;
			this.maxTicks = (int)Math.Round(segundosEntrada * this.tps);
			this.timer.Interval = (int)Math.Round(1000 / this.tps);
		}

		private void FJuegoNuevo_Shown(object sender, EventArgs e) {
			this.timer.Enabled = true;
			this.timer.Start();
		}

		private void timer_Tick(object sender, EventArgs e) {
			this.ticks++;

			if(this.ticks >= this.maxTicks) {
				this.Opacity = 1;
				this.timer.Stop();
				this.timer.Enabled = false;
				return;
			}

			double t = 1d * this.ticks / this.maxTicks;
			double aumento = 1d - Math.Pow(1d - t, 3d);
			this.Opacity = aumento;
		}
	}
}
