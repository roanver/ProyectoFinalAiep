namespace CapaPresentacion
{
    partial class FrmRequerimiento
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
            this.lblTipoRequerimiento = new System.Windows.Forms.Label();
            this.lblDescripcionTipoRequerimiento = new System.Windows.Forms.Label();
            this.cmbxTipoRequeri = new System.Windows.Forms.ComboBox();
            this.lblAsignado = new System.Windows.Forms.Label();
            this.lblDescripcionReque = new System.Windows.Forms.Label();
            this.txtbxDescripcion = new System.Windows.Forms.TextBox();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.lblDescPrioridad = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnListaRequerimientos = new System.Windows.Forms.Button();
            this.comboBoxasignadoa = new System.Windows.Forms.ComboBox();
            this.comboBoxprioridad = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTipoRequerimiento
            // 
            this.lblTipoRequerimiento.AutoSize = true;
            this.lblTipoRequerimiento.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoRequerimiento.Location = new System.Drawing.Point(33, 56);
            this.lblTipoRequerimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoRequerimiento.Name = "lblTipoRequerimiento";
            this.lblTipoRequerimiento.Size = new System.Drawing.Size(190, 24);
            this.lblTipoRequerimiento.TabIndex = 0;
            this.lblTipoRequerimiento.Text = "Tipo Requerimiento: ";
            this.lblTipoRequerimiento.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDescripcionTipoRequerimiento
            // 
            this.lblDescripcionTipoRequerimiento.AutoSize = true;
            this.lblDescripcionTipoRequerimiento.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionTipoRequerimiento.Location = new System.Drawing.Point(233, 91);
            this.lblDescripcionTipoRequerimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionTipoRequerimiento.Name = "lblDescripcionTipoRequerimiento";
            this.lblDescripcionTipoRequerimiento.Size = new System.Drawing.Size(173, 17);
            this.lblDescripcionTipoRequerimiento.TabIndex = 1;
            this.lblDescripcionTipoRequerimiento.Text = "(Base de Datos, Sistema)";
            // 
            // cmbxTipoRequeri
            // 
            this.cmbxTipoRequeri.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxTipoRequeri.FormattingEnabled = true;
            this.cmbxTipoRequeri.Items.AddRange(new object[] {
            "Base de Datos",
            "Sistema"});
            this.cmbxTipoRequeri.Location = new System.Drawing.Point(236, 56);
            this.cmbxTipoRequeri.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxTipoRequeri.Name = "cmbxTipoRequeri";
            this.cmbxTipoRequeri.Size = new System.Drawing.Size(397, 27);
            this.cmbxTipoRequeri.TabIndex = 3;
            this.cmbxTipoRequeri.Text = "Seleccionar";
            this.cmbxTipoRequeri.SelectedIndexChanged += new System.EventHandler(this.cmbxTipoRequeri_SelectedIndexChanged);
            // 
            // lblAsignado
            // 
            this.lblAsignado.AutoSize = true;
            this.lblAsignado.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignado.Location = new System.Drawing.Point(33, 147);
            this.lblAsignado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsignado.Name = "lblAsignado";
            this.lblAsignado.Size = new System.Drawing.Size(110, 24);
            this.lblAsignado.TabIndex = 4;
            this.lblAsignado.Text = "Asignado a:";
            // 
            // lblDescripcionReque
            // 
            this.lblDescripcionReque.AutoSize = true;
            this.lblDescripcionReque.Location = new System.Drawing.Point(33, 217);
            this.lblDescripcionReque.Name = "lblDescripcionReque";
            this.lblDescripcionReque.Size = new System.Drawing.Size(277, 24);
            this.lblDescripcionReque.TabIndex = 6;
            this.lblDescripcionReque.Text = "Descripción del Requerimiento:";
            // 
            // txtbxDescripcion
            // 
            this.txtbxDescripcion.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtbxDescripcion.Location = new System.Drawing.Point(37, 244);
            this.txtbxDescripcion.Multiline = true;
            this.txtbxDescripcion.Name = "txtbxDescripcion";
            this.txtbxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxDescripcion.Size = new System.Drawing.Size(531, 114);
            this.txtbxDescripcion.TabIndex = 7;
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Location = new System.Drawing.Point(33, 403);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(98, 24);
            this.lblPrioridad.TabIndex = 8;
            this.lblPrioridad.Text = "Prioridad: ";
            // 
            // lblDescPrioridad
            // 
            this.lblDescPrioridad.AutoSize = true;
            this.lblDescPrioridad.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescPrioridad.Location = new System.Drawing.Point(138, 433);
            this.lblDescPrioridad.Name = "lblDescPrioridad";
            this.lblDescPrioridad.Size = new System.Drawing.Size(118, 19);
            this.lblDescPrioridad.TabIndex = 10;
            this.lblDescPrioridad.Text = "(Alta, Media, Baja)";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(37, 505);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(160, 40);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(233, 505);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(160, 40);
            this.btnLimpiarCampos.TabIndex = 12;
            this.btnLimpiarCampos.Text = "&Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnListaRequerimientos
            // 
            this.btnListaRequerimientos.Location = new System.Drawing.Point(421, 505);
            this.btnListaRequerimientos.Name = "btnListaRequerimientos";
            this.btnListaRequerimientos.Size = new System.Drawing.Size(192, 40);
            this.btnListaRequerimientos.TabIndex = 13;
            this.btnListaRequerimientos.Text = "&Ver Requerimientos";
            this.btnListaRequerimientos.UseVisualStyleBackColor = true;
            this.btnListaRequerimientos.Click += new System.EventHandler(this.btnListaRequerimientos_Click);
            // 
            // comboBoxasignadoa
            // 
            this.comboBoxasignadoa.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxasignadoa.FormattingEnabled = true;
            this.comboBoxasignadoa.Items.AddRange(new object[] {
            "Maria Del Pilar",
            "Frydda Perez\t",
            "Juana de Arco",
            "Cleopatra Muñoz"});
            this.comboBoxasignadoa.Location = new System.Drawing.Point(236, 146);
            this.comboBoxasignadoa.Name = "comboBoxasignadoa";
            this.comboBoxasignadoa.Size = new System.Drawing.Size(397, 27);
            this.comboBoxasignadoa.TabIndex = 15;
            this.comboBoxasignadoa.Text = "Seleccionar";
            // 
            // comboBoxprioridad
            // 
            this.comboBoxprioridad.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxprioridad.FormattingEnabled = true;
            this.comboBoxprioridad.Items.AddRange(new object[] {
            "Alta",
            "Media",
            "Baja"});
            this.comboBoxprioridad.Location = new System.Drawing.Point(142, 395);
            this.comboBoxprioridad.Name = "comboBoxprioridad";
            this.comboBoxprioridad.Size = new System.Drawing.Size(155, 27);
            this.comboBoxprioridad.TabIndex = 16;
            this.comboBoxprioridad.Text = "Seleccionar";
            // 
            // FrmRequerimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 564);
            this.Controls.Add(this.comboBoxprioridad);
            this.Controls.Add(this.comboBoxasignadoa);
            this.Controls.Add(this.btnListaRequerimientos);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblDescPrioridad);
            this.Controls.Add(this.lblPrioridad);
            this.Controls.Add(this.txtbxDescripcion);
            this.Controls.Add(this.lblDescripcionReque);
            this.Controls.Add(this.lblAsignado);
            this.Controls.Add(this.cmbxTipoRequeri);
            this.Controls.Add(this.lblDescripcionTipoRequerimiento);
            this.Controls.Add(this.lblTipoRequerimiento);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRequerimiento";
            this.Text = "..:..Registro Requerimiento..:..";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoRequerimiento;
        private System.Windows.Forms.Label lblDescripcionTipoRequerimiento;
        private System.Windows.Forms.ComboBox cmbxTipoRequeri;
        private System.Windows.Forms.Label lblAsignado;
        private System.Windows.Forms.Label lblDescripcionReque;
        private System.Windows.Forms.TextBox txtbxDescripcion;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.Label lblDescPrioridad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnListaRequerimientos;
        private System.Windows.Forms.ComboBox comboBoxasignadoa;
        private System.Windows.Forms.ComboBox comboBoxprioridad;
    }
}