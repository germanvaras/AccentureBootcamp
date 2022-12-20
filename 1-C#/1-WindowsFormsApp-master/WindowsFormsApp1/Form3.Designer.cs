
namespace WindowsFormsApp1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPrimerNota = new System.Windows.Forms.TextBox();
            this.txtSegundaNota = new System.Windows.Forms.TextBox();
            this.txtTercerNota = new System.Windows.Forms.TextBox();
            this.txtCuartaNota = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblPrimerNota = new System.Windows.Forms.Label();
            this.lblSegundaNota = new System.Windows.Forms.Label();
            this.lblTercerNota = new System.Windows.Forms.Label();
            this.lblCuartaNota = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPrimerNota
            // 
            this.txtPrimerNota.Location = new System.Drawing.Point(124, 34);
            this.txtPrimerNota.Name = "txtPrimerNota";
            this.txtPrimerNota.Size = new System.Drawing.Size(100, 20);
            this.txtPrimerNota.TabIndex = 0;
            // 
            // txtSegundaNota
            // 
            this.txtSegundaNota.Location = new System.Drawing.Point(124, 80);
            this.txtSegundaNota.Name = "txtSegundaNota";
            this.txtSegundaNota.Size = new System.Drawing.Size(100, 20);
            this.txtSegundaNota.TabIndex = 1;
            // 
            // txtTercerNota
            // 
            this.txtTercerNota.Location = new System.Drawing.Point(124, 123);
            this.txtTercerNota.Name = "txtTercerNota";
            this.txtTercerNota.Size = new System.Drawing.Size(100, 20);
            this.txtTercerNota.TabIndex = 2;
            // 
            // txtCuartaNota
            // 
            this.txtCuartaNota.Location = new System.Drawing.Point(124, 168);
            this.txtCuartaNota.Name = "txtCuartaNota";
            this.txtCuartaNota.Size = new System.Drawing.Size(100, 20);
            this.txtCuartaNota.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(124, 213);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblPrimerNota
            // 
            this.lblPrimerNota.AutoSize = true;
            this.lblPrimerNota.Location = new System.Drawing.Point(55, 40);
            this.lblPrimerNota.Name = "lblPrimerNota";
            this.lblPrimerNota.Size = new System.Drawing.Size(39, 13);
            this.lblPrimerNota.TabIndex = 5;
            this.lblPrimerNota.Text = "Nota 1";
            // 
            // lblSegundaNota
            // 
            this.lblSegundaNota.AutoSize = true;
            this.lblSegundaNota.Location = new System.Drawing.Point(55, 87);
            this.lblSegundaNota.Name = "lblSegundaNota";
            this.lblSegundaNota.Size = new System.Drawing.Size(39, 13);
            this.lblSegundaNota.TabIndex = 5;
            this.lblSegundaNota.Text = "Nota 2";
            // 
            // lblTercerNota
            // 
            this.lblTercerNota.AutoSize = true;
            this.lblTercerNota.Location = new System.Drawing.Point(55, 130);
            this.lblTercerNota.Name = "lblTercerNota";
            this.lblTercerNota.Size = new System.Drawing.Size(39, 13);
            this.lblTercerNota.TabIndex = 5;
            this.lblTercerNota.Text = "Nota 3";
            // 
            // lblCuartaNota
            // 
            this.lblCuartaNota.AutoSize = true;
            this.lblCuartaNota.Location = new System.Drawing.Point(55, 175);
            this.lblCuartaNota.Name = "lblCuartaNota";
            this.lblCuartaNota.Size = new System.Drawing.Size(39, 13);
            this.lblCuartaNota.TabIndex = 5;
            this.lblCuartaNota.Text = "Nota 4";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCuartaNota);
            this.Controls.Add(this.lblTercerNota);
            this.Controls.Add(this.lblSegundaNota);
            this.Controls.Add(this.lblPrimerNota);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCuartaNota);
            this.Controls.Add(this.txtTercerNota);
            this.Controls.Add(this.txtSegundaNota);
            this.Controls.Add(this.txtPrimerNota);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrimerNota;
        private System.Windows.Forms.TextBox txtSegundaNota;
        private System.Windows.Forms.TextBox txtTercerNota;
        private System.Windows.Forms.TextBox txtCuartaNota;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblPrimerNota;
        private System.Windows.Forms.Label lblSegundaNota;
        private System.Windows.Forms.Label lblTercerNota;
        private System.Windows.Forms.Label lblCuartaNota;
    }
}