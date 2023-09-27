using System;
using System.Windows.Forms;

namespace AjedrezSimple {
	public partial class FConfiguración: FormModal {
		public FConfiguración(): base(0.2, Transición.Curva.SuaveSalida3) {
			this.InitializeComponent();
		}

		private void Button_Click(object sender, EventArgs e) {
			if(this.resultadoPendiente != DialogResult.None)
				return;

			this.transición
				.Invertir()
				.Deformar(Transición.Curva.SuaveEntrada3)
				.Comenzar(this.Final_Tick);

			this.resultadoPendiente = (sender as Button).DialogResult;
			this.DialogResult = DialogResult.None;
		}
	}
}
