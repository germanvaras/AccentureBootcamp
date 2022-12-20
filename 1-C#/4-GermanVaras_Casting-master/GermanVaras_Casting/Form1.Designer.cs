
namespace GermanVaras_Casting
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
            this.txtImplicito = new System.Windows.Forms.TextBox();
            this.txtExplicito = new System.Windows.Forms.TextBox();
            this.txtString = new System.Windows.Forms.TextBox();
            this.btnImplicito = new System.Windows.Forms.Button();
            this.btnExplicito = new System.Windows.Forms.Button();
            this.btnString = new System.Windows.Forms.Button();
            this.blnNum1 = new System.Windows.Forms.Label();
            this.blnNum2 = new System.Windows.Forms.Label();
            this.blnNum3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtImplicito
            // 
            this.txtImplicito.Location = new System.Drawing.Point(103, 75);
            this.txtImplicito.Name = "txtImplicito";
            this.txtImplicito.Size = new System.Drawing.Size(100, 20);
            this.txtImplicito.TabIndex = 0;
            // 
            // txtExplicito
            // 
            this.txtExplicito.Location = new System.Drawing.Point(345, 75);
            this.txtExplicito.Name = "txtExplicito";
            this.txtExplicito.Size = new System.Drawing.Size(100, 20);
            this.txtExplicito.TabIndex = 0;
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(595, 75);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(100, 20);
            this.txtString.TabIndex = 0;
            // 
            // btnImplicito
            // 
            this.btnImplicito.Location = new System.Drawing.Point(103, 128);
            this.btnImplicito.Name = "btnImplicito";
            this.btnImplicito.Size = new System.Drawing.Size(75, 23);
            this.btnImplicito.TabIndex = 1;
            this.btnImplicito.Text = "Implicito";
            this.btnImplicito.UseVisualStyleBackColor = true;
            this.btnImplicito.Click += new System.EventHandler(this.btnImplicito_Click);
            // 
            // btnExplicito
            // 
            this.btnExplicito.Location = new System.Drawing.Point(345, 127);
            this.btnExplicito.Name = "btnExplicito";
            this.btnExplicito.Size = new System.Drawing.Size(75, 23);
            this.btnExplicito.TabIndex = 2;
            this.btnExplicito.Text = "Explicito";
            this.btnExplicito.UseVisualStyleBackColor = true;
            this.btnExplicito.Click += new System.EventHandler(this.btnExplicito_Click);
            // 
            // btnString
            // 
            this.btnString.Location = new System.Drawing.Point(595, 127);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(75, 23);
            this.btnString.TabIndex = 2;
            this.btnString.Text = "A string";
            this.btnString.UseVisualStyleBackColor = true;
            this.btnString.Click += new System.EventHandler(this.btnString_Click);
            // 
            // blnNum1
            // 
            this.blnNum1.AutoSize = true;
            this.blnNum1.Location = new System.Drawing.Point(103, 42);
            this.blnNum1.Name = "blnNum1";
            this.blnNum1.Size = new System.Drawing.Size(53, 13);
            this.blnNum1.TabIndex = 3;
            this.blnNum1.Text = "Numero 1";
            // 
            // blnNum2
            // 
            this.blnNum2.AutoSize = true;
            this.blnNum2.Location = new System.Drawing.Point(342, 42);
            this.blnNum2.Name = "blnNum2";
            this.blnNum2.Size = new System.Drawing.Size(53, 13);
            this.blnNum2.TabIndex = 3;
            this.blnNum2.Text = "Numero 2";
            // 
            // blnNum3
            // 
            this.blnNum3.AutoSize = true;
            this.blnNum3.Location = new System.Drawing.Point(592, 42);
            this.blnNum3.Name = "blnNum3";
            this.blnNum3.Size = new System.Drawing.Size(53, 13);
            this.blnNum3.TabIndex = 3;
            this.blnNum3.Text = "Numero 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.blnNum3);
            this.Controls.Add(this.blnNum2);
            this.Controls.Add(this.blnNum1);
            this.Controls.Add(this.btnString);
            this.Controls.Add(this.btnExplicito);
            this.Controls.Add(this.btnImplicito);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.txtExplicito);
            this.Controls.Add(this.txtImplicito);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImplicito;
        private System.Windows.Forms.TextBox txtExplicito;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Button btnImplicito;
        private System.Windows.Forms.Button btnExplicito;
        private System.Windows.Forms.Button btnString;
        private System.Windows.Forms.Label blnNum1;
        private System.Windows.Forms.Label blnNum2;
        private System.Windows.Forms.Label blnNum3;
    }
}

