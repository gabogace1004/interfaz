
namespace interfaz
{
    partial class SistemaCHEYS
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.RelojTB = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mySqlDataAdapter1 = new MySqlConnector.MySqlDataAdapter();
            this.TablaAllRegitros = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.No_RelojTextBox = new System.Windows.Forms.TextBox();
            this.FechaTB = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TablaAllRegitros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(876, 455);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Entrada manual";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(876, 505);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "Solicitar salida";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(876, 571);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 43);
            this.button3.TabIndex = 8;
            this.button3.Text = "ayuda";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RelojTB
            // 
            this.RelojTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelojTB.Location = new System.Drawing.Point(20, 53);
            this.RelojTB.Margin = new System.Windows.Forms.Padding(4);
            this.RelojTB.Multiline = true;
            this.RelojTB.Name = "RelojTB";
            this.RelojTB.Size = new System.Drawing.Size(379, 64);
            this.RelojTB.TabIndex = 9;
            this.RelojTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RelojTB.TextChanged += new System.EventHandler(this.RelojTB_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateBatchSize = 0;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // TablaAllRegitros
            // 
            this.TablaAllRegitros.AllowUserToOrderColumns = true;
            this.TablaAllRegitros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaAllRegitros.Location = new System.Drawing.Point(40, 140);
            this.TablaAllRegitros.Margin = new System.Windows.Forms.Padding(4);
            this.TablaAllRegitros.Name = "TablaAllRegitros";
            this.TablaAllRegitros.RowHeadersWidth = 51;
            this.TablaAllRegitros.Size = new System.Drawing.Size(760, 597);
            this.TablaAllRegitros.TabIndex = 10;
            this.TablaAllRegitros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(934, 140);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 35);
            this.button4.TabIndex = 11;
            this.button4.Text = "Checar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // No_RelojTextBox
            // 
            this.No_RelojTextBox.Location = new System.Drawing.Point(846, 53);
            this.No_RelojTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.No_RelojTextBox.Multiline = true;
            this.No_RelojTextBox.Name = "No_RelojTextBox";
            this.No_RelojTextBox.Size = new System.Drawing.Size(279, 78);
            this.No_RelojTextBox.TabIndex = 12;
            this.No_RelojTextBox.TextChanged += new System.EventHandler(this.No_RelojTextBox_TextChanged);
            // 
            // FechaTB
            // 
            this.FechaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaTB.Location = new System.Drawing.Point(436, 53);
            this.FechaTB.Margin = new System.Windows.Forms.Padding(4);
            this.FechaTB.Multiline = true;
            this.FechaTB.Name = "FechaTB";
            this.FechaTB.Size = new System.Drawing.Size(379, 64);
            this.FechaTB.TabIndex = 13;
            this.FechaTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(876, 696);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(219, 57);
            this.button5.TabIndex = 14;
            this.button5.Text = "Registro empleados";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(876, 631);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(219, 59);
            this.button6.TabIndex = 15;
            this.button6.Text = "Registro de operaciones";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::interfaz.Properties.Resources.magiccover;
            this.pictureBox1.Location = new System.Drawing.Point(846, 183);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // SistemaCHEYS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1148, 774);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.FechaTB);
            this.Controls.Add(this.No_RelojTextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.TablaAllRegitros);
            this.Controls.Add(this.RelojTB);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SistemaCHEYS";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SistemaCHEYS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaAllRegitros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox RelojTB;
        private System.Windows.Forms.Timer timer1;
        private MySqlConnector.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.DataGridView TablaAllRegitros;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox No_RelojTextBox;
        private System.Windows.Forms.TextBox FechaTB;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

