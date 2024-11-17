using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Actividad___Conexión_a_PostgreSQL.Models
{
    public class PersonaDatabase
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=123;Database=Actividad SL2";
        public NpgsqlConnection Connect()
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(connectionString);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                return null;
            }
        }

        public List<Persona> ObtenerPersonas()
        {
            // Obtiene todas las personas de la base de datos.
            List<Persona> personas = new List<Persona>();
            string query = "SELECT * FROM persona";

            try
            {
                using (var conn = Connect())
                {
                    if (conn == null) return null;
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                personas.Add(new Persona
                                {
                                    Id = reader.GetInt32(0),
                                    Nombre = reader.GetString(1),
                                    Apellido = reader.GetString(2),
                                    FechaNacimiento = reader.GetDateTime(3),
                                    Sexo = reader.GetChar(4)
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener personas: " + ex.Message);
            }

            return personas;
        }

        public void InsertarPersona(Persona persona)
        {
            // Inserta una nueva persona en la base de datos.
            string query = $"INSERT INTO Persona (id, nombre, apellido, fecha_nacimiento, sexo) VALUES ('{persona.Id}', '{persona.Nombre}', '{persona.Apellido}', '{persona.FechaNacimiento}','{persona.Sexo}')";

            EjecutarNonQuery(query);
        }

        public void EliminarPersona(int id)
        {
            // Elimina una persona por su ID.
            string query = $"DELETE FROM Persona WHERE id = {id}";
            EjecutarNonQuery(query);
        }

        public void ModificarPersona(Persona persona)
        {
            // Modifica una persona existente en la base de datos.
            string query = $"UPDATE Persona SET nombre = '{persona.Nombre}', apellido = '{persona.Apellido}' WHERE id = {persona.Id}";
            EjecutarNonQuery(query);
        }

        private void EjecutarNonQuery(string query) // Método interno auxiliar
        {
            try
            {
                using (var conn = Connect())
                {
                    if (conn == null) return;
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la operación: " + ex.Message);
            }
        }

    }
}

