﻿namespace PrimerParcialAplicada.UI.Registros
{
    partial class rRegistro
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuargar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.VendedorIdnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.NombrestextBox1 = new System.Windows.Forms.TextBox();
            this.RetenciontextBox = new System.Windows.Forms.TextBox();
            this.NombreserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SueldoerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PorcientoerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SueldotextBox = new System.Windows.Forms.NumericUpDown();
            this.PorcientotextBox = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VendedorIdnumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreserrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SueldoerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PorcientoerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SueldotextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PorcientotextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::PrimerParcialAplicada.Properties.Resources.find;
            this.btnBuscar.Location = new System.Drawing.Point(283, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(72, 52);
            this.btnBuscar.TabIndex = 40;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnGuargar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 66);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::PrimerParcialAplicada.Properties.Resources.delete;
            this.btnEliminar.Location = new System.Drawing.Point(277, 6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 60);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Vendedor ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Sueldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 53;
            this.label4.Text = "Retencion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 54;
            this.label5.Text = "%Retencion";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // VendedorIdnumericUpDown1
            // 
            this.VendedorIdnumericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendedorIdnumericUpDown1.Location = new System.Drawing.Point(130, 28);
            this.VendedorIdnumericUpDown1.Name = "VendedorIdnumericUpDown1";
            this.VendedorIdnumericUpDown1.Size = new System.Drawing.Size(147, 22);
            this.VendedorIdnumericUpDown1.TabIndex = 55;
            // 
            // NombrestextBox1
            // 
            this.NombrestextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombrestextBox1.Location = new System.Drawing.Point(130, 63);
            this.NombrestextBox1.Name = "NombrestextBox1";
            this.NombrestextBox1.Size = new System.Drawing.Size(147, 22);
            this.NombrestextBox1.TabIndex = 56;
            // 
            // RetenciontextBox
            // 
            this.RetenciontextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetenciontextBox.Location = new System.Drawing.Point(87, 215);
            this.RetenciontextBox.Name = "RetenciontextBox";
            this.RetenciontextBox.ReadOnly = true;
            this.RetenciontextBox.Size = new System.Drawing.Size(190, 22);
            this.RetenciontextBox.TabIndex = 58;
            // 
            // NombreserrorProvider
            // 
            this.NombreserrorProvider.ContainerControl = this;
            // 
            // SueldoerrorProvider
            // 
            this.SueldoerrorProvider.ContainerControl = this;
            // 
            // PorcientoerrorProvider
            // 
            this.PorcientoerrorProvider.ContainerControl = this;
            // 
            // SueldotextBox
            // 
            this.SueldotextBox.DecimalPlaces = 2;
            this.SueldotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SueldotextBox.Location = new System.Drawing.Point(130, 103);
            this.SueldotextBox.Maximum = new decimal(new int[] {
            90000000,
            0,
            0,
            0});
            this.SueldotextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SueldotextBox.Name = "SueldotextBox";
            this.SueldotextBox.Size = new System.Drawing.Size(147, 22);
            this.SueldotextBox.TabIndex = 60;
            this.SueldotextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SueldotextBox.ValueChanged += new System.EventHandler(this.SueldotextBox_ValueChanged);
            // 
            // PorcientotextBox
            // 
            this.PorcientotextBox.DecimalPlaces = 2;
            this.PorcientotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PorcientotextBox.Location = new System.Drawing.Point(214, 142);
            this.PorcientotextBox.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.PorcientotextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PorcientotextBox.Name = "PorcientotextBox";
            this.PorcientotextBox.Size = new System.Drawing.Size(63, 22);
            this.PorcientotextBox.TabIndex = 61;
            this.PorcientotextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PorcientotextBox.ValueChanged += new System.EventHandler(this.PorcientotextBox_ValueChanged);
            // 
            // rRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 336);
            this.Controls.Add(this.PorcientotextBox);
            this.Controls.Add(this.SueldotextBox);
            this.Controls.Add(this.RetenciontextBox);
            this.Controls.Add(this.NombrestextBox1);
            this.Controls.Add(this.VendedorIdnumericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Name = "rRegistro";
            this.Text = "rRegistro";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VendedorIdnumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreserrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SueldoerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PorcientoerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SueldotextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PorcientotextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuargar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown VendedorIdnumericUpDown1;
        private System.Windows.Forms.TextBox NombrestextBox1;
        private System.Windows.Forms.TextBox RetenciontextBox;
        private System.Windows.Forms.ErrorProvider NombreserrorProvider;
        private System.Windows.Forms.ErrorProvider SueldoerrorProvider;
        private System.Windows.Forms.ErrorProvider PorcientoerrorProvider;
        private System.Windows.Forms.NumericUpDown PorcientotextBox;
        private System.Windows.Forms.NumericUpDown SueldotextBox;
    }
}