namespace pryDiesenberg_Act.FlotaAutos
{
    partial class frmPrincipal
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVerAlquileresEnCurso = new System.Windows.Forms.Button();
            this.btnVerDatosChoferes = new System.Windows.Forms.Button();
            this.btnVerDatosVehiculos = new System.Windows.Forms.Button();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            this.btnAgregarChofer = new System.Windows.Forms.Button();
            this.btnAgregarAlquiler = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Lavender;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(399, 46);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(625, 33);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Bienvenido al Sistema de Alquiler de Vehículos";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(481, 108);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(463, 29);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Haga click en la acción que desea realizar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarAlquiler);
            this.groupBox1.Controls.Add(this.btnAgregarVehiculo);
            this.groupBox1.Controls.Add(this.btnAgregarChofer);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 435);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar nuevo elemento";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVerDatosChoferes);
            this.groupBox2.Controls.Add(this.btnVerAlquileresEnCurso);
            this.groupBox2.Controls.Add(this.btnVerDatosVehiculos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(786, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 435);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ver datos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnVerAlquileresEnCurso
            // 
            this.btnVerAlquileresEnCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerAlquileresEnCurso.Location = new System.Drawing.Point(21, 73);
            this.btnVerAlquileresEnCurso.Name = "btnVerAlquileresEnCurso";
            this.btnVerAlquileresEnCurso.Size = new System.Drawing.Size(587, 54);
            this.btnVerAlquileresEnCurso.TabIndex = 0;
            this.btnVerAlquileresEnCurso.Text = "Ver alquileres en curso";
            this.btnVerAlquileresEnCurso.UseVisualStyleBackColor = true;
            this.btnVerAlquileresEnCurso.Click += new System.EventHandler(this.btnVerAlquileresEnCurso_Click);
            // 
            // btnVerDatosChoferes
            // 
            this.btnVerDatosChoferes.Location = new System.Drawing.Point(21, 352);
            this.btnVerDatosChoferes.Name = "btnVerDatosChoferes";
            this.btnVerDatosChoferes.Size = new System.Drawing.Size(587, 54);
            this.btnVerDatosChoferes.TabIndex = 1;
            this.btnVerDatosChoferes.Text = "Ver datos de choferes";
            this.btnVerDatosChoferes.UseVisualStyleBackColor = true;
            this.btnVerDatosChoferes.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnVerDatosVehiculos
            // 
            this.btnVerDatosVehiculos.Location = new System.Drawing.Point(21, 208);
            this.btnVerDatosVehiculos.Name = "btnVerDatosVehiculos";
            this.btnVerDatosVehiculos.Size = new System.Drawing.Size(587, 54);
            this.btnVerDatosVehiculos.TabIndex = 2;
            this.btnVerDatosVehiculos.Text = "Ver datos de los vehículos";
            this.btnVerDatosVehiculos.UseVisualStyleBackColor = true;
            this.btnVerDatosVehiculos.Click += new System.EventHandler(this.btnVerDatosVehiculos_Click);
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(26, 208);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(587, 54);
            this.btnAgregarVehiculo.TabIndex = 4;
            this.btnAgregarVehiculo.Text = "Agregar vehículo";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = true;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click);
            // 
            // btnAgregarChofer
            // 
            this.btnAgregarChofer.Location = new System.Drawing.Point(26, 352);
            this.btnAgregarChofer.Name = "btnAgregarChofer";
            this.btnAgregarChofer.Size = new System.Drawing.Size(587, 54);
            this.btnAgregarChofer.TabIndex = 5;
            this.btnAgregarChofer.Text = "Agregar chofer";
            this.btnAgregarChofer.UseVisualStyleBackColor = true;
            this.btnAgregarChofer.Click += new System.EventHandler(this.btnAgregarChofer_Click);
            // 
            // btnAgregarAlquiler
            // 
            this.btnAgregarAlquiler.Location = new System.Drawing.Point(26, 73);
            this.btnAgregarAlquiler.Name = "btnAgregarAlquiler";
            this.btnAgregarAlquiler.Size = new System.Drawing.Size(587, 54);
            this.btnAgregarAlquiler.TabIndex = 3;
            this.btnAgregarAlquiler.Text = "Agregar nuevo alquiler";
            this.btnAgregarAlquiler.UseVisualStyleBackColor = true;
            this.btnAgregarAlquiler.Click += new System.EventHandler(this.btnAgregarAlquiler_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(1244, 736);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(182, 61);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 824);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alquiler de Vehículos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVerDatosChoferes;
        private System.Windows.Forms.Button btnVerDatosVehiculos;
        private System.Windows.Forms.Button btnAgregarVehiculo;
        private System.Windows.Forms.Button btnAgregarChofer;
        private System.Windows.Forms.Button btnVerAlquileresEnCurso;
        private System.Windows.Forms.Button btnAgregarAlquiler;
        private System.Windows.Forms.Button btnSalir;
    }
}

