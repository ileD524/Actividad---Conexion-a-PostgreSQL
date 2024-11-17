using System.Windows.Forms;
using Actividad___Conexión_a_PostgreSQL.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Actividad___Conexión_a_PostgreSQL
{
    public partial class Form1 : Form
    {
        private PersonaDatabase PersonaController = new PersonaDatabase();
        public Form1()
        {
            InitializeComponent();
            cmbSexo.Items.Add("M");
            cmbSexo.Items.Add("F");
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
           try
            {
                Persona nuevaPersona = new Persona
                {
                    Id = int.Parse(txtID.Text),
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    FechaNacimiento = dateTimePicker1.Value,
                    Sexo = Convert.ToChar(cmbSexo.Text)
                };


                // Llamar al método para insertar la nueva persona
                PersonaController.InsertarPersona(nuevaPersona);
                MessageBox.Show("Persona insertada correctamente.");

                //Limpiar controles
                ClearFields();

                //Actualizar el listado de personas
                ListarPersonas();
            }

            catch (FormatException ex)
            {
                // Si ocurre un error de formato, por ejemplo al convertir texto en número
                MessageBox.Show("Error de formato: " + ex.Message);
            }

            catch (Exception ex)
            {
                // Captura cualquier otro tipo de excepción que pueda ocurrir
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            dateTimePicker1.Value = DateTime.Now;
            cmbSexo.Text = "";
        }
        private void ListarPersonas()
        {
            try
            {
                var personas = PersonaController.ObtenerPersonas();
                dataGridView1.DataSource = personas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener personas: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListarPersonas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona personaModificada = new Persona
                {
                    Id = int.Parse(txtID.Text),
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text
                };

                PersonaController.ModificarPersona(personaModificada);
                MessageBox.Show("Persona modificada correctamente.");

                //limpiar los campos
                ClearFields();

                //listar las personas
                ListarPersonas();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error de formato: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al modificar: " + ex.Message);
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                PersonaController.EliminarPersona(id);
                MessageBox.Show("Persona eliminada correctamente.");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error de formato: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar: " + ex.Message);
            }
        }
    }
}
