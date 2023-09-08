
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
			this.tbCandidato = new System.Windows.Forms.TextBox();
			this.lblEquipo = new System.Windows.Forms.Label();
			this.tbEquipo = new System.Windows.Forms.TextBox();
			this.gbPromoción = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.rbReina = new System.Windows.Forms.RadioButton();
			this.rbAlfil = new System.Windows.Forms.RadioButton();
			this.rbTorre = new System.Windows.Forms.RadioButton();
			this.rbCaballero = new System.Windows.Forms.RadioButton();
			this.btnPromocionar = new System.Windows.Forms.Button();
			this.gbPromoción.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblCandidato
			// 
			this.lblCandidato.AutoSize = true;
			this.lblCandidato.Location = new System.Drawing.Point(12, 41);
			this.lblCandidato.Name = "lblCandidato";
			this.lblCandidato.Size = new System.Drawing.Size(55, 13);
			this.lblCandidato.TabIndex = 0;
			this.lblCandidato.Text = "Candidato";
			// 
			// tbCandidato
			// 
			this.tbCandidato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbCandidato.Location = new System.Drawing.Point(73, 38);
			this.tbCandidato.Name = "tbCandidato";
			this.tbCandidato.ReadOnly = true;
			this.tbCandidato.Size = new System.Drawing.Size(96, 20);
			this.tbCandidato.TabIndex = 1;
			this.tbCandidato.TabStop = false;
			this.tbCandidato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblEquipo
			// 
			this.lblEquipo.AutoSize = true;
			this.lblEquipo.Location = new System.Drawing.Point(12, 15);
			this.lblEquipo.Name = "lblEquipo";
			this.lblEquipo.Size = new System.Drawing.Size(40, 13);
			this.lblEquipo.TabIndex = 0;
			this.lblEquipo.Text = "Equipo";
			// 
			// tbEquipo
			// 
			this.tbEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbEquipo.Location = new System.Drawing.Point(73, 12);
			this.tbEquipo.Name = "tbEquipo";
			this.tbEquipo.ReadOnly = true;
			this.tbEquipo.Size = new System.Drawing.Size(96, 20);
			this.tbEquipo.TabIndex = 1;
			this.tbEquipo.TabStop = false;
			this.tbEquipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// gbPromoción
			// 
			this.gbPromoción.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbPromoción.Controls.Add(this.tableLayoutPanel1);
			this.gbPromoción.Location = new System.Drawing.Point(12, 64);
			this.gbPromoción.Name = "gbPromoción";
			this.gbPromoción.Size = new System.Drawing.Size(157, 108);
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
			this.tableLayoutPanel1.Size = new System.Drawing.Size(151, 89);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// rbReina
			// 
			this.rbReina.AutoSize = true;
			this.rbReina.Checked = true;
			this.rbReina.Location = new System.Drawing.Point(3, 3);
			this.rbReina.Name = "rbReina";
			this.rbReina.Size = new System.Drawing.Size(53, 16);
			this.rbReina.TabIndex = 0;
			this.rbReina.TabStop = true;
			this.rbReina.Text = "Reina";
			this.rbReina.UseVisualStyleBackColor = true;
			// 
			// rbAlfil
			// 
			this.rbAlfil.AutoSize = true;
			this.rbAlfil.Location = new System.Drawing.Point(3, 69);
			this.rbAlfil.Name = "rbAlfil";
			this.rbAlfil.Size = new System.Drawing.Size(41, 17);
			this.rbAlfil.TabIndex = 3;
			this.rbAlfil.Text = "Alfil";
			this.rbAlfil.UseVisualStyleBackColor = true;
			// 
			// rbTorre
			// 
			this.rbTorre.AutoSize = true;
			this.rbTorre.Location = new System.Drawing.Point(3, 25);
			this.rbTorre.Name = "rbTorre";
			this.rbTorre.Size = new System.Drawing.Size(50, 16);
			this.rbTorre.TabIndex = 1;
			this.rbTorre.Text = "Torre";
			this.rbTorre.UseVisualStyleBackColor = true;
			// 
			// rbCaballero
			// 
			this.rbCaballero.AutoSize = true;
			this.rbCaballero.Location = new System.Drawing.Point(3, 47);
			this.rbCaballero.Name = "rbCaballero";
			this.rbCaballero.Size = new System.Drawing.Size(69, 16);
			this.rbCaballero.TabIndex = 2;
			this.rbCaballero.Text = "Caballero";
			this.rbCaballero.UseVisualStyleBackColor = true;
			// 
			// btnPromocionar
			// 
			this.btnPromocionar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPromocionar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnPromocionar.Location = new System.Drawing.Point(12, 178);
			this.btnPromocionar.Name = "btnPromocionar";
			this.btnPromocionar.Size = new System.Drawing.Size(157, 28);
			this.btnPromocionar.TabIndex = 4;
			this.btnPromocionar.Text = "Promocionar";
			this.btnPromocionar.UseVisualStyleBackColor = true;
			// 
			// FPromoción
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(181, 218);
			this.ControlBox = false;
			this.Controls.Add(this.btnPromocionar);
			this.Controls.Add(this.gbPromoción);
			this.Controls.Add(this.tbEquipo);
			this.Controls.Add(this.lblEquipo);
			this.Controls.Add(this.tbCandidato);
			this.Controls.Add(this.lblCandidato);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FPromoción";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Promoción de Peón";
			this.gbPromoción.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCandidato;
		private System.Windows.Forms.Label lblEquipo;
		private System.Windows.Forms.GroupBox gbPromoción;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnPromocionar;
		public System.Windows.Forms.TextBox tbCandidato;
		public System.Windows.Forms.TextBox tbEquipo;
		public System.Windows.Forms.RadioButton rbReina;
		public System.Windows.Forms.RadioButton rbAlfil;
		public System.Windows.Forms.RadioButton rbTorre;
		public System.Windows.Forms.RadioButton rbCaballero;
	}
}