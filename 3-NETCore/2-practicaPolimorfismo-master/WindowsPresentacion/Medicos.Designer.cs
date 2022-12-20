
namespace WindowsPresentacion
{
    partial class Medicos
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
            this.btnCargarPersona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargarPersona
            // 
            this.btnCargarPersona.Location = new System.Drawing.Point(336, 161);
            this.btnCargarPersona.Name = "btnCargarPersona";
            this.btnCargarPersona.Size = new System.Drawing.Size(186, 23);
            this.btnCargarPersona.TabIndex = 0;
            this.btnCargarPersona.Text = "Cargar Persona";
            this.btnCargarPersona.UseVisualStyleBackColor = true;
            this.btnCargarPersona.Click += new System.EventHandler(this.btnCargarPersona_Click);
            // 
            // Medicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCargarPersona);
            this.Name = "Medicos";
            this.Text = "Medicos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarPersona;
    }
}