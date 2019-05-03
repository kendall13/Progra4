using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examen2Progra4.Collections;
using Examen2Progra4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Examen2Progra4.Controllers
{
    public class AcueductoController : Controller
    {
        DataBase db;

        public AcueductoController()
        {
            db = new DataBase();
        }

        public IActionResult Index()
        {
            IEnumerable<Cliente> listaClientes = db.getClientes();
            return View(listaClientes);
        }

        public IActionResult agregarCLiente()
        {
            return View();
        }

        [HttpPost]
        public IActionResult agregarCliente(Cliente cliente)
        {
            int result=db.insertCliente(cliente);
            if (result == 1)
            {
                return View("Index");
            }
            else
            {
                return View();
            }
            
        }

        public IActionResult updateEmpresa()
        {
            return View();
        }

        [HttpPost]
        public IActionResult updateEmpresa(Empresa empresa)
        {
            int respuesta = db.updateEmpresa(empresa);
            if (respuesta == 1)
            {
                return View("verEmpresa");
            }
            else
            {
                return View();
            }
        }

        public IActionResult verEmpresa()
        {
            Empresa empresa = db.getEmpresa();

            return View(empresa);
        }

        public IActionResult agregarConsumo()
        {
               return View();
        }

        [HttpPost]
        public IActionResult agregarConsumo(Consumo consumo)
        {
            int respuesta=db.insertConsumo(consumo);
            if (respuesta == 1)
            {
                return View();
            }
            else
            {
                return View();
            }
        }

        public IActionResult pagarConsumo(string cedula)
        {
            IEnumerable<Consumo> listaConsumos=new List<Consumo>();
            if (!String.IsNullOrEmpty(cedula))
            {
                try
                {
                    listaConsumos = db.consumoPorPagar(int.Parse(cedula));
                }catch(Exception e)
                {

                }
            }
            
            return View(listaConsumos);
        }

        public IActionResult pagar(int mesU,int anoU,int cedula)
        {
            db.pagar(mesU, anoU, cedula);
            return View();
        }
    }
}