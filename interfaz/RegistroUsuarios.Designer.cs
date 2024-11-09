namespace interfaz
{
    partial class RegistroUsuarios
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
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textA_paterno = new System.Windows.Forms.TextBox();
            this.labelA_paterno = new System.Windows.Forms.Label();
            this.labelA_materno = new System.Windows.Forms.Label();
            this.textA_materno = new System.Windows.Forms.TextBox();
            this.labelPuesto = new System.Windows.Forms.Label();
            this.textPuesto = new System.Windows.Forms.TextBox();
            this.TablaAllRegitros = new System.Windows.Forms.DataGridView();
            this.LabelEdad = new System.Windows.Forms.Label();
            this.textEdad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TablaAllRegitros)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.ForeColor = System.Drawing.Color.Black;
            this.buttonAceptar.Location = new System.Drawing.Point(232, 174);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(135, 34);
            this.buttonAceptar.TabIndex = 1;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.ForeColor = System.Drawing.Color.Black;
            this.buttonCancelar.Location = new System.Drawing.Point(421, 175);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(127, 32);
            this.buttonCancelar.TabIndex = 2;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(170, 38);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(148, 22);
            this.textNombre.TabIndex = 3;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(101, 41);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(56, 16);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // textA_paterno
            // 
            this.textA_paterno.Location = new System.Drawing.Point(532, 38);
            this.textA_paterno.Name = "textA_paterno";
            this.textA_paterno.Size = new System.Drawing.Size(148, 22);
            this.textA_paterno.TabIndex = 5;
            // 
            // labelA_paterno
            // 
            this.labelA_paterno.AutoSize = true;
            this.labelA_paterno.Location = new System.Drawing.Point(400, 41);
            this.labelA_paterno.Name = "labelA_paterno";
            this.labelA_paterno.Size = new System.Drawing.Size(107, 16);
            this.labelA_paterno.TabIndex = 6;
            this.labelA_paterno.Text = "Apellido Paterno";
            this.labelA_paterno.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelA_materno
            // 
            this.labelA_materno.AutoSize = true;
            this.labelA_materno.Location = new System.Drawing.Point(101, 75);
            this.labelA_materno.Name = "labelA_materno";
            this.labelA_materno.Size = new System.Drawing.Size(57, 32);
            this.labelA_materno.TabIndex = 7;
            this.labelA_materno.Text = "Apellido\r\nMaterno";
            // 
            // textA_materno
            // 
            this.textA_materno.Location = new System.Drawing.Point(170, 85);
            this.textA_materno.Name = "textA_materno";
            this.textA_materno.Size = new System.Drawing.Size(148, 22);
            this.textA_materno.TabIndex = 8;
            // 
            // labelPuesto
            // 
            this.labelPuesto.AutoSize = true;
            this.labelPuesto.Location = new System.Drawing.Point(449, 85);
            this.labelPuesto.Name = "labelPuesto";
            this.labelPuesto.Size = new System.Drawing.Size(49, 16);
            this.labelPuesto.TabIndex = 9;
            this.labelPuesto.Text = "Puesto";
            this.labelPuesto.Click += new System.EventHandler(this.label4_Click);
            // 
            // textPuesto
            // 
            this.textPuesto.Location = new System.Drawing.Point(532, 82);
            this.textPuesto.Name = "textPuesto";
            this.textPuesto.Size = new System.Drawing.Size(148, 22);
            this.textPuesto.TabIndex = 10;
            // 
            // TablaAllRegitros
            // 
            this.TablaAllRegitros.AllowUserToOrderColumns = true;
            this.TablaAllRegitros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaAllRegitros.Location = new System.Drawing.Point(104, 231);
            this.TablaAllRegitros.Margin = new System.Windows.Forms.Padding(4);
            this.TablaAllRegitros.Name = "TablaAllRegitros";
            this.TablaAllRegitros.RowHeadersWidth = 51;
            this.TablaAllRegitros.Size = new System.Drawing.Size(591, 206);
            this.TablaAllRegitros.TabIndex = 11;
            // 
            // LabelEdad
            // 
            this.LabelEdad.AutoSize = true;
            this.LabelEdad.Location = new System.Drawing.Point(108, 132);
            this.LabelEdad.Name = "LabelEdad";
            this.LabelEdad.Size = new System.Drawing.Size(40, 16);
            this.LabelEdad.TabIndex = 12;
            this.LabelEdad.Text = "Edad";
            // 
            // textEdad
            // 
            this.textEdad.Location = new System.Drawing.Point(170, 129);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(148, 22);
            this.textEdad.TabIndex = 13;
            this.textEdad.TextChanged += new System.EventHandler(this.textEdad_TextChanged);
            // 
            // RegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.LabelEdad);
            this.Controls.Add(this.TablaAllRegitros);
            this.Controls.Add(this.textPuesto);
            this.Controls.Add(this.labelPuesto);
            this.Controls.Add(this.textA_materno);
            this.Controls.Add(this.labelA_materno);
            this.Controls.Add(this.labelA_paterno);
            this.Controls.Add(this.textA_paterno);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "RegistroUsuarios";
            this.Text = "Registro Usuarios";
            this.Load += new System.EventHandler(this.RegistroUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaAllRegitros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textA_paterno;
        private System.Windows.Forms.Label labelA_paterno;
        private System.Windows.Forms.Label labelA_materno;
        private System.Windows.Forms.TextBox textA_materno;
        private System.Windows.Forms.Label labelPuesto;
        private System.Windows.Forms.TextBox textPuesto;
        private System.Windows.Forms.DataGridView TablaAllRegitros;
        private System.Windows.Forms.Label LabelEdad;
        private System.Windows.Forms.TextBox textEdad;
    }
}