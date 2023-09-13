
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPrincipal));
			this.btnMover = new ControLib.SleekButton();
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
			this.btnVolverMenu = new ControLib.SleekButton();
			this.tbNombrePieza = new ControLib.SleekTextBox();
			this.lblPosicion = new System.Windows.Forms.Label();
			this.cmbDestinoY = new System.Windows.Forms.ComboBox();
			this.cmbDestinoX = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblBlancas = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lsbHistorialNegras = new System.Windows.Forms.ListBox();
			this.panelIzquierdo = new System.Windows.Forms.Panel();
			this.panelHistorial = new System.Windows.Forms.Panel();
			this.panelControl = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dgvTablero)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.panelIzquierdo.SuspendLayout();
			this.panelHistorial.SuspendLayout();
			this.panelControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnMover
			// 
			this.btnMover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.btnMover.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.btnMover.BorderRadius = 12F;
			this.btnMover.BorderSize = 2F;
			this.btnMover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
			this.btnMover.Location = new System.Drawing.Point(12, 12);
			this.btnMover.Name = "btnMover";
			this.btnMover.PercentualRadius = false;
			this.btnMover.Size = new System.Drawing.Size(165, 27);
			this.btnMover.TabIndex = 3;
			this.btnMover.Text = "Mover...";
			this.btnMover.UseVisualStyleBackColor = false;
			this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
			// 
			// lsbHistorialBlancas
			// 
			this.lsbHistorialBlancas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(61)))), ((int)(((byte)(101)))));
			this.lsbHistorialBlancas.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lsbHistorialBlancas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lsbHistorialBlancas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.lsbHistorialBlancas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.lsbHistorialBlancas.FormattingEnabled = true;
			this.lsbHistorialBlancas.IntegralHeight = false;
			this.lsbHistorialBlancas.ItemHeight = 15;
			this.lsbHistorialBlancas.Location = new System.Drawing.Point(3, 3);
			this.lsbHistorialBlancas.Name = "lsbHistorialBlancas";
			this.lsbHistorialBlancas.Size = new System.Drawing.Size(76, 323);
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
			this.dgvTablero.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
			this.dgvTablero.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvTablero.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvTablero.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
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
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTablero.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvTablero.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvTablero.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvTablero.GridColor = System.Drawing.Color.DarkSlateGray;
			this.dgvTablero.Location = new System.Drawing.Point(189, 0);
			this.dgvTablero.MultiSelect = false;
			this.dgvTablero.Name = "dgvTablero";
			this.dgvTablero.ReadOnly = true;
			this.dgvTablero.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTablero.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvTablero.RowHeadersVisible = false;
			this.dgvTablero.RowHeadersWidth = 30;
			this.dgvTablero.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvTablero.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvTablero.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dgvTablero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvTablero.Size = new System.Drawing.Size(445, 445);
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
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
			this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
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
			// btnVolverMenu
			// 
			this.btnVolverMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnVolverMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(237)))), ((int)(((byte)(23)))));
			this.btnVolverMenu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(190)))), ((int)(((byte)(71)))));
			this.btnVolverMenu.BorderRadius = 12F;
			this.btnVolverMenu.BorderSize = 0F;
			this.btnVolverMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnVolverMenu.FlatAppearance.BorderSize = 0;
			this.btnVolverMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVolverMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVolverMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.btnVolverMenu.Location = new System.Drawing.Point(12, 12);
			this.btnVolverMenu.Name = "btnVolverMenu";
			this.btnVolverMenu.PercentualRadius = false;
			this.btnVolverMenu.Size = new System.Drawing.Size(165, 54);
			this.btnVolverMenu.TabIndex = 4;
			this.btnVolverMenu.Text = "Volver al Menú";
			this.btnVolverMenu.UseVisualStyleBackColor = false;
			this.btnVolverMenu.Visible = false;
			this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
			// 
			// tbNombrePieza
			// 
			this.tbNombrePieza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbNombrePieza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
			this.tbNombrePieza.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.tbNombrePieza.BorderRadius = 10F;
			this.tbNombrePieza.BorderSize = 0F;
			this.tbNombrePieza.Cursor = System.Windows.Forms.Cursors.Default;
			this.tbNombrePieza.FocusColor = System.Drawing.Color.Empty;
			this.tbNombrePieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNombrePieza.ForeColor = System.Drawing.SystemColors.WindowText;
			this.tbNombrePieza.InputColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(239)))));
			this.tbNombrePieza.InputText = "";
			this.tbNombrePieza.Location = new System.Drawing.Point(12, 46);
			this.tbNombrePieza.MinimumSize = new System.Drawing.Size(20, 20);
			this.tbNombrePieza.Multiline = false;
			this.tbNombrePieza.Name = "tbNombrePieza";
			this.tbNombrePieza.PasswordChar = '\0';
			this.tbNombrePieza.PercentualRadius = false;
			this.tbNombrePieza.PlaceHolder = "Pieza";
			this.tbNombrePieza.PlaceHolderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(88)))), ((int)(((byte)(116)))));
			this.tbNombrePieza.ReadOnly = true;
			this.tbNombrePieza.SelectAllOnClick = true;
			this.tbNombrePieza.Size = new System.Drawing.Size(66, 21);
			this.tbNombrePieza.Style = ControLib.SleekTextBox.TextBoxStyle.RoundRect;
			this.tbNombrePieza.TabIndex = 0;
			this.tbNombrePieza.TabStop = false;
			this.tbNombrePieza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbNombrePieza.WordWrap = true;
			// 
			// lblPosicion
			// 
			this.lblPosicion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPosicion.AutoSize = true;
			this.lblPosicion.Location = new System.Drawing.Point(84, 48);
			this.lblPosicion.Name = "lblPosicion";
			this.lblPosicion.Size = new System.Drawing.Size(19, 13);
			this.lblPosicion.TabIndex = 3;
			this.lblPosicion.Text = " a ";
			// 
			// cmbDestinoY
			// 
			this.cmbDestinoY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
			this.cmbDestinoY.Location = new System.Drawing.Point(146, 45);
			this.cmbDestinoY.Name = "cmbDestinoY";
			this.cmbDestinoY.Size = new System.Drawing.Size(31, 21);
			this.cmbDestinoY.TabIndex = 2;
			// 
			// cmbDestinoX
			// 
			this.cmbDestinoX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
			this.cmbDestinoX.Location = new System.Drawing.Point(109, 45);
			this.cmbDestinoX.Name = "cmbDestinoX";
			this.cmbDestinoX.Size = new System.Drawing.Size(31, 21);
			this.cmbDestinoX.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(117)))), ((int)(((byte)(223)))));
			this.label1.Location = new System.Drawing.Point(136, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Negras";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblBlancas
			// 
			this.lblBlancas.AutoSize = true;
			this.lblBlancas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(117)))), ((int)(((byte)(223)))));
			this.lblBlancas.Location = new System.Drawing.Point(12, 9);
			this.lblBlancas.Name = "lblBlancas";
			this.lblBlancas.Size = new System.Drawing.Size(45, 13);
			this.lblBlancas.TabIndex = 2;
			this.lblBlancas.Text = "Blancas";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.lsbHistorialBlancas, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lsbHistorialNegras, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 25);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(165, 329);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// lsbHistorialNegras
			// 
			this.lsbHistorialNegras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(61)))), ((int)(((byte)(101)))));
			this.lsbHistorialNegras.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lsbHistorialNegras.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lsbHistorialNegras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.lsbHistorialNegras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.lsbHistorialNegras.FormattingEnabled = true;
			this.lsbHistorialNegras.IntegralHeight = false;
			this.lsbHistorialNegras.ItemHeight = 15;
			this.lsbHistorialNegras.Location = new System.Drawing.Point(85, 3);
			this.lsbHistorialNegras.Name = "lsbHistorialNegras";
			this.lsbHistorialNegras.Size = new System.Drawing.Size(77, 323);
			this.lsbHistorialNegras.TabIndex = 5;
			this.lsbHistorialNegras.TabStop = false;
			// 
			// panelIzquierdo
			// 
			this.panelIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
			this.panelIzquierdo.Controls.Add(this.panelHistorial);
			this.panelIzquierdo.Controls.Add(this.panelControl);
			this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelIzquierdo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
			this.panelIzquierdo.Margin = new System.Windows.Forms.Padding(9);
			this.panelIzquierdo.Name = "panelIzquierdo";
			this.panelIzquierdo.Size = new System.Drawing.Size(189, 445);
			this.panelIzquierdo.TabIndex = 1;
			// 
			// panelHistorial
			// 
			this.panelHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
			this.panelHistorial.Controls.Add(this.label1);
			this.panelHistorial.Controls.Add(this.lblBlancas);
			this.panelHistorial.Controls.Add(this.tableLayoutPanel1);
			this.panelHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelHistorial.Location = new System.Drawing.Point(0, 79);
			this.panelHistorial.Name = "panelHistorial";
			this.panelHistorial.Padding = new System.Windows.Forms.Padding(9);
			this.panelHistorial.Size = new System.Drawing.Size(189, 366);
			this.panelHistorial.TabIndex = 1;
			// 
			// panelControl
			// 
			this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
			this.panelControl.Controls.Add(this.btnVolverMenu);
			this.panelControl.Controls.Add(this.tbNombrePieza);
			this.panelControl.Controls.Add(this.lblPosicion);
			this.panelControl.Controls.Add(this.btnMover);
			this.panelControl.Controls.Add(this.cmbDestinoY);
			this.panelControl.Controls.Add(this.cmbDestinoX);
			this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.panelControl.Location = new System.Drawing.Point(0, 0);
			this.panelControl.Name = "panelControl";
			this.panelControl.Padding = new System.Windows.Forms.Padding(9);
			this.panelControl.Size = new System.Drawing.Size(189, 79);
			this.panelControl.TabIndex = 0;
			// 
			// FPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.CancelButton = this.btnVolverMenu;
			this.ClientSize = new System.Drawing.Size(634, 445);
			this.Controls.Add(this.dgvTablero);
			this.Controls.Add(this.panelIzquierdo);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
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
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panelIzquierdo.ResumeLayout(false);
			this.panelHistorial.ResumeLayout(false);
			this.panelHistorial.PerformLayout();
			this.panelControl.ResumeLayout(false);
			this.panelControl.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private ControLib.SleekButton btnMover;
		private System.Windows.Forms.ListBox lsbHistorialBlancas;
		private System.Windows.Forms.DataGridView dgvTablero;
		private System.Windows.Forms.ComboBox cmbDestinoX;
		private System.Windows.Forms.ComboBox cmbDestinoY;
		private System.Windows.Forms.Label lblPosicion;
		private ControLib.SleekTextBox tbNombrePieza;
		private System.Windows.Forms.ListBox lsbHistorialNegras;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblBlancas;
		private ControLib.SleekButton btnVolverMenu;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.Panel panelIzquierdo;
		private System.Windows.Forms.Panel panelControl;
		private System.Windows.Forms.Panel panelHistorial;
	}
}

