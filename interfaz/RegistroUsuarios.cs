using MySqlConnector;
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
    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana
        }
        private Conexion mConexion = new Conexion();
        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {
            MostrarAllRegistros();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNombre.Text) ||
        string.IsNullOrWhiteSpace(textA_paterno.Text) ||
        string.IsNullOrWhiteSpace(textA_materno.Text) ||
        string.IsNullOrWhiteSpace(textPuesto.Text) ||
        string.IsNullOrWhiteSpace(textEdad.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de registrar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene la ejecución si hay algún campo vacío
            }
            string Nombre = textNombre.Text;
            string A_Paterno = textA_paterno.Text;
            string A_Materno = textA_materno.Text;
            string Puesto = textPuesto.Text;
            int edad = int.Parse(textEdad.Text);
      

            string queryInsert = "INSERT INTO empleados VALUES (null,'" + Nombre + "', '" + A_Paterno + "', '" + A_Materno + "', '" + Puesto + "', " + edad + ")";

            // Crear y configurar el comando
         
            MySqlCommand cmd = new MySqlCommand(queryInsert);
            cmd.Connection = mConexion.getConexion();

            try
            {
                // Ejecutar el comando
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Close(); // Cerrar el lector de datos

                MessageBox.Show("Registro insertado correctamente.");
                MostrarAllRegistros(); // Actualiza el DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el registro: " + ex.Message);
            }
        
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void MostrarAllRegistros()
        {
            string inve = "SELECT * FROM empleados";

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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEdad_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textEdad.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor, ingresa solo números.");
                textEdad.Text = System.Text.RegularExpressions.Regex.Replace(textEdad.Text, "[^0-9]", "");
                textEdad.SelectionStart = textEdad.Text.Length; // Mueve el cursor al final
            }
        }
    }
}