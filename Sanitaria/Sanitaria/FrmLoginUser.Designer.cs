namespace CapaPresentacion
{
    partial class FrmLoginUser
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
            this.lblTitutlo = new System.Windows.Forms.Label();
            this.lblLogNombre = new System.Windows.Forms.Label();
            this.lblLogContraseña = new System.Windows.Forms.Label();
            this.txtbxNombre = new System.Windows.Forms.TextBox();
            this.txtbxContrtaseña = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitutlo
            // 
            this.lblTitutlo.AutoSize = true;
            this.lblTitutlo.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitutlo.Location = new System.Drawing.Point(137, 24);
            this.lblTitutlo.Name = "lblTitutlo";
            this.lblTitutlo.Size = new System.Drawing.Size(197, 35);
            this.lblTitutlo.TabIndex = 0;
            this.lblTitutlo.Text = "Autenticación";
            // 
            // lblLogNombre
            // 
            this.lblLogNombre.AutoSize = true;
            this.lblLogNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogNombre.Location = new System.Drawing.Point(27, 102);
            this.lblLogNombre.Name = "lblLogNombre";
            this.lblLogNombre.Size = new System.Drawing.Size(80, 20);
            this.lblLogNombre.TabIndex = 1;
            this.lblLogNombre.Text = "Nombre:";
            // 
            // lblLogContraseña
            // 
            this.lblLogContraseña.AutoSize = true;
            this.lblLogContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogContraseña.Location = new System.Drawing.Point(27, 155);
            this.lblLogContraseña.Name = "lblLogContraseña";
            this.lblLogContraseña.Size = new System.Drawing.Size(111, 20);
            this.lblLogContraseña.TabIndex = 2;
            this.lblLogContraseña.Text = "Contraseña:";
            // 
            // txtbxNombre
            // 
            this.txtbxNombre.Location = new System.Drawing.Point(152, 102);
            this.txtbxNombre.Name = "txtbxNombre";
            this.txtbxNombre.Size = new System.Drawing.Size(210, 22);
            this.txtbxNombre.TabIndex = 3;
            this.txtbxNombre.TextChanged += new System.EventHandler(this.txtbxNombre_TextChanged);
            // 
            // txtbxContrtaseña
            // 
            this.txtbxContrtaseña.Location = new System.Drawing.Point(152, 153);
            this.txtbxContrtaseña.Name = "txtbxContrtaseña";
            this.txtbxContrtaseña.PasswordChar = '*';
            this.txtbxContrtaseña.Size = new System.Drawing.Size(210, 22);
            this.txtbxContrtaseña.TabIndex = 4;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(96, 221);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(105, 38);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(250, 221);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 38);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmLoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 296);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtbxContrtaseña);
            this.Controls.Add(this.txtbxNombre);
            this.Controls.Add(this.lblLogContraseña);
            this.Controls.Add(this.lblLogNombre);
            this.Controls.Add(this.lblTitutlo);
            this.Name = "FrmLoginUser";
            this.Text = ".:. Iniciar Sesión .:.";
            this.Load += new System.EventHandler(this.FrmLoginUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitutlo;
        private System.Windows.Forms.Label lblLogNombre;
        private System.Windows.Forms.Label lblLogContraseña;
        private System.Windows.Forms.TextBox txtbxNombre;
        private System.Windows.Forms.TextBox txtbxContrtaseña;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnSalir;
    }
}