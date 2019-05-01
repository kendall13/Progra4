using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Examen1.Models
{
    public class ClaseDiagnosticoDB
    {
        string connectionString = "Data Source=KENDO;Initial Catalog=OPTICA;Integrated Security=True;MultipleActiveResultSets=True";

        public void RegistrarDiagnostico(ModeloDiagnosticos diagnostico)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("RegistrarDiagnostico", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre_paciente", diagnostico.nombre_paciente);
                cmd.Parameters.AddWithValue("@numero_consulta", diagnostico.numero_consulta);
                cmd.Parameters.AddWithValue("@telefono_paciente", diagnostico.telefono_paciente);
                cmd.Parameters.AddWithValue("@doctor_encargado", diagnostico.doctor_encargado);
                cmd.Parameters.AddWithValue("@tipo_lente", diagnostico.tipo_lente);
                cmd.Parameters.AddWithValue("@fecha_examen", diagnostico.fecha_examen);
                cmd.Parameters.AddWithValue("@fecha_proximo_examen", diagnostico.fecha_proximo_examen);
                cmd.Parameters.AddWithValue("@estado_receta", diagnostico.estado_receta);

                cmd.Parameters.AddWithValue("@oi_SPH", diagnostico.oi_SPH);
                cmd.Parameters.AddWithValue("@oi_CYL", diagnostico.oi_CYL);
                cmd.Parameters.AddWithValue("@oi_EJE", diagnostico.oi_EJE);
                cmd.Parameters.AddWithValue("@oi_DP", diagnostico.oi_DP);
                cmd.Parameters.AddWithValue("@oi_ADD", diagnostico.oi_ADD);
                cmd.Parameters.AddWithValue("@oi_PRISMA", diagnostico.oi_PRISMA);
                cmd.Parameters.AddWithValue("@oi_BASE", diagnostico.oi_BASE);

                cmd.Parameters.AddWithValue("@od_SPH", diagnostico.od_SPH);
                cmd.Parameters.AddWithValue("@od_CYL", diagnostico.od_CYL);
                cmd.Parameters.AddWithValue("@od_EJE", diagnostico.od_EJE);
                cmd.Parameters.AddWithValue("@od_DP", diagnostico.od_DP);
                cmd.Parameters.AddWithValue("@od_ADD", diagnostico.od_ADD);
                cmd.Parameters.AddWithValue("@od_PRISMA", diagnostico.od_PRISMA);
                cmd.Parameters.AddWithValue("@od_BASE", diagnostico.od_BASE);

                cmd.Parameters.AddWithValue("@altura_od", diagnostico.altura_od);
                cmd.Parameters.AddWithValue("@altura_oi", diagnostico.altura_oi);
                cmd.Parameters.AddWithValue("@diagnostico", diagnostico.diagnostico);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public IEnumerable<ModeloDiagnosticos> Cons_Diagnostico()
        {
            List<ModeloDiagnosticos> listaDiagnosticos = new List<ModeloDiagnosticos>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("ConsultarDiagnosticos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                ModeloDiagnosticos diagnostico = new ModeloDiagnosticos();
                
                while (rdr.Read())
                {
                    
                    diagnostico.nombre_paciente = rdr["nombre_paciente"].ToString();
                    diagnostico.numero_consulta = int.Parse(rdr["numero_consulta"].ToString());
                    diagnostico.telefono_paciente = rdr["telefono_paciente"].ToString();
                    diagnostico.doctor_encargado = rdr["doctor_encargado"].ToString();
                    diagnostico.tipo_lente = rdr["tipo_lente"].ToString();
                    diagnostico.fecha_examen = DateTime.Parse(rdr["fecha_examen"].ToString());
                    diagnostico.fecha_proximo_examen = DateTime.Parse(rdr["fecha_proximo_examen"].ToString());
                    diagnostico.tipo_lente = rdr["tipo_lente"].ToString();
                    diagnostico.estado_receta = rdr["estado_receta"].ToString();

                    diagnostico.oi_SPH = float.Parse(rdr["oi_SPH"].ToString());
                    diagnostico.oi_CYL = float.Parse(rdr["oi_CYL"].ToString());
                    diagnostico.oi_EJE = float.Parse(rdr["oi_EJE"].ToString());
                    diagnostico.oi_DP = float.Parse(rdr["oi_DP"].ToString());
                    diagnostico.oi_ADD = float.Parse(rdr["oi_ADD"].ToString());
                    diagnostico.oi_PRISMA = float.Parse(rdr["oi_PRISMA"].ToString());
                    diagnostico.oi_BASE = float.Parse(rdr["oi_BASE"].ToString());

                    diagnostico.od_SPH = float.Parse(rdr["oi_SPH"].ToString());
                    diagnostico.od_CYL = float.Parse(rdr["oi_CYL"].ToString());
                    diagnostico.od_EJE = float.Parse(rdr["oi_EJE"].ToString());
                    diagnostico.od_DP = float.Parse(rdr["oi_DP"].ToString());
                    diagnostico.od_ADD = float.Parse(rdr["oi_ADD"].ToString());
                    diagnostico.od_PRISMA = float.Parse(rdr["oi_PRISMA"].ToString());
                    diagnostico.od_BASE = float.Parse(rdr["oi_BASE"].ToString());

                    diagnostico.altura_od = float.Parse(rdr["altura_od"].ToString());
                    diagnostico.altura_oi = float.Parse(rdr["altura_oi"].ToString());
                    diagnostico.diagnostico = rdr["diagnostico"].ToString();
                     
                    listaDiagnosticos.Add(diagnostico);
                }
                con.Close();
            }
            return listaDiagnosticos;
        }//Fin Cons_Personas -------------------------------------

    }
}
