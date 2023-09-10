
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
			this.btnComenzar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.lblEstado = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnVerPartida = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnComenzar
			// 
			this.btnComenzar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnComenzar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnComenzar.Location = new System.Drawing.Point(3, 3);
			this.btnComenzar.Name = "btnComenzar";
			this.btnComenzar.Size = new System.Drawing.Size(80, 37);
			this.btnComenzar.TabIndex = 0;
			this.btnComenzar.Text = "Juego Nuevo";
			this.btnComenzar.UseVisualStyleBackColor = true;
			// 
			// btnSalir
			// 
			this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSalir.Location = new System.Drawing.Point(175, 3);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(83, 37);
			this.btnSalir.TabIndex = 2;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			// 
			// lblEstado
			// 
			this.lblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblEstado.Location = new System.Drawing.Point(12, 9);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(259, 49);
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
			this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 58);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(261, 43);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// btnVerPartida
			// 
			this.btnVerPartida.DialogResult = System.Windows.Forms.DialogResult.Ignore;
			this.btnVerPartida.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnVerPartida.Location = new System.Drawing.Point(89, 3);
			this.btnVerPartida.Name = "btnVerPartida";
			this.btnVerPartida.Size = new System.Drawing.Size(80, 37);
			this.btnVerPartida.TabIndex = 1;
			this.btnVerPartida.Text = "Ver Partida";
			this.btnVerPartida.UseVisualStyleBackColor = true;
			// 
			// FJuegoNuevo
			// 
			this.AcceptButton = this.btnComenzar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnSalir;
			this.ClientSize = new System.Drawing.Size(279, 110);
			this.ControlBox = false;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.lblEstado);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FJuegoNuevo";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FJuegoNuevo";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnComenzar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnVerPartida;
	}
}