
namespace WindowsLab
{
    partial class Form2
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
            this.ldbEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnRango = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ldbEdad
            // 
            this.ldbEdad.AutoSize = true;
            this.ldbEdad.Location = new System.Drawing.Point(88, 62);
            this.ldbEdad.Name = "ldbEdad";
            this.ldbEdad.Size = new System.Drawing.Size(32, 13);
            this.ldbEdad.TabIndex = 0;
            this.ldbEdad.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(150, 59);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 1;
            // 
            // btnRango
            // 
            this.btnRango.Location = new System.Drawing.Point(82, 104);
            this.btnRango.Name = "btnRango";
            this.btnRango.Size = new System.Drawing.Size(75, 23);
            this.btnRango.TabIndex = 2;
            this.btnRango.Text = "Calcular Rango";
            this.btnRango.UseVisualStyleBackColor = true;
            this.btnRango.Click += new System.EventHandler(this.btnRango_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRango);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.ldbEdad);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ldbEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnRango;
    }
}