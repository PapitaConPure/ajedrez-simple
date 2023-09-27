using System;
using System.Windows.Forms;

namespace AjedrezSimple {
	public partial class FormModal: Form {
		protected readonly Transición transición;
		protected DialogResult resultadoPendiente;

		public FormModal(double segundosEntrada, Transición.Curva transición) {
			this.InitializeComponent();
			this.transición = new Transición(60, segundosEntrada, transición);
			this.resultadoPendiente = DialogResult.None;
			this.Shown += this.Form_Shown;
		}

		public FormModal(): this(1, Transición.Curva.Lineal) {}

		protected void Comienzo_Tick(object sender, EventArgs e) {
			this.Opacity = this.transición.AvanzarTick();
		}

		protected void Final_Tick(object sender, EventArgs e) {
			this.Opacity = this.transición.AvanzarTick();

			if(!this.transición.EnEjecución)
				this.DialogResult = this.resultadoPendiente;
		}

		public void Reiniciar() {
			this.Opacity = 0;
			this.resultadoPendiente = DialogResult.None;
			this.transición.Reestablecer().Comenzar(this.Comienzo_Tick);
		}

		private void Form_Shown(object sender, EventArgs e) {
			this.transición.Comenzar(this.Comienzo_Tick);
		}
	}
}
