
namespace AjedrezSimple {
	partial class FJuegoNuevo {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FJuegoNuevo));
			this.btnComenzar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.lblEstado = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnVerPartida = new System.Windows.Forms.Button();
			this.pcbÍcono = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbÍcono)).BeginInit();
			this.SuspendLayout();
			// 
			// btnComenzar
			// 
			this.btnComenzar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(237)))), ((int)(((byte)(6)))));
			this.btnComenzar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnComenzar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnComenzar.FlatAppearance.BorderSize = 0;
			this.btnComenzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnComenzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnComenzar.Location = new System.Drawing.Point(3, 3);
			this.btnComenzar.Name = "btnComenzar";
			this.btnComenzar.Size = new System.Drawing.Size(77, 41);
			this.btnComenzar.TabIndex = 0;
			this.btnComenzar.Text = "Juego Nuevo";
			this.btnComenzar.UseVisualStyleBackColor = false;
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Location = new System.Drawing.Point(169, 3);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(79, 41);
			this.btnSalir.TabIndex = 2;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = false;
			// 
			// lblEstado
			// 
			this.lblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblEstado.Location = new System.Drawing.Point(12, 9);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(245, 78);
			this.lblEstado.TabIndex = 2;
			this.lblEstado.Text = "Estado de la última partida.";
			this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.btnComenzar, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnSalir, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnVerPartida, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 87);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(251, 47);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// btnVerPartida
			// 
			this.btnVerPartida.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnVerPartida.DialogResult = System.Windows.Forms.DialogResult.Ignore;
			this.btnVerPartida.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnVerPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVerPartida.Location = new System.Drawing.Point(86, 3);
			this.btnVerPartida.Name = "btnVerPartida";
			this.btnVerPartida.Size = new System.Drawing.Size(77, 41);
			this.btnVerPartida.TabIndex = 1;
			this.btnVerPartida.Text = "Ver Partida";
			this.btnVerPartida.UseVisualStyleBackColor = false;
			// 
			// pcbÍcono
			// 
			this.pcbÍcono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.pcbÍcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pcbÍcono.Image = global::AjedrezSimple.Properties.Resources.game;
			this.pcbÍcono.Location = new System.Drawing.Point(263, 12);
			this.pcbÍcono.Name = "pcbÍcono";
			this.pcbÍcono.Size = new System.Drawing.Size(119, 119);
			this.pcbÍcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcbÍcono.TabIndex = 4;
			this.pcbÍcono.TabStop = false;
			// 
			// FJuegoNuevo
			// 
			this.AcceptButton = this.btnComenzar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnSalir;
			this.ClientSize = new System.Drawing.Size(394, 143);
			this.ControlBox = false;
			this.Controls.Add(this.pcbÍcono);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.lblEstado);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FJuegoNuevo";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FJuegoNuevo";
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pcbÍcono)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnComenzar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnVerPartida;
		private System.Windows.Forms.PictureBox pcbÍcono;
	}
}