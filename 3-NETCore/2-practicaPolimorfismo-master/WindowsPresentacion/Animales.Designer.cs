
namespace WindowsPresentacion
{
    partial class Animales
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
            this.btnCargarAnimales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargarAnimales
            // 
            this.btnCargarAnimales.Location = new System.Drawing.Point(330, 173);
            this.btnCargarAnimales.Name = "btnCargarAnimales";
            this.btnCargarAnimales.Size = new System.Drawing.Size(154, 23);
            this.btnCargarAnimales.TabIndex = 0;
            this.btnCargarAnimales.Text = "Carga de Animales";
            this.btnCargarAnimales.UseVisualStyleBackColor = true;
            this.btnCargarAnimales.Click += new System.EventHandler(this.btnCargarAnimales_Click);
            // 
            // Animales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCargarAnimales);
            this.Name = "Animales";
            this.Text = "Animales";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarAnimales;
    }
}