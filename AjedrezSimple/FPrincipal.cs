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

			this.dgvTablero.Rows.Add(8);

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

		private void FPrincipal_Load(object sender, EventArgs e) {
			this.NuevaPartida("Comenzar Juego", "Este será el primer Juego de hoy. Puedes comenzar cuando quieras");
		}

		private void btnMover_Click(object sender, EventArgs e) {
			this.MoverPiezaSeleccionada(this.cmbDestinoX.SelectedIndex, this.cmbDestinoY.SelectedIndex);
		}

		private void dgvTablero_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e) {
			DataGridViewCell celda = e.Cell;

			if(celda == null)
				return;

			if(celda.State != DataGridViewElementStates.Selected) {
				if(this.juego != null)
					this.ActualizarTablero();
				return;
			}

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
				this.ActualizarTablero();
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
			Color colorCelda;
			foreach(Pieza pieza in this.juego.Piezas) {
				celda = dgvTablero[pieza.X + 1, 7 - pieza.Y];

				celda.Value = pieza.Ícono;
				if(pieza.Color == Pieza.ColorPieza.Blanco)
					colorCelda = Color.White;
				else
					colorCelda = Color.Black;
				celda.Style = new DataGridViewCellStyle(celda.Style) { ForeColor = colorCelda };
			}

			if(this.seleccionada.Color == this.turno)
				foreach(Pieza paso in this.seleccionada.PasosVálidos) {
					celda = dgvTablero[paso.X + 1, 7 - paso.Y];

					if(paso.EsVacía) {
						celda.Value = "•";
						colorCelda = Color.Blue;
					} else {
						celda.Value = paso.Ícono;
						colorCelda = Color.Red;
					}
					celda.Style = new DataGridViewCellStyle(celda.Style) { ForeColor = colorCelda };
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
				this.seleccionada = Pieza.Ninguna;
				return;
			}

			if(!pieza.Mover(dx, dy)) {
				this.dgvTablero.ClearSelection();
				this.seleccionada = Pieza.Ninguna;
				return;
			}

			this.dgvTablero.ClearSelection();
			this.seleccionada = Pieza.Ninguna;
			this.ActualizarTablero();

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

			if(this.juego.HaFinalizado) {
				if(this.juego.Ganador != Pieza.ColorPieza.Ninguno)
					this.NuevaPartida("¡Jaque Mate!", $"Ganó el Equipo {this.juego.Ganador}");
				else
					this.NuevaPartida("¡Es un Empate!", $"La partida finalizó por {this.juego.Empate}");
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

		private void NuevaPartida(string título, string estado) {
			FJuegoNuevo fJuegoNuevo = new FJuegoNuevo(título, estado);
			DialogResult resultado = fJuegoNuevo.ShowDialog();
			switch(resultado) {
			case DialogResult.Ignore:
				this.AlternarControl(false);
				return;
			case DialogResult.Cancel:
				Application.Exit();
				return;
			}

			//Formación estándar: "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR"
			//Formación sin peones: "r2qk2r/1bn2nb1/8/8/8/8/1BN2NB1/R2QK2R"
			//Formación para probar ambigüedades con caballos: "8/2n5/8/8/5n2/2n5/8/8"
			//Formación para probar ambigüedades con alfiles: "8/8/2b1b3/8/2b1B3/8/8/8"
			//Formación de Mate del Pastor: "r1bqkb1r/pppp1ppp/2n2n2/4p2Q/2B1P3/8/PPPP1PPP/RNB1K1NR"
			//Formación para probar Rey Ahogado: "1N5k/p4Q1p/P6P/5N2/8/1p6/3N4/R1B1KB2"
			this.juego = new Ajedrez("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR");
			this.seleccionada = Pieza.Ninguna;
			this.turno = Pieza.ColorPieza.Blanco;
			this.ActualizarTablero();
			this.AlternarControl(true);
		}

		private void btnVolverMenu_Click(object sender, EventArgs e) {
			if(this.juego == null) {
				this.NuevaPartida("Menú", "Comienza la partida o sal cuando gustes.");
				return;
			}

			if(this.juego.HaFinalizado) {
				if(this.juego.Ganador != Pieza.ColorPieza.Ninguno)
					this.NuevaPartida("¡Jaque Mate!", $"Ganó el Equipo {this.juego.Ganador}");
				else
					this.NuevaPartida("¡Es un Empate!", $"La partida finalizó por {this.juego.Empate}");
			}
		}

		private void AlternarControl(bool activarJuego) {
			this.btnMover.Visible
			= this.tbNombrePieza.Visible
			= this.lblPosicion.Visible
			= this.cmbDestinoX.Visible
			= this.cmbDestinoY.Visible
				= activarJuego;

			this.btnVolverMenu.Visible = !activarJuego;
		}
	}
}
