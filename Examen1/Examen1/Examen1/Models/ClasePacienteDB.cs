using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Examen1.Models
{
    public class ClasePacienteDB
    {
        string connectionString = "Data Source=KENDO;Initial Catalog=OPTICA;Integrated Security=True;MultipleActiveResultSets=True";

        public void RegistrarPaciente(ModeloPaciente somguan)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("RegistrarPacientes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", somguan.nombre);
                cmd.Parameters.AddWithValue("@cedula", somguan.cedula);
                cmd.Parameters.AddWithValue("@sexo", somguan.sexo);
                cmd.Parameters.AddWithValue("@telefono", somguan.telefono);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", somguan.fecha_nacimiento);
                cmd.Parameters.AddWithValue("@ocupacion", somguan.ocupacion);
                cmd.Parameters.AddWithValue("@edad", somguan.edad);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }





        }
    }
}
