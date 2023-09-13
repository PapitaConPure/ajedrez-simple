
namespace AjedrezSimple {
	partial class FPromoción {
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
			this.lblCandidato = new System.Windows.Forms.Label();
			this.tbCandidato = new ControLib.SleekTextBox();
			this.lblEquipo = new System.Windows.Forms.Label();
			this.tbEquipo = new ControLib.SleekTextBox();
			this.gbPromoción = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.rbReina = new ControLib.SleekRadioButton();
			this.rbAlfil = new ControLib.SleekRadioButton();
			this.rbTorre = new ControLib.SleekRadioButton();
			this.rbCaballero = new ControLib.SleekRadioButton();
			this.btnPromocionar = new ControLib.SleekButton();
			this.gbPromoción.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblCandidato
			// 
			this.lblCandidato.Location = new System.Drawing.Point(12, 42);
			this.lblCandidato.Name = "lblCandidato";
			this.lblCandidato.Size = new System.Drawing.Size(55, 24);
			this.lblCandidato.TabIndex = 0;
			this.lblCandidato.Text = "Candidato";
			this.lblCandidato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbCandidato
			// 
			this.tbCandidato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbCandidato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
			this.tbCandidato.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.tbCandidato.BorderRadius = 100F;
			this.tbCandidato.BorderSize = 0F;
			this.tbCandidato.Cursor = System.Windows.Forms.Cursors.Default;
			this.tbCandidato.FocusColor = System.Drawing.Color.Empty;
			this.tbCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCandidato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.tbCandidato.InputColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(239)))));
			this.tbCandidato.InputText = "";
			this.tbCandidato.Location = new System.Drawing.Point(73, 42);
			this.tbCandidato.MinimumSize = new System.Drawing.Size(20, 24);
			this.tbCandidato.Multiline = true;
			this.tbCandidato.Name = "tbCandidato";
			this.tbCandidato.PasswordChar = '\0';
			this.tbCandidato.PercentualRadius = true;
			this.tbCandidato.PlaceHolder = "Candidato";
			this.tbCandidato.PlaceHolderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(88)))), ((int)(((byte)(116)))));
			this.tbCandidato.ReadOnly = true;
			this.tbCandidato.SelectAllOnClick = true;
			this.tbCandidato.Size = new System.Drawing.Size(96, 24);
			this.tbCandidato.Style = ControLib.SleekTextBox.TextBoxStyle.RoundRect;
			this.tbCandidato.TabIndex = 1;
			this.tbCandidato.TabStop = false;
			this.tbCandidato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbCandidato.WordWrap = true;
			// 
			// lblEquipo
			// 
			this.lblEquipo.Location = new System.Drawing.Point(12, 15);
			this.lblEquipo.Name = "lblEquipo";
			this.lblEquipo.Size = new System.Drawing.Size(55, 21);
			this.lblEquipo.TabIndex = 0;
			this.lblEquipo.Text = "Equipo";
			this.lblEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbEquipo
			// 
			this.tbEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
			this.tbEquipo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.tbEquipo.BorderRadius = 100F;
			this.tbEquipo.BorderSize = 0F;
			this.tbEquipo.Cursor = System.Windows.Forms.Cursors.Default;
			this.tbEquipo.FocusColor = System.Drawing.Color.Empty;
			this.tbEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbEquipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.tbEquipo.InputColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(239)))));
			this.tbEquipo.InputText = "Equipo";
			this.tbEquipo.Location = new System.Drawing.Point(73, 12);
			this.tbEquipo.MinimumSize = new System.Drawing.Size(20, 24);
			this.tbEquipo.Multiline = true;
			this.tbEquipo.Name = "tbEquipo";
			this.tbEquipo.PasswordChar = '\0';
			this.tbEquipo.PercentualRadius = true;
			this.tbEquipo.PlaceHolder = "Equipo";
			this.tbEquipo.PlaceHolderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(88)))), ((int)(((byte)(116)))));
			this.tbEquipo.ReadOnly = true;
			this.tbEquipo.SelectAllOnClick = true;
			this.tbEquipo.Size = new System.Drawing.Size(96, 24);
			this.tbEquipo.Style = ControLib.SleekTextBox.TextBoxStyle.RoundRect;
			this.tbEquipo.TabIndex = 1;
			this.tbEquipo.TabStop = false;
			this.tbEquipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbEquipo.WordWrap = true;
			// 
			// gbPromoción
			// 
			this.gbPromoción.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbPromoción.Controls.Add(this.tableLayoutPanel1);
			this.gbPromoción.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
			this.gbPromoción.Location = new System.Drawing.Point(12, 72);
			this.gbPromoción.Name = "gbPromoción";
			this.gbPromoción.Size = new System.Drawing.Size(157, 119);
			this.gbPromoción.TabIndex = 0;
			this.gbPromoción.TabStop = false;
			this.gbPromoción.Text = "Selecciona una Promoción";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.rbReina, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.rbAlfil, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.rbTorre, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.rbCaballero, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(151, 100);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// rbReina
			// 
			this.rbReina.BorderSize = 16F;
			this.rbReina.BorderWidth = 2F;
			this.rbReina.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(237)))), ((int)(((byte)(6)))));
			this.rbReina.Checked = true;
			this.rbReina.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(190)))), ((int)(((byte)(71)))));
			this.rbReina.CheckSize = 11F;
			this.rbReina.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rbReina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbReina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(102)))), ((int)(((byte)(78)))));
			this.rbReina.Location = new System.Drawing.Point(3, 3);
			this.rbReina.MinimumSize = new System.Drawing.Size(0, 21);
			this.rbReina.Name = "rbReina";
			this.rbReina.Size = new System.Drawing.Size(145, 21);
			this.rbReina.TabIndex = 0;
			this.rbReina.TabStop = true;
			this.rbReina.Text = "Reina";
			this.rbReina.TextPadding = 4F;
			this.rbReina.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(114)))), ((int)(((byte)(226)))));
			this.rbReina.UseVisualStyleBackColor = true;
			// 
			// rbAlfil
			// 
			this.rbAlfil.BorderSize = 16F;
			this.rbAlfil.BorderWidth = 2F;
			this.rbAlfil.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(237)))), ((int)(((byte)(6)))));
			this.rbAlfil.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(190)))), ((int)(((byte)(71)))));
			this.rbAlfil.CheckSize = 11F;
			this.rbAlfil.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rbAlfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.rbAlfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.rbAlfil.Location = new System.Drawing.Point(3, 78);
			this.rbAlfil.MinimumSize = new System.Drawing.Size(0, 21);
			this.rbAlfil.Name = "rbAlfil";
			this.rbAlfil.Size = new System.Drawing.Size(145, 21);
			this.rbAlfil.TabIndex = 3;
			this.rbAlfil.Text = "Alfil";
			this.rbAlfil.TextPadding = 4F;
			this.rbAlfil.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(114)))), ((int)(((byte)(226)))));
			this.rbAlfil.UseVisualStyleBackColor = true;
			// 
			// rbTorre
			// 
			this.rbTorre.BorderSize = 16F;
			this.rbTorre.BorderWidth = 2F;
			this.rbTorre.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(237)))), ((int)(((byte)(6)))));
			this.rbTorre.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(190)))), ((int)(((byte)(71)))));
			this.rbTorre.CheckSize = 11F;
			this.rbTorre.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rbTorre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.rbTorre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.rbTorre.Location = new System.Drawing.Point(3, 28);
			this.rbTorre.MinimumSize = new System.Drawing.Size(0, 21);
			this.rbTorre.Name = "rbTorre";
			this.rbTorre.Size = new System.Drawing.Size(145, 21);
			this.rbTorre.TabIndex = 1;
			this.rbTorre.Text = "Torre";
			this.rbTorre.TextPadding = 4F;
			this.rbTorre.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(114)))), ((int)(((byte)(226)))));
			this.rbTorre.UseVisualStyleBackColor = true;
			// 
			// rbCaballero
			// 
			this.rbCaballero.BorderSize = 16F;
			this.rbCaballero.BorderWidth = 2F;
			this.rbCaballero.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(237)))), ((int)(((byte)(6)))));
			this.rbCaballero.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(190)))), ((int)(((byte)(71)))));
			this.rbCaballero.CheckSize = 11F;
			this.rbCaballero.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rbCaballero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.rbCaballero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.rbCaballero.Location = new System.Drawing.Point(3, 53);
			this.rbCaballero.MinimumSize = new System.Drawing.Size(0, 21);
			this.rbCaballero.Name = "rbCaballero";
			this.rbCaballero.Size = new System.Drawing.Size(145, 21);
			this.rbCaballero.TabIndex = 2;
			this.rbCaballero.Text = "Caballero";
			this.rbCaballero.TextPadding = 4F;
			this.rbCaballero.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(114)))), ((int)(((byte)(226)))));
			this.rbCaballero.UseVisualStyleBackColor = true;
			// 
			// btnPromocionar
			// 
			this.btnPromocionar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPromocionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(237)))), ((int)(((byte)(23)))));
			this.btnPromocionar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(190)))), ((int)(((byte)(71)))));
			this.btnPromocionar.BorderRadius = 12F;
			this.btnPromocionar.BorderSize = 0F;
			this.btnPromocionar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnPromocionar.FlatAppearance.BorderSize = 0;
			this.btnPromocionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPromocionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPromocionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
			this.btnPromocionar.Location = new System.Drawing.Point(12, 197);
			this.btnPromocionar.Name = "btnPromocionar";
			this.btnPromocionar.PercentualRadius = false;
			this.btnPromocionar.Size = new System.Drawing.Size(157, 44);
			this.btnPromocionar.TabIndex = 4;
			this.btnPromocionar.Text = "Promocionar";
			this.btnPromocionar.UseVisualStyleBackColor = false;
			// 
			// FPromoción
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
			this.ClientSize = new System.Drawing.Size(181, 253);
			this.ControlBox = false;
			this.Controls.Add(this.btnPromocionar);
			this.Controls.Add(this.gbPromoción);
			this.Controls.Add(this.tbEquipo);
			this.Controls.Add(this.lblEquipo);
			this.Controls.Add(this.tbCandidato);
			this.Controls.Add(this.lblCandidato);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FPromoción";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Promoción de Peón";
			this.gbPromoción.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblCandidato;
		private System.Windows.Forms.Label lblEquipo;
		private System.Windows.Forms.GroupBox gbPromoción;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private ControLib.SleekButton btnPromocionar;
		public ControLib.SleekTextBox tbCandidato;
		public ControLib.SleekTextBox tbEquipo;
		public ControLib.SleekRadioButton rbReina;
		public ControLib.SleekRadioButton rbAlfil;
		public ControLib.SleekRadioButton rbTorre;
		public ControLib.SleekRadioButton rbCaballero;
	}
}