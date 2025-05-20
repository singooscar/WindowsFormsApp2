using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration; 
using System.Data.SqlClient;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string conecctionString =
            ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
        private DateTime fechaFormat;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string conecctionString = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(conecctionString))
                {
                    connection.Open();
                    MessageBox.Show("CONEXION EXITOSA");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"ERROR DE CONEXION: {ex.Message}");

            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            string nombres = textBox4.Text;
                string apellidos = textBox6.Text;
                string cedula = textBox7.Text;
                DateTime fecha_nacimiento = DateTime.Parse(dateTimePicker2.Text);
                string correo = textBox8.Text;

                using (SqlConnection connection = new SqlConnection(conecctionString))
                {
                    connection.Open();
                    string query = "INSERT INTO clientes (nombres, apellidos, cedula,fecha_nacimiento,correo) VALUES (@nombres, @apellidos,@cedula ,@fecha_nacimiento ,@correo)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombres", nombres);
                        command.Parameters.AddWithValue("@apellidos", apellidos);
                        command.Parameters.AddWithValue("@cedula", cedula);
                        command.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
                        command.Parameters.AddWithValue("@correo", correo);

                        command.ExecuteNonQuery();
                        MessageBox.Show("REGISTRO REALIZADO");
                    }




                }




            


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    } }
