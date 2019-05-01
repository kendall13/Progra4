using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Examen1.Models
{
    public class ClaseDoctorDB
    {
        string connectionString = "Data Source=KENDO;Initial Catalog=OPTICA;Integrated Security=True;MultipleActiveResultSets=True";

        public void RegistrarDoctores(ModeloDoctor somguan)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("RegistrarDoctores", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_doctor", somguan.id_doctor);
                cmd.Parameters.AddWithValue("@nombre", somguan.nombre);
                cmd.Parameters.AddWithValue("@sexo", somguan.sexo);
                cmd.Parameters.AddWithValue("@telefono", somguan.telefono);
                cmd.Parameters.AddWithValue("@direccion", somguan.direccion);
                cmd.Parameters.AddWithValue("@edad", somguan.edad);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
