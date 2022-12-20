
namespace WindowsPresentacion
{
    partial class AfinarInstrumentos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAfinar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAfinar
            // 
            this.btnAfinar.Location = new System.Drawing.Point(304, 186);
            this.btnAfinar.Name = "btnAfinar";
            this.btnAfinar.Size = new System.Drawing.Size(181, 23);
            this.btnAfinar.TabIndex = 0;
            this.btnAfinar.Text = "Afinar Instrumentos";
            this.btnAfinar.UseVisualStyleBackColor = true;
            this.btnAfinar.Click += new System.EventHandler(this.btnAfinar_Click);
            // 
            // AfinarInstrumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAfinar);
            this.Name = "AfinarInstrumentos";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAfinar;
    }
}

