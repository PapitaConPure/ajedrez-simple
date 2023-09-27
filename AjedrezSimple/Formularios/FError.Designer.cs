
namespace AjedrezSimple {
	partial class FError {
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
			this.panelPrincipal = new System.Windows.Forms.Panel();
			this.lblEstado = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.btnSalir = new ControLib.SleekButton();
			this.panelPrincipal.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelPrincipal
			// 
			this.panelPrincipal.Controls.Add(this.lblEstado);
			this.panelPrincipal.Controls.Add(this.panel1);
			this.panelPrincipal.Controls.Add(this.btnSalir);
			this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
			this.panelPrincipal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panelPrincipal.Name = "panelPrincipal";
			this.panelPrincipal.Padding = new System.Windows.Forms.Padding(12, 13, 12, 13);
			this.panelPrincipal.Size = new System.Drawing.Size(368, 188);
			this.panelPrincipal.TabIndex = 0;
			// 
			// lblEstado
			// 
			this.lblEstado.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblEstado.Location = new System.Drawing.Point(12, 43);
			this.lblEstado.Margin = new System.Windows.Forms.Padding(0);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Padding = new System.Windows.Forms.Padding(3, 6, 3, 0);
			this.lblEstado.Size = new System.Drawing.Size(344, 95);
			this.lblEstado.TabIndex = 5;
			this.lblEstado.Text = "Mensaje de error. Mensaje de error. Mensaje de error. Mensaje de error. Mensaje d" +
    "e error. Mensaje de error. Mensaje de error. Mensaje de error. ";
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.Controls.Add(this.lblTitle);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(12, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(344, 30);
			this.panel1.TabIndex = 8;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(102)))), ((int)(((byte)(74)))));
			this.lblTitle.Location = new System.Drawing.Point(0, 0);
			this.lblTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(78, 30);
			this.lblTitle.TabIndex = 6;
			this.lblTitle.Text = "Título";
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(61)))), ((int)(((byte)(109)))));
			this.btnSalir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.btnSalir.BorderRadius = 50F;
			this.btnSalir.BorderSize = 0F;
			this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnSalir.FlatAppearance.BorderSize = 0;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.btnSalir.Location = new System.Drawing.Point(12, 138);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.PercentualRadius = true;
			this.btnSalir.Size = new System.Drawing.Size(344, 37);
			this.btnSalir.TabIndex = 9;
			this.btnSalir.Text = "Cerrar";
			this.btnSalir.UseVisualStyleBackColor = false;
			// 
			// FError
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
			this.ClientSize = new System.Drawing.Size(368, 188);
			this.Controls.Add(this.panelPrincipal);
			this.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FError";
			this.Opacity = 0D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Error";
			this.panelPrincipal.ResumeLayout(false);
			this.panelPrincipal.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelPrincipal;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.Panel panel1;
		private ControLib.SleekButton btnSalir;
	}
}