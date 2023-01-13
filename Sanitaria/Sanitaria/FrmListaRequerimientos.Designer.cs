namespace CapaPresentacion
{
    partial class FrmListaRequerimientos
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
            this.lblTipoReque = new System.Windows.Forms.Label();
            this.lblPrioridadReque = new System.Windows.Forms.Label();
            this.cmbxTipoReque = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblprioridad = new System.Windows.Forms.Label();
            this.comboBoxPrioridad = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblEstado = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.btnvolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoReque
            // 
            this.lblTipoReque.AutoSize = true;
            this.lblTipoReque.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoReque.Location = new System.Drawing.Point(102, 61);
            this.lblTipoReque.Name = "lblTipoReque";
            this.lblTipoReque.Size = new System.Drawing.Size(185, 24);
            this.lblTipoReque.TabIndex = 0;
            this.lblTipoReque.Text = "Tipo Requerimiento:";
            // 
            // lblPrioridadReque
            // 
            this.lblPrioridadReque.AutoSize = true;
            this.lblPrioridadReque.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridadReque.Location = new System.Drawing.Point(102, 131);
            this.lblPrioridadReque.Name = "lblPrioridadReque";
            this.lblPrioridadReque.Size = new System.Drawing.Size(98, 24);
            this.lblPrioridadReque.TabIndex = 1;
            this.lblPrioridadReque.Text = "Prioridad: ";
            // 
            // cmbxTipoReque
            // 
            this.cmbxTipoReque.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxTipoReque.FormattingEnabled = true;
            this.cmbxTipoReque.Items.AddRange(new object[] {
            "Todos",
            "Base de Datos",
            "Sistema"});
            this.cmbxTipoReque.Location = new System.Drawing.Point(319, 60);
            this.cmbxTipoReque.Name = "cmbxTipoReque";
            this.cmbxTipoReque.Size = new System.Drawing.Size(408, 27);
            this.cmbxTipoReque.TabIndex = 2;
            this.cmbxTipoReque.Text = "Seleccionar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(606, 215);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 32);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(62, 586);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(289, 50);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cambiar Estado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(387, 586);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(257, 50);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblprioridad
            // 
            this.lblprioridad.AutoSize = true;
            this.lblprioridad.Location = new System.Drawing.Point(316, 165);
            this.lblprioridad.Name = "lblprioridad";
            this.lblprioridad.Size = new System.Drawing.Size(119, 16);
            this.lblprioridad.TabIndex = 12;
            this.lblprioridad.Text = "(Alta,  Media, Baja)";
            // 
            // comboBoxPrioridad
            // 
            this.comboBoxPrioridad.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPrioridad.FormattingEnabled = true;
            this.comboBoxPrioridad.Items.AddRange(new object[] {
            "Todos",
            "Alta",
            "Media",
            "Baja"});
            this.comboBoxPrioridad.Location = new System.Drawing.Point(319, 131);
            this.comboBoxPrioridad.Name = "comboBoxPrioridad";
            this.comboBoxPrioridad.Size = new System.Drawing.Size(408, 27);
            this.comboBoxPrioridad.TabIndex = 13;
            this.comboBoxPrioridad.Text = "Seleccionar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(25, 278);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(892, 279);
            this.dataGridView2.TabIndex = 14;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(102, 220);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(77, 24);
            this.lblEstado.TabIndex = 15;
            this.lblEstado.Text = "Estado: ";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Pendiente",
            "Resuelto"});
            this.comboBoxEstado.Location = new System.Drawing.Point(319, 220);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(125, 27);
            this.comboBoxEstado.TabIndex = 16;
            this.comboBoxEstado.Text = "Seleccionar";
            // 
            // btnvolver
            // 
            this.btnvolver.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.Location = new System.Drawing.Point(695, 586);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(162, 50);
            this.btnvolver.TabIndex = 17;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmListaRequerimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 648);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.comboBoxPrioridad);
            this.Controls.Add(this.lblprioridad);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbxTipoReque);
            this.Controls.Add(this.lblPrioridadReque);
            this.Controls.Add(this.lblTipoReque);
            this.Name = "FrmListaRequerimientos";
            this.Text = ".:. LISTA DE REQUERIMIENTOS .:.";
            this.Load += new System.EventHandler(this.FrmListaRequerimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoReque;
        private System.Windows.Forms.Label lblPrioridadReque;
        private System.Windows.Forms.ComboBox cmbxTipoReque;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblprioridad;
        private System.Windows.Forms.ComboBox comboBoxPrioridad;


        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Button btnvolver;
    }
}