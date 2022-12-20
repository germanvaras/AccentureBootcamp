
namespace WindowsPresentacion
{
    partial class Form1
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
            this.btnCargarEmpleados1 = new System.Windows.Forms.Button();
            this.lstEmpleados1 = new System.Windows.Forms.ListBox();
            this.btnCargarMas = new System.Windows.Forms.Button();
            this.lstEmpleados2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCargarEmpleados1
            // 
            this.btnCargarEmpleados1.Location = new System.Drawing.Point(152, 154);
            this.btnCargarEmpleados1.Name = "btnCargarEmpleados1";
            this.btnCargarEmpleados1.Size = new System.Drawing.Size(180, 23);
            this.btnCargarEmpleados1.TabIndex = 0;
            this.btnCargarEmpleados1.Text = "Carga de dos empleados";
            this.btnCargarEmpleados1.UseVisualStyleBackColor = true;
            this.btnCargarEmpleados1.Click += new System.EventHandler(this.btnCargarEmpleados1_Click);
            // 
            // lstEmpleados1
            // 
            this.lstEmpleados1.FormattingEnabled = true;
            this.lstEmpleados1.Location = new System.Drawing.Point(152, 216);
            this.lstEmpleados1.Name = "lstEmpleados1";
            this.lstEmpleados1.Size = new System.Drawing.Size(180, 95);
            this.lstEmpleados1.TabIndex = 1;
            // 
            // btnCargarMas
            // 
            this.btnCargarMas.Location = new System.Drawing.Point(453, 154);
            this.btnCargarMas.Name = "btnCargarMas";
            this.btnCargarMas.Size = new System.Drawing.Size(180, 23);
            this.btnCargarMas.TabIndex = 0;
            this.btnCargarMas.Text = "Carga de dos mas";
            this.btnCargarMas.UseVisualStyleBackColor = true;
            this.btnCargarMas.Click += new System.EventHandler(this.btnCargarMas_Click);
            // 
            // lstEmpleados2
            // 
            this.lstEmpleados2.FormattingEnabled = true;
            this.lstEmpleados2.Location = new System.Drawing.Point(453, 216);
            this.lstEmpleados2.Name = "lstEmpleados2";
            this.lstEmpleados2.Size = new System.Drawing.Size(180, 95);
            this.lstEmpleados2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstEmpleados2);
            this.Controls.Add(this.lstEmpleados1);
            this.Controls.Add(this.btnCargarMas);
            this.Controls.Add(this.btnCargarEmpleados1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarEmpleados1;
        private System.Windows.Forms.ListBox lstEmpleados1;
        private System.Windows.Forms.Button btnCargarMas;
        private System.Windows.Forms.ListBox lstEmpleados2;
    }
}

