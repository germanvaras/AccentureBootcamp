
namespace WindowsAppPubs
{
    partial class FormStore
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
            this.StoresGrid = new System.Windows.Forms.DataGridView();
            this.lblStores = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnViewOne = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnElminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StoresGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StoresGrid
            // 
            this.StoresGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StoresGrid.Location = new System.Drawing.Point(30, 119);
            this.StoresGrid.Name = "StoresGrid";
            this.StoresGrid.Size = new System.Drawing.Size(240, 150);
            this.StoresGrid.TabIndex = 0;
            // 
            // lblStores
            // 
            this.lblStores.AutoSize = true;
            this.lblStores.Location = new System.Drawing.Point(27, 97);
            this.lblStores.Name = "lblStores";
            this.lblStores.Size = new System.Drawing.Size(37, 13);
            this.lblStores.TabIndex = 1;
            this.lblStores.Text = "Stores";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(94, 87);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Ver Todas";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnViewOne
            // 
            this.btnViewOne.Location = new System.Drawing.Point(195, 87);
            this.btnViewOne.Name = "btnViewOne";
            this.btnViewOne.Size = new System.Drawing.Size(75, 23);
            this.btnViewOne.TabIndex = 2;
            this.btnViewOne.Text = "Ver Una";
            this.btnViewOne.UseVisualStyleBackColor = true;
            this.btnViewOne.Click += new System.EventHandler(this.btnViewOne_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(84, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 3;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(27, 33);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "ID";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(549, 87);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(151, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar Store";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnElminar
            // 
            this.btnElminar.Location = new System.Drawing.Point(549, 146);
            this.btnElminar.Name = "btnElminar";
            this.btnElminar.Size = new System.Drawing.Size(151, 23);
            this.btnElminar.TabIndex = 5;
            this.btnElminar.Text = "Eliminar Store";
            this.btnElminar.UseVisualStyleBackColor = true;
            this.btnElminar.Click += new System.EventHandler(this.btnElminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(549, 225);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(151, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar Store";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // FormStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnElminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnViewOne);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblStores);
            this.Controls.Add(this.StoresGrid);
            this.Name = "FormStore";
            this.Text = "FormStore";
            ((System.ComponentModel.ISupportInitialize)(this.StoresGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StoresGrid;
        private System.Windows.Forms.Label lblStores;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnViewOne;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnElminar;
        private System.Windows.Forms.Button btnModificar;
    }
}