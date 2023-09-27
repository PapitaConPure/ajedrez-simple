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
			this.btnComenzar = new ControLib.SleekButton();
			this.btnSalir = new ControLib.SleekButton();
			this.lblEstado = new System.Windows.Forms.Label();
			this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
			this.btnVerPartida = new ControLib.SleekButton();
			this.pcbÍcono = new System.Windows.Forms.PictureBox();
			this.splcPrincipal = new System.Windows.Forms.SplitContainer();
			this.lblTitle = new System.Windows.Forms.Label();
			this.tlpBotones.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbÍcono)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splcPrincipal)).BeginInit();
			this.splcPrincipal.Panel1.SuspendLayout();
			this.splcPrincipal.Panel2.SuspendLayout();
			this.splcPrincipal.SuspendLayout();
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
			this.btnComenzar.Size = new System.Drawing.Size(110, 41);
			this.btnComenzar.TabIndex = 0;
			this.btnComenzar.Text = "Juego Nuevo";
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
			this.btnSalir.Location = new System.Drawing.Point(235, 3);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.PercentualRadius = true;
			this.btnSalir.Size = new System.Drawing.Size(110, 41);
			this.btnSalir.TabIndex = 2;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.Button_Click);
			// 
			// lblEstado
			// 
			this.lblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblEstado.Location = new System.Drawing.Point(0, 36);
			this.lblEstado.Margin = new System.Windows.Forms.Padding(3);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.lblEstado.Size = new System.Drawing.Size(345, 44);
			this.lblEstado.TabIndex = 2;
			this.lblEstado.Text = "Estado de la última partida. Estado de la última partida. Estado de la última par" +
    "tida.";
			// 
			// tlpBotones
			// 
			this.tlpBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tlpBotones.ColumnCount = 3;
			this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpBotones.Controls.Add(this.btnComenzar, 0, 0);
			this.tlpBotones.Controls.Add(this.btnSalir, 2, 0);
			this.tlpBotones.Controls.Add(this.btnVerPartida, 1, 0);
			this.tlpBotones.Location = new System.Drawing.Point(0, 86);
			this.tlpBotones.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.tlpBotones.Name = "tlpBotones";
			this.tlpBotones.RowCount = 1;
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpBotones.Size = new System.Drawing.Size(348, 47);
			this.tlpBotones.TabIndex = 3;
			// 
			// btnVerPartida
			// 
			this.btnVerPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(61)))), ((int)(((byte)(109)))));
			this.btnVerPartida.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.btnVerPartida.BorderRadius = 50F;
			this.btnVerPartida.BorderSize = 0F;
			this.btnVerPartida.DialogResult = System.Windows.Forms.DialogResult.Ignore;
			this.btnVerPartida.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnVerPartida.FlatAppearance.BorderSize = 0;
			this.btnVerPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVerPartida.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVerPartida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.btnVerPartida.Location = new System.Drawing.Point(119, 3);
			this.btnVerPartida.Name = "btnVerPartida";
			this.btnVerPartida.PercentualRadius = true;
			this.btnVerPartida.Size = new System.Drawing.Size(110, 41);
			this.btnVerPartida.TabIndex = 1;
			this.btnVerPartida.Text = "Ver Partida";
			this.btnVerPartida.UseVisualStyleBackColor = false;
			this.btnVerPartida.Click += new System.EventHandler(this.Button_Click);
			// 
			// pcbÍcono
			// 
			this.pcbÍcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pcbÍcono.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pcbÍcono.Image = global::AjedrezSimple.Properties.Resources.game;
			this.pcbÍcono.Location = new System.Drawing.Point(0, 0);
			this.pcbÍcono.Name = "pcbÍcono";
			this.pcbÍcono.Size = new System.Drawing.Size(135, 133);
			this.pcbÍcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcbÍcono.TabIndex = 4;
			this.pcbÍcono.TabStop = false;
			// 
			// splcPrincipal
			// 
			this.splcPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splcPrincipal.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splcPrincipal.Location = new System.Drawing.Point(12, 12);
			this.splcPrincipal.Name = "splcPrincipal";
			// 
			// splcPrincipal.Panel1
			// 
			this.splcPrincipal.Panel1.Controls.Add(this.lblTitle);
			this.splcPrincipal.Panel1.Controls.Add(this.lblEstado);
			this.splcPrincipal.Panel1.Controls.Add(this.tlpBotones);
			// 
			// splcPrincipal.Panel2
			// 
			this.splcPrincipal.Panel2.Controls.Add(this.pcbÍcono);
			this.splcPrincipal.Size = new System.Drawing.Size(484, 133);
			this.splcPrincipal.SplitterDistance = 345;
			this.splcPrincipal.TabIndex = 5;
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
			this.lblTitle.Size = new System.Drawing.Size(78, 30);
			this.lblTitle.TabIndex = 4;
			this.lblTitle.Text = "Título";
			// 
			// FJuegoNuevo
			// 
			this.AcceptButton = this.btnComenzar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
			this.CancelButton = this.btnSalir;
			this.ClientSize = new System.Drawing.Size(508, 157);
			this.ControlBox = false;
			this.Controls.Add(this.splcPrincipal);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FJuegoNuevo";
			this.Opacity = 0D;
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FJuegoNuevo";
			this.tlpBotones.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pcbÍcono)).EndInit();
			this.splcPrincipal.Panel1.ResumeLayout(false);
			this.splcPrincipal.Panel1.PerformLayout();
			this.splcPrincipal.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splcPrincipal)).EndInit();
			this.splcPrincipal.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private ControLib.SleekButton btnComenzar;
		private ControLib.SleekButton btnSalir;
		private System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.TableLayoutPanel tlpBotones;
		private System.Windows.Forms.PictureBox pcbÍcono;
		private System.Windows.Forms.SplitContainer splcPrincipal;
		public ControLib.SleekButton btnVerPartida;
		private System.Windows.Forms.Label lblTitle;
	}
}