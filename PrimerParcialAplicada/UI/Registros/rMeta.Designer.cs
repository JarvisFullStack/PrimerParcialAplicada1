namespace PrimerParcialAplicada.UI.Registros
{
    partial class rMeta
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
            this.CuotaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripciontextBox1 = new System.Windows.Forms.TextBox();
            this.MetaIdnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuargar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CuotaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MetaIdnumericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CuotaNumericUpDown
            // 
            this.CuotaNumericUpDown.DecimalPlaces = 2;
            this.CuotaNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CuotaNumericUpDown.Location = new System.Drawing.Point(106, 130);
            this.CuotaNumericUpDown.Maximum = new decimal(new int[] {
            90000000,
            0,
            0,
            0});
            this.CuotaNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CuotaNumericUpDown.Name = "CuotaNumericUpDown";
            this.CuotaNumericUpDown.Size = new System.Drawing.Size(147, 22);
            this.CuotaNumericUpDown.TabIndex = 67;
            this.CuotaNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DescripciontextBox1
            // 
            this.DescripciontextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripciontextBox1.Location = new System.Drawing.Point(106, 90);
            this.DescripciontextBox1.Name = "DescripciontextBox1";
            this.DescripciontextBox1.Size = new System.Drawing.Size(147, 22);
            this.DescripciontextBox1.TabIndex = 66;
            // 
            // MetaIdnumericUpDown1
            // 
            this.MetaIdnumericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetaIdnumericUpDown1.Location = new System.Drawing.Point(106, 55);
            this.MetaIdnumericUpDown1.Name = "MetaIdnumericUpDown1";
            this.MetaIdnumericUpDown1.Size = new System.Drawing.Size(147, 22);
            this.MetaIdnumericUpDown1.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 64;
            this.label3.Text = "Cuota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "Vendedor ID";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::PrimerParcialAplicada.Properties.Resources.find;
            this.btnBuscar.Location = new System.Drawing.Point(259, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(72, 52);
            this.btnBuscar.TabIndex = 61;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnGuargar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(3, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 66);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::PrimerParcialAplicada.Properties.Resources.delete;
            this.btnEliminar.Location = new System.Drawing.Point(280, 6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 60);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnGuargar
            // 
            this.btnGuargar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuargar.FlatAppearance.BorderSize = 0;
            this.btnGuargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuargar.Image = global::PrimerParcialAplicada.Properties.Resources.save;
            this.btnGuargar.Location = new System.Drawing.Point(148, 6);
            this.btnGuargar.Name = "btnGuargar";
            this.btnGuargar.Size = new System.Drawing.Size(75, 60);
            this.btnGuargar.TabIndex = 1;
            this.btnGuargar.UseVisualStyleBackColor = false;
            this.btnGuargar.Click += new System.EventHandler(this.btnGuargar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Image = global::PrimerParcialAplicada.Properties.Resources._new;
            this.btnNuevo.Location = new System.Drawing.Point(12, 6);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 60);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // rMeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 255);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CuotaNumericUpDown);
            this.Controls.Add(this.DescripciontextBox1);
            this.Controls.Add(this.MetaIdnumericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Name = "rMeta";
            this.Text = "rMeta";
            ((System.ComponentModel.ISupportInitialize)(this.CuotaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MetaIdnumericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown CuotaNumericUpDown;
        private System.Windows.Forms.TextBox DescripciontextBox1;
        private System.Windows.Forms.NumericUpDown MetaIdnumericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuargar;
        private System.Windows.Forms.Button btnNuevo;
    }
}