
namespace AjedrezSimple {
	partial class FConfiguración {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.btnComenzar = new ControLib.SleekButton();
			this.btnSalir = new ControLib.SleekButton();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblPGN = new System.Windows.Forms.Label();
			this.lblFEN = new System.Windows.Forms.Label();
			this.tbFEN = new ControLib.SleekTextBox();
			this.tbPGN = new ControLib.SleekTextBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnComenzar
			// 
			this.btnComenzar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(237)))), ((int)(((byte)(23)))));
			this.btnComenzar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(190)))), ((int)(((byte)(71)))));
			this.btnComenzar.BorderRadius = 50F;
			this.btnComenzar.BorderSize = 0F;
			this.btnComenzar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnComenzar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnComenzar.FlatAppearance.BorderSize = 0;
			this.btnComenzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnComenzar.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnComenzar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.btnComenzar.Location = new System.Drawing.Point(3, 3);
			this.btnComenzar.Name = "btnComenzar";
			this.btnComenzar.PercentualRadius = true;
			this.btnComenzar.Size = new System.Drawing.Size(113, 39);
			this.btnComenzar.TabIndex = 0;
			this.btnComenzar.Text = "Comenzar";
			this.btnComenzar.UseVisualStyleBackColor = false;
			this.btnComenzar.Click += new System.EventHandler(this.Button_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(61)))), ((int)(((byte)(109)))));
			this.btnSalir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.btnSalir.BorderRadius = 50F;
			this.btnSalir.BorderSize = 0F;
			this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSalir.FlatAppearance.BorderSize = 0;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.btnSalir.Location = new System.Drawing.Point(122, 3);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.PercentualRadius = true;
			this.btnSalir.Size = new System.Drawing.Size(113, 39);
			this.btnSalir.TabIndex = 1;
			this.btnSalir.Text = "Cancelar";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.Button_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.btnComenzar, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnSalir, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 254);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(238, 45);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.lblPGN);
			this.panel1.Controls.Add(this.lblFEN);
			this.panel1.Controls.Add(this.tbFEN);
			this.panel1.Controls.Add(this.tbPGN);
			this.panel1.Controls.Add(this.lblTitle);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(238, 236);
			this.panel1.TabIndex = 6;
			// 
			// lblPGN
			// 
			this.lblPGN.Font = new System.Drawing.Font("Lato Black", 9F, System.Drawing.FontStyle.Bold);
			this.lblPGN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(112)))), ((int)(((byte)(207)))));
			this.lblPGN.Location = new System.Drawing.Point(3, 94);
			this.lblPGN.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
			this.lblPGN.Name = "lblPGN";
			this.lblPGN.Size = new System.Drawing.Size(35, 24);
			this.lblPGN.TabIndex = 8;
			this.lblPGN.Text = "PGN";
			this.lblPGN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblFEN
			// 
			this.lblFEN.Font = new System.Drawing.Font("Lato Black", 9F, System.Drawing.FontStyle.Bold);
			this.lblFEN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(112)))), ((int)(((byte)(207)))));
			this.lblFEN.Location = new System.Drawing.Point(3, 36);
			this.lblFEN.Margin = new System.Windows.Forms.Padding(3, 3, 1, 1);
			this.lblFEN.Name = "lblFEN";
			this.lblFEN.Size = new System.Drawing.Size(35, 24);
			this.lblFEN.TabIndex = 8;
			this.lblFEN.Text = "FEN";
			this.lblFEN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbFEN
			// 
			this.tbFEN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbFEN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
			this.tbFEN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.tbFEN.BorderRadius = 100F;
			this.tbFEN.BorderSize = 0F;
			this.tbFEN.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbFEN.FocusColor = System.Drawing.Color.Empty;
			this.tbFEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbFEN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.tbFEN.InputColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(186)))), ((int)(((byte)(218)))));
			this.tbFEN.InputText = "";
			this.tbFEN.Location = new System.Drawing.Point(3, 61);
			this.tbFEN.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
			this.tbFEN.MinimumSize = new System.Drawing.Size(20, 24);
			this.tbFEN.Multiline = false;
			this.tbFEN.Name = "tbFEN";
			this.tbFEN.PasswordChar = '\0';
			this.tbFEN.PercentualRadius = true;
			this.tbFEN.PlaceHolder = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR";
			this.tbFEN.PlaceHolderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(88)))), ((int)(((byte)(116)))));
			this.tbFEN.ReadOnly = false;
			this.tbFEN.SelectAllOnClick = true;
			this.tbFEN.Size = new System.Drawing.Size(232, 24);
			this.tbFEN.Style = ControLib.SleekTextBox.TextBoxStyle.RoundRect;
			this.tbFEN.TabIndex = 2;
			this.tbFEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbFEN.WordWrap = true;
			// 
			// tbPGN
			// 
			this.tbPGN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPGN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
			this.tbPGN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.tbPGN.BorderRadius = 12F;
			this.tbPGN.BorderSize = 0F;
			this.tbPGN.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbPGN.FocusColor = System.Drawing.Color.Empty;
			this.tbPGN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPGN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.tbPGN.InputColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(186)))), ((int)(((byte)(218)))));
			this.tbPGN.InputText = "";
			this.tbPGN.Location = new System.Drawing.Point(3, 119);
			this.tbPGN.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.tbPGN.MinimumSize = new System.Drawing.Size(20, 24);
			this.tbPGN.Multiline = true;
			this.tbPGN.Name = "tbPGN";
			this.tbPGN.PasswordChar = '\0';
			this.tbPGN.PercentualRadius = false;
			this.tbPGN.PlaceHolder = "1. e4 e5 2. Qh5 Nc6 3. Bc4 Nf6 4. Qxf7#";
			this.tbPGN.PlaceHolderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(88)))), ((int)(((byte)(116)))));
			this.tbPGN.ReadOnly = false;
			this.tbPGN.SelectAllOnClick = true;
			this.tbPGN.Size = new System.Drawing.Size(232, 114);
			this.tbPGN.Style = ControLib.SleekTextBox.TextBoxStyle.RoundRect;
			this.tbPGN.TabIndex = 3;
			this.tbPGN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.tbPGN.WordWrap = true;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(0, 0);
			this.lblTitle.Margin = new System.Windows.Forms.Padding(3);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(167, 30);
			this.lblTitle.TabIndex = 5;
			this.lblTitle.Text = "Configuración";
			// 
			// FConfiguración
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
			this.ClientSize = new System.Drawing.Size(262, 311);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FConfiguración";
			this.Opacity = 0D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Configuración";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private ControLib.SleekButton btnComenzar;
		private ControLib.SleekButton btnSalir;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblTitle;
		public ControLib.SleekTextBox tbPGN;
		public ControLib.SleekTextBox tbFEN;
		private System.Windows.Forms.Label lblFEN;
		private System.Windows.Forms.Label lblPGN;
	}
}