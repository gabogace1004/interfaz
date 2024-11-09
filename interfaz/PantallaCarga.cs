using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaz
{
    public partial class PantallaCarga : Form
    {
        public PantallaCarga()
        {
            InitializeComponent();
        }

        private void PantallaCarga_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // Establece el intervalo en milisegundos (por ejemplo, 1000 ms = 1 segundo)
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 10;
                label1.Text = "Cargando el sistema al " + progressBar1.Value + " %";
            }
            else
            {
                timer1.Stop();
                this.Hide();
                SistemaCHEYS form2 = new SistemaCHEYS();
                form2.Show();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
