namespace WindowsPeliculas
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelFechaEstreno = new System.Windows.Forms.Label();
            this.lbelDM = new System.Windows.Forms.Label();
            this.labelSinopsis = new System.Windows.Forms.Label();
            this.labelIdioma = new System.Windows.Forms.Label();
            this.dateTimeEstreno = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtSinopsis = new System.Windows.Forms.RichTextBox();
            this.chboxCalificacion1 = new System.Windows.Forms.CheckBox();
            this.chboxCalificacion2 = new System.Windows.Forms.CheckBox();
            this.chboxGenero1 = new System.Windows.Forms.CheckBox();
            this.chboxGenero2 = new System.Windows.Forms.CheckBox();
            this.chboxGenero3 = new System.Windows.Forms.CheckBox();
            this.chboxGenero4 = new System.Windows.Forms.CheckBox();
            this.chboxGenero5 = new System.Windows.Forms.CheckBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblTraerXgenero = new System.Windows.Forms.Label();
            this.gridPeliculas = new System.Windows.Forms.DataGridView();
            this.txtIdGenero = new System.Windows.Forms.TextBox();
            this.lbliDGenero = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBorrar = new System.Windows.Forms.Label();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.txtIdPelicula = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "P E L I C U L A S";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(166, 94);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(166, 163);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(200, 20);
            this.txtDuracion.TabIndex = 3;
            // 
            // txtIdioma
            // 
            this.txtIdioma.Location = new System.Drawing.Point(166, 209);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(200, 20);
            this.txtIdioma.TabIndex = 5;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(43, 94);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 6;
            this.labelNombre.Text = "Nombre";
            // 
            // labelFechaEstreno
            // 
            this.labelFechaEstreno.AutoSize = true;
            this.labelFechaEstreno.Location = new System.Drawing.Point(43, 133);
            this.labelFechaEstreno.Name = "labelFechaEstreno";
            this.labelFechaEstreno.Size = new System.Drawing.Size(76, 13);
            this.labelFechaEstreno.TabIndex = 7;
            this.labelFechaEstreno.Text = "Fecha Estreno";
            // 
            // lbelDM
            // 
            this.lbelDM.AutoSize = true;
            this.lbelDM.Location = new System.Drawing.Point(43, 170);
            this.lbelDM.Name = "lbelDM";
            this.lbelDM.Size = new System.Drawing.Size(105, 13);
            this.lbelDM.TabIndex = 8;
            this.lbelDM.Text = "Duracion en Minutos";
            // 
            // labelSinopsis
            // 
            this.labelSinopsis.AutoSize = true;
            this.labelSinopsis.Location = new System.Drawing.Point(43, 249);
            this.labelSinopsis.Name = "labelSinopsis";
            this.labelSinopsis.Size = new System.Drawing.Size(46, 13);
            this.labelSinopsis.TabIndex = 9;
            this.labelSinopsis.Text = "Sinopsis";
            // 
            // labelIdioma
            // 
            this.labelIdioma.AutoSize = true;
            this.labelIdioma.Location = new System.Drawing.Point(43, 212);
            this.labelIdioma.Name = "labelIdioma";
            this.labelIdioma.Size = new System.Drawing.Size(38, 13);
            this.labelIdioma.TabIndex = 10;
            this.labelIdioma.Text = "Idioma";
            // 
            // dateTimeEstreno
            // 
            this.dateTimeEstreno.Location = new System.Drawing.Point(166, 127);
            this.dateTimeEstreno.Name = "dateTimeEstreno";
            this.dateTimeEstreno.Size = new System.Drawing.Size(200, 20);
            this.dateTimeEstreno.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.Location = new System.Drawing.Point(166, 249);
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(200, 65);
            this.txtSinopsis.TabIndex = 13;
            this.txtSinopsis.Text = "";
            // 
            // chboxCalificacion1
            // 
            this.chboxCalificacion1.AutoSize = true;
            this.chboxCalificacion1.Location = new System.Drawing.Point(46, 380);
            this.chboxCalificacion1.Name = "chboxCalificacion1";
            this.chboxCalificacion1.Size = new System.Drawing.Size(47, 17);
            this.chboxCalificacion1.TabIndex = 14;
            this.chboxCalificacion1.Text = "ATP";
            this.chboxCalificacion1.UseVisualStyleBackColor = true;
            // 
            // chboxCalificacion2
            // 
            this.chboxCalificacion2.AutoSize = true;
            this.chboxCalificacion2.Location = new System.Drawing.Point(46, 416);
            this.chboxCalificacion2.Name = "chboxCalificacion2";
            this.chboxCalificacion2.Size = new System.Drawing.Size(33, 17);
            this.chboxCalificacion2.TabIndex = 15;
            this.chboxCalificacion2.Text = "B";
            this.chboxCalificacion2.UseVisualStyleBackColor = true;
            // 
            // chboxGenero1
            // 
            this.chboxGenero1.AutoSize = true;
            this.chboxGenero1.Location = new System.Drawing.Point(192, 380);
            this.chboxGenero1.Name = "chboxGenero1";
            this.chboxGenero1.Size = new System.Drawing.Size(59, 17);
            this.chboxGenero1.TabIndex = 16;
            this.chboxGenero1.Text = "Accion";
            this.chboxGenero1.UseVisualStyleBackColor = true;
            // 
            // chboxGenero2
            // 
            this.chboxGenero2.AutoSize = true;
            this.chboxGenero2.Location = new System.Drawing.Point(192, 416);
            this.chboxGenero2.Name = "chboxGenero2";
            this.chboxGenero2.Size = new System.Drawing.Size(69, 17);
            this.chboxGenero2.TabIndex = 17;
            this.chboxGenero2.Text = "Aventura";
            this.chboxGenero2.UseVisualStyleBackColor = true;
            // 
            // chboxGenero3
            // 
            this.chboxGenero3.AutoSize = true;
            this.chboxGenero3.Location = new System.Drawing.Point(192, 457);
            this.chboxGenero3.Name = "chboxGenero3";
            this.chboxGenero3.Size = new System.Drawing.Size(98, 17);
            this.chboxGenero3.TabIndex = 18;
            this.chboxGenero3.Text = "Ciencia Ficcion";
            this.chboxGenero3.UseVisualStyleBackColor = true;
            // 
            // chboxGenero4
            // 
            this.chboxGenero4.AutoSize = true;
            this.chboxGenero4.Location = new System.Drawing.Point(192, 491);
            this.chboxGenero4.Name = "chboxGenero4";
            this.chboxGenero4.Size = new System.Drawing.Size(67, 17);
            this.chboxGenero4.TabIndex = 19;
            this.chboxGenero4.Text = "Comedia";
            this.chboxGenero4.UseVisualStyleBackColor = true;
            // 
            // chboxGenero5
            // 
            this.chboxGenero5.AutoSize = true;
            this.chboxGenero5.Location = new System.Drawing.Point(192, 527);
            this.chboxGenero5.Name = "chboxGenero5";
            this.chboxGenero5.Size = new System.Drawing.Size(51, 17);
            this.chboxGenero5.TabIndex = 20;
            this.chboxGenero5.Text = "Otros";
            this.chboxGenero5.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnCargar.Location = new System.Drawing.Point(29, 574);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(337, 112);
            this.btnCargar.TabIndex = 21;
            this.btnCargar.Text = "C A R G A R";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Location = new System.Drawing.Point(41, 349);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(61, 13);
            this.lblCalificacion.TabIndex = 22;
            this.lblCalificacion.Text = "Calificacion";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(189, 349);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 23;
            this.lblGenero.Text = "Genero";
            // 
            // lblTraerXgenero
            // 
            this.lblTraerXgenero.AutoSize = true;
            this.lblTraerXgenero.Location = new System.Drawing.Point(425, 28);
            this.lblTraerXgenero.Name = "lblTraerXgenero";
            this.lblTraerXgenero.Size = new System.Drawing.Size(158, 13);
            this.lblTraerXgenero.TabIndex = 24;
            this.lblTraerXgenero.Text = "B U S C A R    X    G E N E R O";
            // 
            // gridPeliculas
            // 
            this.gridPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPeliculas.Location = new System.Drawing.Point(428, 127);
            this.gridPeliculas.Name = "gridPeliculas";
            this.gridPeliculas.Size = new System.Drawing.Size(734, 220);
            this.gridPeliculas.TabIndex = 25;
            // 
            // txtIdGenero
            // 
            this.txtIdGenero.Location = new System.Drawing.Point(526, 83);
            this.txtIdGenero.Name = "txtIdGenero";
            this.txtIdGenero.Size = new System.Drawing.Size(200, 20);
            this.txtIdGenero.TabIndex = 26;
            // 
            // lbliDGenero
            // 
            this.lbliDGenero.AutoSize = true;
            this.lbliDGenero.Location = new System.Drawing.Point(425, 86);
            this.lbliDGenero.Name = "lbliDGenero";
            this.lbliDGenero.Size = new System.Drawing.Size(54, 13);
            this.lbliDGenero.TabIndex = 27;
            this.lbliDGenero.Text = "Id Genero";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBuscar.Location = new System.Drawing.Point(795, 68);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(367, 49);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "B U S C A R";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBorrar
            // 
            this.lblBorrar.AutoSize = true;
            this.lblBorrar.Location = new System.Drawing.Point(425, 401);
            this.lblBorrar.Name = "lblBorrar";
            this.lblBorrar.Size = new System.Drawing.Size(124, 13);
            this.lblBorrar.TabIndex = 29;
            this.lblBorrar.Text = "E L I M I N A R    X    I D";
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Location = new System.Drawing.Point(425, 461);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(56, 13);
            this.lblEliminar.TabIndex = 30;
            this.lblEliminar.Text = "Id Pelicula";
            // 
            // txtIdPelicula
            // 
            this.txtIdPelicula.Location = new System.Drawing.Point(526, 454);
            this.txtIdPelicula.Name = "txtIdPelicula";
            this.txtIdPelicula.Size = new System.Drawing.Size(200, 20);
            this.txtIdPelicula.TabIndex = 31;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminar.Location = new System.Drawing.Point(782, 439);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(367, 49);
            this.btnEliminar.TabIndex = 32;
            this.btnEliminar.Text = "E L I M I N A R";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMostrarTodo.Location = new System.Drawing.Point(795, 13);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(367, 49);
            this.btnMostrarTodo.TabIndex = 33;
            this.btnMostrarTodo.Text = "M O S T R A R";
            this.btnMostrarTodo.UseVisualStyleBackColor = false;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1196, 722);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtIdPelicula);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.lblBorrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lbliDGenero);
            this.Controls.Add(this.txtIdGenero);
            this.Controls.Add(this.gridPeliculas);
            this.Controls.Add(this.lblTraerXgenero);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblCalificacion);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.chboxGenero5);
            this.Controls.Add(this.chboxGenero4);
            this.Controls.Add(this.chboxGenero3);
            this.Controls.Add(this.chboxGenero2);
            this.Controls.Add(this.chboxGenero1);
            this.Controls.Add(this.chboxCalificacion2);
            this.Controls.Add(this.chboxCalificacion1);
            this.Controls.Add(this.txtSinopsis);
            this.Controls.Add(this.dateTimeEstreno);
            this.Controls.Add(this.labelIdioma);
            this.Controls.Add(this.labelSinopsis);
            this.Controls.Add(this.lbelDM);
            this.Controls.Add(this.labelFechaEstreno);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.txtIdioma);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPelicula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelFechaEstreno;
        private System.Windows.Forms.Label lbelDM;
        private System.Windows.Forms.Label labelSinopsis;
        private System.Windows.Forms.Label labelIdioma;
        private System.Windows.Forms.DateTimePicker dateTimeEstreno;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox txtSinopsis;
        private System.Windows.Forms.CheckBox chboxCalificacion1;
        private System.Windows.Forms.CheckBox chboxCalificacion2;
        private System.Windows.Forms.CheckBox chboxGenero1;
        private System.Windows.Forms.CheckBox chboxGenero2;
        private System.Windows.Forms.CheckBox chboxGenero3;
        private System.Windows.Forms.CheckBox chboxGenero4;
        private System.Windows.Forms.CheckBox chboxGenero5;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblTraerXgenero;
        private System.Windows.Forms.DataGridView gridPeliculas;
        private System.Windows.Forms.TextBox txtIdGenero;
        private System.Windows.Forms.Label lbliDGenero;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBorrar;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.TextBox txtIdPelicula;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnMostrarTodo;
    }
}

