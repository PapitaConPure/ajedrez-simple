using System;
using System.Windows.Forms;

namespace AjedrezSimple {
	public partial class FJuegoNuevo: FormModal {
		public FJuegoNuevo(string título, string estado, double segundosEntrada): base(segundosEntrada, Transición.Curva.SuaveSalida3) {
			this.InitializeComponent();
			this.lblTitle.Text = título;
			this.lblEstado.Text = estado;
		}

		private void Button_Click(object sender, EventArgs e) {
			if(this.resultadoPendiente != DialogResult.None)
				return;

			this.transición
				.Invertir()
				.Estirar(0.2)
				.Deformar(Transición.Curva.Suave3)
				.Comenzar(this.Final_Tick);

			this.resultadoPendiente = (sender as Button).DialogResult;
			this.DialogResult = DialogResult.None;
		}
	}
}
