using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TareaLavanderia.Models;

namespace TareaF.Controllers
{
    public class LavanderiaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;

        public LavanderiaController()
        {
            sqlite_conn = new SQLiteConnection("Data Source=database.sqlite;Version=3;");
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText =
          @"CREATE TABLE IF NOT EXISTS
          Cliente (
          [Cedula]     INTEGER NOT NULL PRIMARY KEY,
          [Nombre]   NVARCHAR(2048) NOT NULL,
          [Email]   NVARCHAR(2048) NOT NULL,
          [Direccion]   NVARCHAR(2048) NOT NULL,
          [Telefono1]   INTEGER NOT NULL,
          [Telefono2]   INTEGER NULL)";
            sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText =
              @"CREATE TABLE IF NOT EXISTS
          Prenda (
          [id_Prenda]     INTEGER NOT NULL PRIMARY KEY,
          [CedulaPropietario]   INTEGER NOT NULL,
          [TipoPrenda]   NVARCHAR(2048) NOT NULL,
          [TipoTela]   NVARCHAR(2048) NOT NULL,
          [DescLavado]   NVARCHAR(2048) NOT NULL,
          FOREIGN KEY (CedulaPropietario) REFERENCES Cliente(Cedula)
            )";
            sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText =
                @"CREATE TABLE IF NOT EXISTS
          Servicios (
          [id_Servicio]     INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
          [CedulaPropietario]   INTEGER NOT NULL,
          [id_Prenda]   INTEGER NOT NULL,
          [DescLavado]   NVARCHAR(2048) NOT NULL,
          [Comentarios]   NVARCHAR(2048) NOT NULL,
          [EstadoServicio]   NVARCHAR(2048) NOT NULL,
          [FechaRecibido]  NVARCHAR(2) NOT NULL,
          [FechaDevolucion]   NVARCHAR(2) NOT NULL,
          FOREIGN KEY (CedulaPropietario) REFERENCES Cliente(Cedula),
          FOREIGN KEY (id_Prenda) REFERENCES Prenda(id_Prenda)
           )";
            sqlite_cmd.ExecuteNonQuery();


        }

        public IActionResult AgregarCliente()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AgregarCliente(Cliente cliente)
        {
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO Cliente (Nombre, Email, Direccion, Telefono1, Telefono2) " +
                 "VALUES ('" + cliente.Nombre + "','" + cliente.Email + "','" + cliente.Direccion + "','" + cliente.Telefono1 + "','" + cliente.Telefono2 + "');";

            sqlite_cmd.ExecuteNonQuery();



            return RedirectToAction("MostrarClientes");
        }

        public IActionResult AgregarPrenda()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AgregarPrenda(Prenda prenda)
        {

            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO Prenda (id_Prenda,CedulaPropietario,TipoPrenda,TipoTela,DescLavado) " +
                 "VALUES ('" + prenda.id_Prenda + "','" + prenda.CedulaPropietario + "','" + prenda.TipoPrenda + "','" + prenda.TipoTela + "','" + prenda.DescLavado + "');";

            sqlite_cmd.ExecuteNonQuery();

            return RedirectToAction("MostrarPrendas");
        }

        public IActionResult MostrarClientes()
        {
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "select * from cliente";
            SQLiteDataReader reader;
            reader = sqlite_cmd.ExecuteReader();
            IList<Cliente> lista = new List<Cliente>();
            while (reader.Read())
            {
                lista.Add(new Cliente(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5)));
            }

            ViewBag.ItemList = lista;
            return View(lista);
        }

        public IActionResult MostrarPrendas()
        {
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "select * from prenda";
            SQLiteDataReader reader;
            reader = sqlite_cmd.ExecuteReader();
            IList<Prenda> lista = new List<Prenda>();
            while (reader.Read())
            {
                lista.Add(new Prenda(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4)));
            }
            return View(lista);
        }

        public IActionResult AgregarServicio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AgregarServicio(Servicio servicio)
        {

            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
             sqlite_cmd.CommandText = "INSERT INTO SERVICIOS (id_Servicio, cedulaPropietario, id_Prenda, descLavado, comentarios, estadoServicio, fechaRecibido, fechaDevolucion) " +
                  "VALUES ('" + servicio.id_Servicio + "','" + servicio.CedulaPropietario + "','" + servicio.id_Prenda + "','" + servicio.DescLavado + "','" + servicio.Comentarios + "','" +servicio.EstadoServicio + "','"+servicio.FechaRecibido+ "','" + servicio.FechaDevolucion + "');";

             sqlite_cmd.ExecuteNonQuery();

            return RedirectToAction("MostrarServicios");
        }


        public IActionResult MostrarServicios()
        {
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "select * from servicios";
            SQLiteDataReader reader;
            reader = sqlite_cmd.ExecuteReader();
            IList<Servicio> lista = new List<Servicio>();
            while (reader.Read())
            {
                lista.Add(new Servicio(reader.GetInt32(0),reader.GetInt32(1),reader.GetInt32(2),reader.GetString(3),
                    reader.GetString(4),reader.GetString(5),reader.GetString(6),reader.GetString(7)));
            }
        
            return View(lista);
        }

    }
}