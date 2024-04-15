namespace Clase_1_Lista
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lbRegistro1 = new System.Windows.Forms.Label();
            this.lbTitulo2 = new System.Windows.Forms.Label();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.btFin = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(47, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(42, 39);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(177, 25);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "Lista de Alumnos";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(47, 149);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(44, 76);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 3;
            this.lbNombre.Text = "Nombre";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(44, 133);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(44, 13);
            this.lbApellido.TabIndex = 4;
            this.lbApellido.Text = "Apellido";
            // 
            // lbDNI
            // 
            this.lbDNI.AutoSize = true;
            this.lbDNI.Location = new System.Drawing.Point(44, 194);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(26, 13);
            this.lbDNI.TabIndex = 6;
            this.lbDNI.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(47, 210);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 5;
            // 
            // lbRegistro1
            // 
            this.lbRegistro1.AutoSize = true;
            this.lbRegistro1.BackColor = System.Drawing.SystemColors.Control;
            this.lbRegistro1.Location = new System.Drawing.Point(441, 76);
            this.lbRegistro1.Name = "lbRegistro1";
            this.lbRegistro1.Size = new System.Drawing.Size(0, 13);
            this.lbRegistro1.TabIndex = 7;
            // 
            // lbTitulo2
            // 
            this.lbTitulo2.AutoSize = true;
            this.lbTitulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo2.Location = new System.Drawing.Point(439, 39);
            this.lbTitulo2.Name = "lbTitulo2";
            this.lbTitulo2.Size = new System.Drawing.Size(216, 25);
            this.lbTitulo2.TabIndex = 8;
            this.lbTitulo2.Text = "Alumnos Registrados";
            // 
            // btRegistrar
            // 
            this.btRegistrar.Location = new System.Drawing.Point(47, 264);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btRegistrar.TabIndex = 11;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // btFin
            // 
            this.btFin.Location = new System.Drawing.Point(47, 306);
            this.btFin.Name = "btFin";
            this.btFin.Size = new System.Drawing.Size(118, 23);
            this.btFin.TabIndex = 12;
            this.btFin.Text = "Finalizar Registro";
            this.btFin.UseVisualStyleBackColor = true;
            this.btFin.Click += new System.EventHandler(this.btFin_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbError.Location = new System.Drawing.Point(47, 245);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 15);
            this.lbError.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btFin);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.lbTitulo2);
            this.Controls.Add(this.lbRegistro1);
            this.Controls.Add(this.lbDNI);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lbRegistro1;
        private System.Windows.Forms.Label lbTitulo2;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.Button btFin;
        private System.Windows.Forms.Label lbError;
    }
}

