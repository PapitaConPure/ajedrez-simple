using System;
using System.Drawing;
using System.Windows.Forms;

namespace AjedrezSimple {
	public partial class FPrincipal: Form {
		#region Fuentes y Colores
		private static readonly Font fuentePiezas = new Font("Arial", 28);
		private static readonly Color ColorPiezaBlanca = Color.White;
		private static readonly Color ColorPiezaNegra = Color.Black;
		private static readonly Color ColorCeldaBlanca = Color.FromArgb(227, 196, 125);
		private static readonly Color ColorCeldaNegra = Color.FromArgb(163, 120, 82);
		private static readonly Color ColorCeldaPaso = Color.FromArgb(77, 59, 173);
		private static readonly Color ColorCeldaBlancaCaptura = Color.FromArgb(240, 52, 14);
		private static readonly Color ColorCeldaNegraCaptura = Color.FromArgb(255, 94, 61);
		private static readonly Color ColorCeldaResaltado = Color.FromArgb(93, 214, 34);
		#endregion

		private Ajedrez juego;
		private DataGridViewCell últimaCeldaSeleccionada;
		private DataGridViewCell últimoOrigen;
		private DataGridViewCell últimoDestino;
		private Pieza seleccionada;
		private Pieza.ColorPieza turno;
		private Color colorBotónBlanco;
		private Color colorBotónNegro;
		private bool espectando = false;

		public FPrincipal() {
			this.InitializeComponent();

			this.dgvTablero.Rows.Add(8);

			int alturaTotal = this.dgvTablero.Height - this.dgvTablero.ColumnHeadersHeight;
			int alturaFila = (int)Math.Round(1d * alturaTotal / this.dgvTablero.RowCount);
			int c = 0;

			DataGridViewCell cabezaFila;
			DataGridViewCellStyle estiloCelda;
			bool esBlanca;

			foreach(DataGridViewColumn column in this.dgvTablero.Columns) {
				column.HeaderCell.Style = this.dgvTablero.ColumnHeadersDefaultCellStyle;
				column.SortMode = DataGridViewColumnSortMode.NotSortable;
			}

			foreach(DataGridViewRow row in this.dgvTablero.Rows) {
				cabezaFila = row.Cells[0];
				cabezaFila.Value = $"{8 - c}";
				cabezaFila.Style = this.dgvTablero.ColumnHeadersDefaultCellStyle;
				row.Height = alturaFila;
				for(int i = 0; i < 8; i++) {
					estiloCelda = new DataGridViewCellStyle(row.Cells[i + 1].Style);
					esBlanca = (c + i) % 2 == 0;

					if(esBlanca)
						estiloCelda.BackColor = ColorCeldaBlanca;
					else
						estiloCelda.BackColor = ColorCeldaNegra;

					estiloCelda.Font = fuentePiezas;

					row.Cells[i + 1].Style = estiloCelda;
				}
				c++;
			}

			DataGridViewRow ultima = this.dgvTablero.Rows[this.dgvTablero.RowCount - 1];
			ultima.Height = alturaTotal - alturaFila * (this.dgvTablero.RowCount - 1);
			this.dgvTablero.ClearSelection();
			this.dgvHistorial.ClearSelection();
			this.dgvHistorial.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

			this.cmbDestinoX.SelectedIndex = this.cmbDestinoY.SelectedIndex = 0;
		}

		private void FPrincipal_Load(object sender, EventArgs e) {
			colorBotónBlanco = this.btnMover.BackColor;
			colorBotónNegro = this.btnMover.ForeColor;
			this.NuevaPartida(1);
		}

		private void btnMover_Click(object sender, EventArgs e) {
			this.MoverPiezaSeleccionada(this.cmbDestinoX.SelectedIndex, this.cmbDestinoY.SelectedIndex);
		}

