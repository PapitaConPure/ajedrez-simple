
namespace AjedrezSimple {
	partial class FPrincipal {
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent() {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPrincipal));
			this.btnMover = new System.Windows.Forms.Button();
			this.lsbHistorialBlancas = new System.Windows.Forms.ListBox();
			this.dgvTablero = new System.Windows.Forms.DataGridView();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gbControl = new System.Windows.Forms.GroupBox();
			this.btnVolverMenu = new System.Windows.Forms.Button();
			this.tbNombrePieza = new System.Windows.Forms.TextBox();
			this.lblPosicion = new System.Windows.Forms.Label();
			this.cmbDestinoY = new System.Windows.Forms.ComboBox();
			this.cmbDestinoX = new System.Windows.Forms.ComboBox();
			this.gbHistorial = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblBlancas = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lsbHistorialNegras = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvTablero)).BeginInit();
			this.gbControl.SuspendLayout();
			this.gbHistorial.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnMover
			// 
			this.btnMover.BackColor = System.Drawing.Color.White;
			this.btnMover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMover.ForeColor = System.Drawing.Color.Black;
			this.btnMover.Location = new System.Drawing.Point(6, 19);
			this.btnMover.Name = "btnMover";
			this.btnMover.Size = new System.Drawing.Size(164, 23);
			this.btnMover.TabIndex = 3;
			this.btnMover.Text = "Mover...";
			this.btnMover.UseVisualStyleBackColor = false;
			this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
			// 
			// lsbHistorialBlancas
			// 
			this.lsbHistorialBlancas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lsbHistorialBlancas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.lsbHistorialBlancas.FormattingEnabled = true;
			this.lsbHistorialBlancas.IntegralHeight = false;
			this.lsbHistorialBlancas.ItemHeight = 15;
			this.lsbHistorialBlancas.Location = new System.Drawing.Point(3, 3);
			this.lsbHistorialBlancas.Name = "lsbHistorialBlancas";
			this.lsbHistorialBlancas.Size = new System.Drawing.Size(76, 292);
			this.lsbHistorialBlancas.TabIndex = 4;
			this.lsbHistorialBlancas.TabStop = false;
			// 
			// dgvTablero
			// 
			this.dgvTablero.AllowUserToAddRows = false;
			this.dgvTablero.AllowUserToDeleteRows = false;
			this.dgvTablero.AllowUserToResizeColumns = false;
			this.dgvTablero.AllowUserToResizeRows = false;
			this.dgvTablero.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvTablero.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvTablero.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTablero.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvTablero.ColumnHeadersHeight = 30;
			this.dgvTablero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvTablero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTablero.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvTablero.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvTablero.GridColor = System.Drawing.Color.DarkSlateGray;
			this.dgvTablero.Location = new System.Drawing.Point(194, 12);
			this.dgvTablero.MultiSelect = false;
			this.dgvTablero.Name = "dgvTablero";
			this.dgvTablero.ReadOnly = true;
			this.dgvTablero.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTablero.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvTablero.RowHeadersVisible = false;
			this.dgvTablero.RowHeadersWidth = 30;
			this.dgvTablero.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvTablero.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvTablero.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dgvTablero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvTablero.Size = new System.Drawing.Size(421, 421);
			this.dgvTablero.StandardTab = true;
			this.dgvTablero.TabIndex = 0;
			this.dgvTablero.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgvTablero_CellStateChanged);
			// 
			// Column9
			// 
			this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column9.HeaderText = "";
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			this.Column9.Width = 30;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "A";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "B";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "C";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "D";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "E";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "F";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "G";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			// 
			// Column8
			// 
			this.Column8.HeaderText = "H";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			// 
			// gbControl
			// 
			this.gbControl.Controls.Add(this.btnVolverMenu);
			this.gbControl.Controls.Add(this.tbNombrePieza);
			this.gbControl.Controls.Add(this.lblPosicion);
			this.gbControl.Controls.Add(this.cmbDestinoY);
			this.gbControl.Controls.Add(this.cmbDestinoX);
			this.gbControl.Controls.Add(this.btnMover);
			this.gbControl.Location = new System.Drawing.Point(12, 12);
			this.gbControl.Name = "gbControl";
			this.gbControl.Size = new System.Drawing.Size(176, 79);
			this.gbControl.TabIndex = 0;
			this.gbControl.TabStop = false;
			this.gbControl.Text = "Control";
			// 
			// btnVolverMenu
			// 
			this.btnVolverMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnVolverMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnVolverMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVolverMenu.ForeColor = System.Drawing.Color.Black;
			this.btnVolverMenu.Location = new System.Drawing.Point(6, 19);
			this.btnVolverMenu.Name = "btnVolverMenu";
			this.btnVolverMenu.Size = new System.Drawing.Size(164, 54);
			this.btnVolverMenu.TabIndex = 4;
			this.btnVolverMenu.Text = "Volver al Menú";
			this.btnVolverMenu.UseVisualStyleBackColor = false;
			this.btnVolverMenu.Visible = false;
			this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
			// 
			// tbNombrePieza
			// 
			this.tbNombrePieza.Location = new System.Drawing.Point(6, 48);
			this.tbNombrePieza.Name = "tbNombrePieza";
			this.tbNombrePieza.ReadOnly = true;
			this.tbNombrePieza.Size = new System.Drawing.Size(65, 20);
			this.tbNombrePieza.TabIndex = 0;
			this.tbNombrePieza.TabStop = false;
			this.tbNombrePieza.Text = "Pieza";
			this.tbNombrePieza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblPosicion
			// 
			this.lblPosicion.AutoSize = true;
			this.lblPosicion.Location = new System.Drawing.Point(77, 51);
			this.lblPosicion.Name = "lblPosicion";
			this.lblPosicion.Size = new System.Drawing.Size(19, 13);
			this.lblPosicion.TabIndex = 3;
			this.lblPosicion.Text = " a ";
			// 
			// cmbDestinoY
			// 
			this.cmbDestinoY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDestinoY.FormattingEnabled = true;
			this.cmbDestinoY.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
			this.cmbDestinoY.Location = new System.Drawing.Point(139, 48);
			this.cmbDestinoY.Name = "cmbDestinoY";
			this.cmbDestinoY.Size = new System.Drawing.Size(31, 21);
			this.cmbDestinoY.TabIndex = 2;
			// 
			// cmbDestinoX
			// 
			this.cmbDestinoX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDestinoX.FormattingEnabled = true;
			this.cmbDestinoX.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
			this.cmbDestinoX.Location = new System.Drawing.Point(102, 48);
			this.cmbDestinoX.Name = "cmbDestinoX";
			this.cmbDestinoX.Size = new System.Drawing.Size(31, 21);
			this.cmbDestinoX.TabIndex = 1;
			// 
			// gbHistorial
			// 
			this.gbHistorial.Controls.Add(this.label1);
			this.gbHistorial.Controls.Add(this.lblBlancas);
			this.gbHistorial.Controls.Add(this.tableLayoutPanel1);
			this.gbHistorial.Location = new System.Drawing.Point(12, 97);
			this.gbHistorial.Name = "gbHistorial";
			this.gbHistorial.Size = new System.Drawing.Size(176, 336);
			this.gbHistorial.TabIndex = 0;
			this.gbHistorial.TabStop = false;
			this.gbHistorial.Text = "Historial";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(129, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Negras";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblBlancas
			// 
			this.lblBlancas.AutoSize = true;
			this.lblBlancas.Location = new System.Drawing.Point(6, 16);
			this.lblBlancas.Name = "lblBlancas";
			this.lblBlancas.Size = new System.Drawing.Size(45, 13);
			this.lblBlancas.TabIndex = 2;
			this.lblBlancas.Text = "Blancas";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.lsbHistorialBlancas, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lsbHistorialNegras, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 32);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(164, 298);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// lsbHistorialNegras
			// 
			this.lsbHistorialNegras.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lsbHistorialNegras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.lsbHistorialNegras.FormattingEnabled = true;
			this.lsbHistorialNegras.IntegralHeight = false;
			this.lsbHistorialNegras.ItemHeight = 15;
			this.lsbHistorialNegras.Location = new System.Drawing.Point(85, 3);
			this.lsbHistorialNegras.Name = "lsbHistorialNegras";
			this.lsbHistorialNegras.Size = new System.Drawing.Size(76, 292);
			this.lsbHistorialNegras.TabIndex = 5;
			this.lsbHistorialNegras.TabStop = false;
			// 
			// FPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnVolverMenu;
			this.ClientSize = new System.Drawing.Size(627, 445);
			this.Controls.Add(this.gbHistorial);
			this.Controls.Add(this.gbControl);
			this.Controls.Add(this.dgvTablero);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "FPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ajedrez";
			this.Load += new System.EventHandler(this.FPrincipal_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FPrincipal_KeyPress);
			((System.ComponentModel.ISupportInitialize)(this.dgvTablero)).EndInit();
			this.gbControl.ResumeLayout(false);
			this.gbControl.PerformLayout();
			this.gbHistorial.ResumeLayout(false);
			this.gbHistorial.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnMover;
		private System.Windows.Forms.ListBox lsbHistorialBlancas;
		private System.Windows.Forms.DataGridView dgvTablero;
		private System.Windows.Forms.GroupBox gbControl;
		private System.Windows.Forms.ComboBox cmbDestinoX;
		private System.Windows.Forms.ComboBox cmbDestinoY;
		private System.Windows.Forms.Label lblPosicion;
		private System.Windows.Forms.TextBox tbNombrePieza;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.GroupBox gbHistorial;
		private System.Windows.Forms.ListBox lsbHistorialNegras;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblBlancas;
		private System.Windows.Forms.Button btnVolverMenu;
	}
}

