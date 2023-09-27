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
	public partial class FError: FormModal {
		public FError(string título, string estado): base(0.2, Transición.Curva.SuaveSalida2) {
			this.InitializeComponent();
			this.lblTitle.Text = título;
			this.lblEstado.Text = estado;
		}
	}
}
