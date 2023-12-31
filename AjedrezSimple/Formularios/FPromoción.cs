﻿using System;
using System.Windows.Forms;

namespace AjedrezSimple {
	public partial class FPromoción: FormModal {
		public FPromoción(): base(0.5, Transición.Curva.Suave2) {
			this.InitializeComponent();
		}

		private void Button_Click(object sender, EventArgs e) {
			if(this.resultadoPendiente != DialogResult.None)
				return;

			this.transición
				.Invertir()
				.Escalar(0.25)
				.Comenzar(this.Final_Tick);

			this.resultadoPendiente = (sender as Button).DialogResult;
			this.DialogResult = DialogResult.None;
		}
	}
}
