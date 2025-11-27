namespace TP3_Entity
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgv;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            lblNombre = new System.Windows.Forms.Label();
            lblPrecio = new System.Windows.Forms.Label();
            lblStock = new System.Windows.Forms.Label();

            txtNombre = new System.Windows.Forms.TextBox();
            txtPrecio = new System.Windows.Forms.TextBox();
            txtStock = new System.Windows.Forms.TextBox();

            btnAgregar = new System.Windows.Forms.Button();
            btnListar = new System.Windows.Forms.Button();
            btnActualizar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();

            dgv = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(dgv)).BeginInit();
            SuspendLayout();

            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 520);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmPrincipal";
            this.Text = "TP3_Entity - CRUD EF Core";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);

            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(15, 18);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";

            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new System.Drawing.Point(15, 58);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new System.Drawing.Size(41, 15);
            lblPrecio.TabIndex = 1;
            lblPrecio.Text = "Precio";

            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new System.Drawing.Point(15, 98);
            lblStock.Name = "lblStock";
            lblStock.Size = new System.Drawing.Size(36, 15);
            lblStock.TabIndex = 2;
            lblStock.Text = "Stock";

            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(90, 15);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(260, 23);
            txtNombre.TabIndex = 3;

            // 
            // txtPrecio
            // 
            txtPrecio.Location = new System.Drawing.Point(90, 55);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new System.Drawing.Size(100, 23);
            txtPrecio.TabIndex = 4;

            // 
            // txtStock
            // 
            txtStock.Location = new System.Drawing.Point(90, 95);
            txtStock.Name = "txtStock";
            txtStock.Size = new System.Drawing.Size(100, 23);
            txtStock.TabIndex = 5;

            // 
            // btnAgregar
            // 
            btnAgregar.Location = new System.Drawing.Point(380, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(100, 30);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            // 
            // btnListar
            // 
            btnListar.Location = new System.Drawing.Point(490, 12);
            btnListar.Name = "btnListar";
            btnListar.Size = new System.Drawing.Size(100, 30);
            btnListar.TabIndex = 7;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += new System.EventHandler(this.btnListar_Click);

            // 
            // btnActualizar
            // 
            btnActualizar.Location = new System.Drawing.Point(600, 12);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(100, 30);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(600, 52);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(100, 30);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            // 
            // dgv
            // 
            dgv.Location = new System.Drawing.Point(15, 140);
            dgv.Name = "dgv";
            dgv.Size = new System.Drawing.Size(745, 360);
            dgv.TabIndex = 10;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.MultiSelect = false;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);

            // 
            // Controls Add
            // 
            this.Controls.Add(lblNombre);
            this.Controls.Add(lblPrecio);
            this.Controls.Add(lblStock);
            this.Controls.Add(txtNombre);
            this.Controls.Add(txtPrecio);
            this.Controls.Add(txtStock);
            this.Controls.Add(btnAgregar);
            this.Controls.Add(btnListar);
            this.Controls.Add(btnActualizar);
            this.Controls.Add(btnEliminar);
            this.Controls.Add(dgv);

            ((System.ComponentModel.ISupportInitialize)(dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

