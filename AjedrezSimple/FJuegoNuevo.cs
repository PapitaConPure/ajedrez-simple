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
		public FJuegoNuevo(string título, string estado) {
			this.InitializeComponent();
			this.Text = título;
			this.lblEstado.Text = estado;
		}
	}
}
