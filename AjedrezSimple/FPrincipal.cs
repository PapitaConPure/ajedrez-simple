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
	public partial class FPrincipal: Form {
		private static readonly Font fuentePiezas = new Font("Arial", 28);

		private DataGridViewCell ultimaCeldaSeleccionada;
		private Ajedrez juego;
		private Pieza seleccionada;
		private Pieza.ColorPieza turno;

		public FPrincipal() {
			this.InitializeComponent();

			//Formación estándar: "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR"
			//Formación para probar ambigüedades con caballos: "8/2n5/8/8/5n2/2n5/8/8"
			//Formación para probar ambigüedades con alfiles: "8/8/2b1b3/8/2b1B3/8/8/8"
			this.juego = new Ajedrez("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR");
			this.seleccionada = new NoPieza();
			this.turno = Pieza.ColorPieza.Blanco;

			this.dgvTablero.Rows.Add(8);
			this.ActualizarTablero();

			int alturaTotal = this.dgvTablero.Height - this.dgvTablero.ColumnHeadersHeight;
			int alturaFila = (int)Math.Round(1d * alturaTotal / this.dgvTablero.RowCount);
			int c = 0;

			Color colorCeldaBlanca = Color.FromArgb(227, 193, 111);
			Color colorCeldaNegra = Color.FromArgb(163, 112, 067);
			DataGridViewCell cabezaFila;
			DataGridViewCellStyle estiloCelda;
			bool esBlanca;

			foreach(DataGridViewColumn column in this.dgvTablero.Columns)
				column.SortMode = DataGridViewColumnSortMode.NotSortable;

			foreach(DataGridViewRow row in this.dgvTablero.Rows) {
				cabezaFila = row.Cells[0];
				cabezaFila.Value = $"{8 - c}";
				cabezaFila.Style = this.dgvTablero.ColumnHeadersDefaultCellStyle;
				row.Height = alturaFila;
				for(int i = 0; i < 8; i++) {
					estiloCelda = new DataGridViewCellStyle(row.Cells[i + 1].Style);
					esBlanca = (c + i) % 2 == 0;

					if(esBlanca)
						estiloCelda.BackColor = colorCeldaBlanca;
					else
						estiloCelda.BackColor = colorCeldaNegra;

					estiloCelda.Font = fuentePiezas;

					row.Cells[i + 1].Style = estiloCelda;
				}
				c++;
			}

			DataGridViewRow ultima = this.dgvTablero.Rows[this.dgvTablero.RowCount - 1];
			ultima.Height = alturaTotal - alturaFila * (this.dgvTablero.RowCount - 1) - 2;
			this.dgvTablero.ClearSelection();

			this.cmbDestinoX.SelectedIndex = this.cmbDestinoY.SelectedIndex = 0;
		}

		private void btnMover_Click(object sender, EventArgs e) {
			this.MoverPiezaSeleccionada(this.cmbDestinoX.SelectedIndex, this.cmbDestinoY.SelectedIndex);
		}

		private void dgvTablero_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e) {
			DataGridViewCell celda = e.Cell;

			if(celda == null)
				return;

			if(celda.State != DataGridViewElementStates.Selected)
				return;

			if(celda.ColumnIndex == 0) {
				this.dgvTablero.ClearSelection();
				if(ultimaCeldaSeleccionada != null)
					this.ultimaCeldaSeleccionada.Selected = true;
				return;
			} else
				this.ultimaCeldaSeleccionada = celda;

			if(this.seleccionada is NoPieza) {
				Pieza pieza = this.juego[celda.ColumnIndex - 1, 7 - celda.RowIndex];
				this.seleccionada = pieza;
				this.tbNombrePieza.Text = pieza.Nombre;
			} else {
				int dx = celda.ColumnIndex - 1;
				int dy = 7 - celda.RowIndex;

				this.cmbDestinoX.SelectedIndex = dx;
				this.cmbDestinoY.SelectedIndex = dy;
				this.MoverPiezaSeleccionada(dx, dy);
			}
		}

		private void ActualizarTablero() {
			foreach(DataGridViewRow fila in this.dgvTablero.Rows)
				foreach(DataGridViewCell c in fila.Cells)
					if(c.ColumnIndex > 0)
						c.Value = "";

			DataGridViewCell celda;
			foreach(Pieza pieza in this.juego.Piezas) {
				celda = dgvTablero[pieza.X + 1, 7 - pieza.Y];

				celda.Value = pieza.Ícono;
				if(pieza.Color == Pieza.ColorPieza.Blanco)
					celda.Style = new DataGridViewCellStyle(celda.Style) { ForeColor = Color.White };
				else
					celda.Style = new DataGridViewCellStyle(celda.Style) { ForeColor = Color.Black };
			}

			this.lsbHistorialBlancas.Items.Clear();
			this.lsbHistorialNegras.Items.Clear();
			foreach(Registro registro in this.juego.Historial) {
				if(registro.Emisora.Color == Pieza.ColorPieza.Blanco)
					this.lsbHistorialBlancas.Items.Add(registro);
				else if(registro.Emisora.Color == Pieza.ColorPieza.Negro)
					this.lsbHistorialNegras.Items.Add(registro);
			}
			this.lsbHistorialBlancas.SelectedIndex = this.lsbHistorialBlancas.Items.Count - 1;
			this.lsbHistorialNegras.SelectedIndex = this.lsbHistorialNegras.Items.Count - 1;
		}

		private void FPrincipal_KeyPress(object sender, KeyPressEventArgs e) {
			char tecla = e.KeyChar;

			if(tecla == 'm' || tecla == 'M')
				this.btnMover.PerformClick();
			if(char.IsDigit(tecla) && tecla != '0' && tecla != '9')
				this.cmbDestinoY.SelectedIndex = tecla - '0' - 1;
			else if(tecla >= 'a' && tecla < 'i')
				this.cmbDestinoX.SelectedIndex = tecla - 'a';
			else if(tecla >= 'A' && tecla < 'I')
				this.cmbDestinoX.SelectedIndex = tecla - 'A';
		}

		private void MoverPiezaSeleccionada(int dx, int dy) {
			Pieza pieza = this.seleccionada;

			if(pieza.Color != this.turno) {
				this.dgvTablero.ClearSelection();
				this.seleccionada = new NoPieza();
				return;
			}

			if(!pieza.Mover(dx, dy)) {
				this.dgvTablero.ClearSelection();
				this.seleccionada = new NoPieza();
				return;
			}

			this.ActualizarTablero();
			this.dgvTablero.ClearSelection();
			this.seleccionada = new NoPieza();

			if(pieza is Peón)
				this.PromocionarPeón(pieza as Peón);

			this.turno = pieza.ColorContrario;
			this.juego.IniciarNuevoTurno(this.turno);

			if(this.turno == Pieza.ColorPieza.Blanco) {
				this.btnMover.ForeColor = Color.Black;
				this.btnMover.BackColor = Color.White;
			} else {
				this.btnMover.ForeColor = Color.White;
				this.btnMover.BackColor = Color.Black;
			}
		}

		private void PromocionarPeón(Peón peón) {
			if(!peón.EnPosiciónFinal)
				return;

			FPromoción fPromoción = new FPromoción();
			fPromoción.tbEquipo.Text = peón.Color.ToString();
			fPromoción.tbCandidato.Text = peón.ToString();
			fPromoción.ShowDialog();

			Ajedrez.OpciónPromoción opción = Ajedrez.OpciónPromoción.Ninguno;

			if(fPromoción.rbTorre.Checked)
				opción = Ajedrez.OpciónPromoción.Torre;
			else if(fPromoción.rbCaballero.Checked)
				opción = Ajedrez.OpciónPromoción.Caballero;
			else if(fPromoción.rbAlfil.Checked)
				opción = Ajedrez.OpciónPromoción.Alfil;
			else if(fPromoción.rbReina.Checked)
				opción = Ajedrez.OpciónPromoción.Reina;

			this.juego.PromocionarPeón(peón, opción);
			this.ActualizarTablero();
		}
	}
}
