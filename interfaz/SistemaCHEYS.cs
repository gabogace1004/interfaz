using System;
using MySqlConnector;
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


    public partial class SistemaCHEYS : Form
    {

        private Conexion mConexion = new Conexion();

        public SistemaCHEYS()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana

            MostrarAllRegistros();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f1 = new Manual();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f1 =new PermisoSalir();
            f1.Show();
        }

        private void HoraTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f1 = new Ayuda();
            f1.Show();
        }

        private void SistemaCHEYS_Load(object sender, EventArgs e)
        {
            timer1.Enabled= true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RelojTB.Text = DateTime.Now.ToShortTimeString();
            FechaTB.Text = DateTime.Now.ToShortDateString();

        }

        private void RelojTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void MostrarAllRegistros()
        {
            string inve = "SELECT * FROM `Registros`";

            if (mConexion.getConexion() != null)
            {
                MySqlCommand cmd = new MySqlCommand(inve);
                cmd.Connection = mConexion.getConexion();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                TablaAllRegitros.DataSource = dt;


            }
            else
            {
                MessageBox.Show("Problemas de conexion a la DB");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string NR = No_RelojTextBox.Text;
            MySqlDataReader dr;
            string queryCH = "INSERT INTO registros Values(null" + ", " + NR + ", '" + RelojTB.Text + "' , '" + FechaTB.Text + "')";
            MySqlCommand cmd = new MySqlCommand(queryCH);
            cmd.Connection = mConexion.getConexion();
            try
            {
                dr = cmd.ExecuteReader();
                dr.Close();
                No_RelojTextBox.Text = "";
                MostrarAllRegistros();
            }
            catch(Exception ex)
            {
                
            }
            
        }

        private void No_RelojTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f1 = new RegistroUsuarios();
            f1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
