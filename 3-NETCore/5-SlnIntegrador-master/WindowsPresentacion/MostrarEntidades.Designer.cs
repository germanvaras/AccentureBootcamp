
namespace WindowsPresentacion
{
    partial class MostrarEntidades
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
            this.gridDatos = new System.Windows.Forms.DataGridView();
            this.btnMostrarMedicos = new System.Windows.Forms.Button();
            this.btnMostrarPacientes = new System.Windows.Forms.Button();
            this.btnMostarHabitaciones = new System.Windows.Forms.Button();
            this.lstMedicosClinicos = new System.Windows.Forms.ListBox();
            this.lstHabitaciones = new System.Windows.Forms.ListBox();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.lstEdadPacientes = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDatos
            // 
            this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDatos.Location = new System.Drawing.Point(95, 267);
            this.gridDatos.Name = "gridDatos";
            this.gridDatos.Size = new System.Drawing.Size(619, 150);
            this.gridDatos.TabIndex = 0;
            // 
            // btnMostrarMedicos
            // 
            this.btnMostrarMedicos.Location = new System.Drawing.Point(95, 69);
            this.btnMostrarMedicos.Name = "btnMostrarMedicos";
            this.btnMostrarMedicos.Size = new System.Drawing.Size(205, 23);
            this.btnMostrarMedicos.TabIndex = 1;
            this.btnMostrarMedicos.Text = "Mostrar Medicos";
            this.btnMostrarMedicos.UseVisualStyleBackColor = true;
            this.btnMostrarMedicos.Click += new System.EventHandler(this.btnMostrarMedicos_Click);
            // 
            // btnMostrarPacientes
            // 
            this.btnMostrarPacientes.Location = new System.Drawing.Point(331, 69);
            this.btnMostrarPacientes.Name = "btnMostrarPacientes";
            this.btnMostrarPacientes.Size = new System.Drawing.Size(169, 23);
            this.btnMostrarPacientes.TabIndex = 1;
            this.btnMostrarPacientes.Text = "Mostrar Pacientes";
            this.btnMostrarPacientes.UseVisualStyleBackColor = true;
            this.btnMostrarPacientes.Click += new System.EventHandler(this.btnMostrarPacientes_Click);
            // 
            // btnMostarHabitaciones
            // 
            this.btnMostarHabitaciones.Location = new System.Drawing.Point(523, 69);
            this.btnMostarHabitaciones.Name = "btnMostarHabitaciones";
            this.btnMostarHabitaciones.Size = new System.Drawing.Size(191, 23);
            this.btnMostarHabitaciones.TabIndex = 1;
            this.btnMostarHabitaciones.Text = "Mostrar Habitaciones";
            this.btnMostarHabitaciones.UseVisualStyleBackColor = true;
            this.btnMostarHabitaciones.Click += new System.EventHandler(this.btnMostarHabitaciones_Click);
            // 
            // lstMedicosClinicos
            // 
            this.lstMedicosClinicos.FormattingEnabled = true;
            this.lstMedicosClinicos.Location = new System.Drawing.Point(95, 145);
            this.lstMedicosClinicos.Name = "lstMedicosClinicos";
            this.lstMedicosClinicos.Size = new System.Drawing.Size(205, 95);
            this.lstMedicosClinicos.TabIndex = 2;
            // 
            // lstHabitaciones
            // 
            this.lstHabitaciones.FormattingEnabled = true;
            this.lstHabitaciones.Location = new System.Drawing.Point(523, 145);
            this.lstHabitaciones.Name = "lstHabitaciones";
            this.lstHabitaciones.Size = new System.Drawing.Size(191, 95);
            this.lstHabitaciones.TabIndex = 2;
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Location = new System.Drawing.Point(593, 129);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(69, 13);
            this.lblHabitacion.TabIndex = 3;
            this.lblHabitacion.Text = "Habitaciones";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(168, 129);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(47, 13);
            this.lblMedico.TabIndex = 3;
            this.lblMedico.Text = "Medicos";
            // 
            // lstEdadPacientes
            // 
            this.lstEdadPacientes.FormattingEnabled = true;
            this.lstEdadPacientes.Location = new System.Drawing.Point(312, 145);
            this.lstEdadPacientes.Name = "lstEdadPacientes";
            this.lstEdadPacientes.Size = new System.Drawing.Size(205, 95);
            this.lstEdadPacientes.TabIndex = 2;
            // 
            // MostrarEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.lstHabitaciones);
            this.Controls.Add(this.lstEdadPacientes);
            this.Controls.Add(this.lstMedicosClinicos);
            this.Controls.Add(this.btnMostarHabitaciones);
            this.Controls.Add(this.btnMostrarPacientes);
            this.Controls.Add(this.btnMostrarMedicos);
            this.Controls.Add(this.gridDatos);
            this.Name = "MostrarEntidades";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDatos;
        private System.Windows.Forms.Button btnMostrarMedicos;
        private System.Windows.Forms.Button btnMostrarPacientes;
        private System.Windows.Forms.Button btnMostarHabitaciones;
        private System.Windows.Forms.ListBox lstMedicosClinicos;
        private System.Windows.Forms.ListBox lstHabitaciones;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.ListBox lstEdadPacientes;
    }
}

