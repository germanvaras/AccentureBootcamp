
namespace GermanVaras_VectoresWindoLab
{
    partial class Form5
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
            this.btnCargarProvincias = new System.Windows.Forms.Button();
            this.btnCargaTemperaturas = new System.Windows.Forms.Button();
            this.btnTrimestral = new System.Windows.Forms.Button();
            this.btnMayorTemperatura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargarProvincias
            // 
            this.btnCargarProvincias.Location = new System.Drawing.Point(363, 84);
            this.btnCargarProvincias.Name = "btnCargarProvincias";
            this.btnCargarProvincias.Size = new System.Drawing.Size(123, 23);
            this.btnCargarProvincias.TabIndex = 0;
            this.btnCargarProvincias.Text = "Cargar Provincias";
            this.btnCargarProvincias.UseVisualStyleBackColor = true;
            this.btnCargarProvincias.Click += new System.EventHandler(this.btnCargarProvincias_Click);
            // 
            // btnCargaTemperaturas
            // 
            this.btnCargaTemperaturas.Location = new System.Drawing.Point(363, 142);
            this.btnCargaTemperaturas.Name = "btnCargaTemperaturas";
            this.btnCargaTemperaturas.Size = new System.Drawing.Size(123, 23);
            this.btnCargaTemperaturas.TabIndex = 1;
            this.btnCargaTemperaturas.Text = "Cargar Temperaturas";
            this.btnCargaTemperaturas.UseVisualStyleBackColor = true;
            this.btnCargaTemperaturas.Click += new System.EventHandler(this.btnCargaTemperaturas_Click);
            // 
            // btnTrimestral
            // 
            this.btnTrimestral.Location = new System.Drawing.Point(363, 208);
            this.btnTrimestral.Name = "btnTrimestral";
            this.btnTrimestral.Size = new System.Drawing.Size(123, 23);
            this.btnTrimestral.TabIndex = 2;
            this.btnTrimestral.Text = "Temperatura Trimestral";
            this.btnTrimestral.UseVisualStyleBackColor = true;
            this.btnTrimestral.Click += new System.EventHandler(this.btnTrimestral_Click);
            // 
            // btnMayorTemperatura
            // 
            this.btnMayorTemperatura.Location = new System.Drawing.Point(363, 272);
            this.btnMayorTemperatura.Name = "btnMayorTemperatura";
            this.btnMayorTemperatura.Size = new System.Drawing.Size(123, 23);
            this.btnMayorTemperatura.TabIndex = 2;
            this.btnMayorTemperatura.Text = "btnTemperaturaMayor";
            this.btnMayorTemperatura.UseVisualStyleBackColor = true;
            this.btnMayorTemperatura.Click += new System.EventHandler(this.btnMayorTemperatura_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMayorTemperatura);
            this.Controls.Add(this.btnTrimestral);
            this.Controls.Add(this.btnCargaTemperaturas);
            this.Controls.Add(this.btnCargarProvincias);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarProvincias;
        private System.Windows.Forms.Button btnCargaTemperaturas;
        private System.Windows.Forms.Button btnTrimestral;
        private System.Windows.Forms.Button btnMayorTemperatura;
    }
}