		private void dgvTablero_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e) {
			if(this.juego == null) {
				this.dgvTablero.ClearSelection();
				return;
			}

			DataGridViewCell celda = e.Cell;

			if(celda == null)
				return;

			if(celda.State != DataGridViewElementStates.Selected) {
				this.ActualizarTablero();
				return;
			}

			if(celda.ColumnIndex == 0) {
				this.dgvTablero.ClearSelection();
				if(últimaCeldaSeleccionada != null)
					this.últimaCeldaSeleccionada.Selected = true;
				return;
			} else
				this.últimaCeldaSeleccionada = celda;

			if(this.seleccionada is NoPieza) {
				Pieza pieza = this.juego[this.CasillaX(celda.ColumnIndex), this.CasillaY(celda.RowIndex)];
				this.seleccionada = pieza;
				this.tbNombrePieza.InputText = pieza.Nombre;
				this.ActualizarTablero();
			} else {
				int dx = this.CasillaX(celda.ColumnIndex);
				int dy = this.CasillaY(celda.RowIndex);

				this.cmbDestinoX.SelectedIndex = dx;
				this.cmbDestinoY.SelectedIndex = dy;
				this.tbNombrePieza.InputText = "";
				this.MoverPiezaSeleccionada(dx, dy);
			}
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

		private void dgvHistorial_KeyDown(object sender, KeyEventArgs e) {
			int diff = 0;

			switch(e.KeyCode) {
			case Keys.Up:       diff--;    break;
			case Keys.Down:     diff++;    break;
			case Keys.PageUp:   diff -= 5; break;
			case Keys.PageDown: diff += 5; break;
			}

			int value = this.dgvHistorial.FirstDisplayedScrollingRowIndex + diff;
			this.dgvHistorial.FirstDisplayedScrollingRowIndex = Math.Max(0, Math.Min(value, this.dgvHistorial.RowCount - 1));
		}

		private void btnVolverMenu_Click(object sender, EventArgs e) {
			this.NuevaPartida(0.25);
		}

		private void ActualizarTablero() {
			foreach(DataGridViewRow fila in this.dgvTablero.Rows)
				foreach(DataGridViewCell c in fila.Cells)
					if(c.ColumnIndex > 0)
						c.Value = "";

			DataGridViewCell celda;
			Color colorCelda;
			foreach(Pieza pieza in this.juego.Piezas) {
				celda = this.VerCelda(pieza.X, pieza.Y);

				celda.Value = pieza.Ícono;
				if(pieza.Color == Pieza.ColorPieza.Blanco)
					colorCelda = ColorPiezaBlanca;
				else
					colorCelda = ColorPiezaNegra;

				celda.Style = new DataGridViewCellStyle(celda.Style) { ForeColor = colorCelda };
			}

			if(this.seleccionada.Color == this.turno)
				foreach(Pieza paso in this.seleccionada.PasosVálidos) {
					celda = this.VerCelda(paso.X, paso.Y);

					if(paso.EsVacía) {
						celda.Value = "•";
						colorCelda = ColorCeldaPaso;
					} else {
						celda.Value = paso.Ícono;
						if(this.EsCasillaBlanca(celda))
							colorCelda = ColorCeldaBlancaCaptura;
						else
							colorCelda = ColorCeldaNegraCaptura;
					}

					celda.Style = new DataGridViewCellStyle(celda.Style) { ForeColor = colorCelda };
				}
		}

		private void ActualizarHistorial() {
			Registro registro = this.juego.ÚltimoRegistro;
			DataGridViewRow rowActual;

			if(registro.Emisora.Color == Pieza.ColorPieza.Blanco) {
				rowActual = this.dgvHistorial.Rows[this.dgvHistorial.Rows.Add()];
				rowActual.Cells[0].Value = $"{this.juego.Historial.Length / 2 + 1}.";
				rowActual.Cells[1].Value = registro;
			} else if(registro.Emisora.Color == Pieza.ColorPieza.Negro) {
				rowActual = this.dgvHistorial.Rows[this.dgvHistorial.RowCount - 1];
				rowActual.Cells[2].Value = registro;
			}

			this.dgvHistorial.FirstDisplayedScrollingRowIndex = this.dgvHistorial.RowCount - 1;
		}

		private void MoverPiezaSeleccionada(int dx, int dy) {
			Pieza pieza = this.seleccionada;
			this.dgvTablero.ClearSelection();

			if(espectando)
				return;

			this.seleccionada = Pieza.Ninguna;

			if(pieza.Color != this.turno)
				return;

			if(!pieza.Mover(dx, dy))
				return;

			this.ActualizarTablero();

			if(this.últimoOrigen != null) {
				DataGridViewCellStyle estiloCelda = new DataGridViewCellStyle(this.últimoOrigen.Style);
				if(this.EsCasillaBlanca(this.últimoOrigen))
					estiloCelda.BackColor = ColorCeldaBlanca;
				else
					estiloCelda.BackColor = ColorCeldaNegra;
				this.últimoOrigen.Style = estiloCelda;

				estiloCelda = new DataGridViewCellStyle(this.últimoDestino.Style);
				this.últimoDestino.Style = new DataGridViewCellStyle(this.últimoDestino.Style) { BackColor = ColorCeldaResaltado };
				if(this.EsCasillaBlanca(this.últimoDestino))
					estiloCelda.BackColor = ColorCeldaBlanca;
				else
					estiloCelda.BackColor = ColorCeldaNegra;
				this.últimoDestino.Style = estiloCelda;

				this.últimoOrigen = null;
				this.últimoDestino = null;
			}

			int ox, oy;
			pieza.VerÚltimaPosición(out ox, out oy);
			DataGridViewCell celdaOrigen = this.VerCelda(ox, oy);
			DataGridViewCell celdaDestino = this.VerCelda(dx, dy);
			celdaOrigen.Style = new DataGridViewCellStyle(celdaOrigen.Style) { BackColor = ColorCeldaResaltado };
			celdaDestino.Style = new DataGridViewCellStyle(celdaDestino.Style) { BackColor = ColorCeldaResaltado };
			this.últimoOrigen = celdaOrigen;
			this.últimoDestino = celdaDestino;

			if(pieza is Peón)
				this.PromocionarPeón(pieza as Peón);
			
			this.ActualizarHistorial();

			this.turno = pieza.ColorContrario;
			this.juego.IniciarNuevoTurno(this.turno);

			if(this.turno == Pieza.ColorPieza.Blanco) {
				this.btnMover.BackColor = colorBotónBlanco;
				this.btnMover.ForeColor = colorBotónNegro;
			} else {
				this.btnMover.BackColor = colorBotónNegro;
				this.btnMover.ForeColor = colorBotónBlanco;
			}

			this.NuevaPartida(0.5);
		}

		private void PromocionarPeón(Peón peón) {
			if(!peón.EnPosiciónFinal)
				return;

			FPromoción fPromoción = new FPromoción();
			fPromoción.tbEquipo.InputText = peón.Color.ToString();
			fPromoción.tbCandidato.InputText = peón.ToString();
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

		private void NuevaPartida(double segundosEntrada) {
			string título;
			string estado;
			if(this.juego == null) {
				título = "Comenzar Juego";
				estado = "Este será el primer Juego de hoy. Puedes comenzar cuando quieras.";
			} else if(this.juego.HaFinalizado) {
				if(this.juego.Ganador != Pieza.ColorPieza.Ninguno) {
					título = "¡Jaque Mate!";
					estado = $"Ganó el Equipo {this.juego.Ganador}.";
				} else {
					título = "¡Es un Empate!";
					estado = $"La partida finalizó por {this.juego.Empate}.";
				}
			} else
				return;

			FJuegoNuevo fJuegoNuevo = new FJuegoNuevo(título, estado, segundosEntrada);
			fJuegoNuevo.btnVerPartida.Enabled = this.juego != null;
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
			//Formación para escenario de jaque de prueba 1: "3ppp2/3pkp2/3p1p2/rb4br/8/Q7/8/6K1"
			//Formación para escenario de jaque de prueba 2: "3ppp2/3pkp2/3p1p2/rb4br/8/Q7/8/6K1"
			//Formación para promoción seguida de jaque mate: "k7/pppppp1P/8/8/8/8/8/K7"
			//Formación para Insuficiencia Material 1: "k7/8/8/3n4/8/5P2/8/K7"
			//Formación para Insuficiencia Material 2: "8/3k4/8/2bbbb2/2BBBB2/8/3K4/8"
			//Formación para Insuficiencia Material 2: "8/3k4/8/2p5/5P2/8/3K4/8"
			this.juego = new Ajedrez();
			this.seleccionada = Pieza.Ninguna;
			this.turno = Pieza.ColorPieza.Blanco;
			this.ActualizarTablero();
			this.dgvHistorial.Rows.Clear();
			this.AlternarControl(true);
		}

		private void AlternarControl(bool activarJuego) {
			this.btnMover.Visible
			= this.tbNombrePieza.Visible
			= this.lblPosicion.Visible
			= this.cmbDestinoX.Visible
			= this.cmbDestinoY.Visible
				= activarJuego;

			this.btnVolverMenu.Visible = this.espectando = !activarJuego;
			
			if(this.espectando) {
				this.dgvTablero.ClearSelection();
				this.seleccionada = Pieza.Ninguna;
			}
		}

		#region Mapeo de casillas con el DataGridView (Por si quiero rotar el tablero)
		private DataGridViewCell VerCasilla(int x, int y) {
			return this.dgvTablero[this.CasillaX(x), this.CasillaY(y)];
		}

		private int CasillaX(int x) {
			return x - 1;
		}

		private int CasillaY(int y) {
			return 7 - y;
		}

		private DataGridViewCell VerCelda(int x, int y) {
			return this.dgvTablero[this.CeldaX(x), this.CeldaY(y)];
		}

		private int CeldaX(int x) {
			return x + 1;
		}

		private int CeldaY(int y) {
			return 7 - y;
		}

		private bool EsCasillaBlanca(DataGridViewCell celda) {
			int x = this.CasillaX(celda.ColumnIndex);
			int y = this.CasillaY(celda.RowIndex);
			return (x + y * 9) % 2 == 1;
		}
		#endregion
	}
}
