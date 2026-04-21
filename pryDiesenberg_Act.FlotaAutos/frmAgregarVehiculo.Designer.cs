namespace pryDiesenberg_Act.FlotaAutos
{
    partial class frmAgregarVehiculo
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.mskPatente = new System.Windows.Forms.MaskedTextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.numAño = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAño)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(33, 12);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(184, 16);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Ingrese la Marca del Vehículo";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(33, 45);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(192, 16);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Ingrese el Modelo del Vehículo";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(33, 75);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(286, 16);
            this.lblAño.TabIndex = 2;
            this.lblAño.Text = "Seleccione el Año de Fabricación del Vehículo";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.Location = new System.Drawing.Point(33, 108);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(192, 16);
            this.lblPatente.TabIndex = 3;
            this.lblPatente.Text = "Ingrese la Patente del Vehículo";
            // 
            // mskPatente
            // 
            this.mskPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPatente.Location = new System.Drawing.Point(337, 102);
            this.mskPatente.Name = "mskPatente";
            this.mskPatente.Size = new System.Drawing.Size(113, 22);
            this.mskPatente.TabIndex = 4;
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(337, 6);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(113, 22);
            this.txtMarca.TabIndex = 5;
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(337, 39);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(113, 22);
            this.txtModelo.TabIndex = 6;
            // 
            // numAño
            // 
            this.numAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAño.Location = new System.Drawing.Point(382, 69);
            this.numAño.Maximum = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.numAño.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.numAño.Name = "numAño";
            this.numAño.ReadOnly = true;
            this.numAño.Size = new System.Drawing.Size(68, 22);
            this.numAño.TabIndex = 7;
            this.numAño.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(337, 157);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(101, 42);
            this.btnAgregarVehiculo.TabIndex = 8;
            this.btnAgregarVehiculo.Text = "Agregar Nuevo Vehículo";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = true;
            // 
            // frmAgregarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 216);
            this.Controls.Add(this.btnAgregarVehiculo);
            this.Controls.Add(this.numAño);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.mskPatente);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Name = "frmAgregarVehiculo";
            this.Text = "frmAgregarVehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.numAño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.MaskedTextBox mskPatente;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.NumericUpDown numAño;
        private System.Windows.Forms.Button btnAgregarVehiculo;
    }
}