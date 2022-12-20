
namespace WindowsPresentacion
{
    partial class MovimientoAjedrez
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
            this.btnMovimiento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMovimiento
            // 
            this.btnMovimiento.Location = new System.Drawing.Point(351, 183);
            this.btnMovimiento.Name = "btnMovimiento";
            this.btnMovimiento.Size = new System.Drawing.Size(147, 23);
            this.btnMovimiento.TabIndex = 0;
            this.btnMovimiento.Text = "Movimiento Ajedrez";
            this.btnMovimiento.UseVisualStyleBackColor = true;
            this.btnMovimiento.Click += new System.EventHandler(this.btnMovimiento_Click);
            // 
            // MovimientoAjedrez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMovimiento);
            this.Name = "MovimientoAjedrez";
            this.Text = "MovimientoAjedrez";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMovimiento;
    }
}