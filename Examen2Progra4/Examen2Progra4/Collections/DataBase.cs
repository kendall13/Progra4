using Examen2Progra4.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Examen2Progra4.Collections
{
    public class DataBase
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS; Database=Examen2; Integrated Security=SSPI";
        private SqlConnection conn;

        public int insertCliente(Cliente cliente)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("insertCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cedulaI", cliente.cedula);
                cmd.Parameters.AddWithValue("@nombreI", cliente.nombre);
                cmd.Parameters.AddWithValue("@telefonoI", cliente.telefono);
                cmd.Parameters.AddWithValue("@direccionI", cliente.direccion);
                cmd.Parameters.AddWithValue("@medidiorI", cliente.medidor);
                cmd.Parameters.AddWithValue("@tipoDomiI", cliente.tipoDomi);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return 1;
            }catch(Exception e)
            {
                return -1;
            }
        }

        public IEnumerable<Cliente> getClientes()
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("getClientes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                List<Cliente> listaClientes = new List<Cliente>();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.cedula = reader.GetInt32(0);
                    cliente.nombre = reader.GetString(1);
                    cliente.telefono = reader.GetInt32(2);
                    cliente.direccion = reader.GetString(3);
                    cliente.medidor = reader.GetInt32(4);
                    cliente.tipoDomi = reader.GetBoolean(5);
                    listaClientes.Add(cliente);
                }
                con.Close();
                return listaClientes;
            }catch(Exception e)
            {
                IEnumerable<Cliente> lista = new List<Cliente>();
                return lista;
            }
        }
        public int updateEmpresa(Empresa empresa)
            {
                try
                {
                    SqlConnection con = new SqlConnection(connectionString);
                    SqlCommand cmd = new SqlCommand("updateEmpresa", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tituloI", empresa.titulo);
                    cmd.Parameters.AddWithValue("@costoI", empresa.costo);
                    cmd.Parameters.AddWithValue("@baseDomiciliarI", empresa.baseDomiciliar);
                    cmd.Parameters.AddWithValue("@baseEmpresarialI", empresa.baseEmpresarial);
                    cmd.Parameters.AddWithValue("@fechaCobroI", empresa.fechaCobro);
                    cmd.Parameters.AddWithValue("@fechaCorteI", empresa.fechaCorte);
                    cmd.Parameters.AddWithValue("@multaI", empresa.multa);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return 1;
                }
                catch (Exception e)
                {
                    return -1;
                }
        }

        public Empresa getEmpresa()
        {
            Empresa empresa=new Empresa();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("getEmpresa", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                empresa.titulo = reader.GetString(0);
                empresa.costo = reader.GetInt32(1);
                empresa.baseDomiciliar = reader.GetInt32(2);
                empresa.baseEmpresarial = reader.GetInt32(3);
                empresa.fechaCobro = reader.GetInt32(4);
                empresa.fechaCorte = reader.GetInt32(5);
                empresa.multa = reader.GetInt32(5);
            }
            con.Close();

            return empresa;
        }

        public int insertConsumo(Consumo consumo)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("insertConsumo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mesI", consumo.mesU);
                cmd.Parameters.AddWithValue("@anoI", consumo.anoU);
                cmd.Parameters.AddWithValue("@consumoI", consumo.consumoU);
                cmd.Parameters.AddWithValue("@cedulaI", consumo.cedulaU);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public IEnumerable<Consumo> consumoPorPagar(int cedula)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("getConsumoPorPagar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cedulaI", cedula);
                con.Open();
                List<Consumo> listaConsumos = new List<Consumo>();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Consumo consumo = new Consumo();
                    consumo.mesU = reader.GetInt32(0);
                    consumo.anoU = reader.GetInt32(1);
                    consumo.consumoU = reader.GetInt32(2);
                    consumo.cedulaU = reader.GetInt32(3);
                    consumo.pagoU = reader.GetInt32(4);
                    listaConsumos.Add(consumo);
                }
                con.Close();
                return listaConsumos;
            }
            catch (Exception e)
            {
                IEnumerable<Consumo> lista = new List<Consumo>();
                return lista;
            }
        }

        public int pagar(int mes, int ano, int cedula)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("pagar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mesI", mes);
                cmd.Parameters.AddWithValue("@anoI", ano);
                cmd.Parameters.AddWithValue("@cedulaI", cedula);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            catch (Exception e)
            {
                return -1;
            }

        }
    }
    
}
