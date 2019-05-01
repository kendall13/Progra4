using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examen1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Examen1.Controllers
{
    public class OpticaController : Controller
    {
        ClasePacienteDB objetoPaciente = new ClasePacienteDB();
        ClaseDoctorDB objetoDoctor = new ClaseDoctorDB();
        ClaseDiagnosticoDB objetoDiagnostico = new ClaseDiagnosticoDB();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegistrarPaciente(ModeloPaciente unaPesona)
        {
            try
            {
                objetoPaciente.RegistrarPaciente(unaPesona);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        public IActionResult RegistrarDoctor(ModeloDoctor unDoctor)
        {
            try
            {
                objetoDoctor.RegistrarDoctores(unDoctor);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        public IActionResult RegistrarDiagnostico(ModeloDiagnosticos unDiagnostico)
        {
            try
            {
                objetoDiagnostico.RegistrarDiagnostico(unDiagnostico);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        public IActionResult Cons_Diagnostico()
        {
            try
            {
                return View(objetoDiagnostico.Cons_Diagnostico().ToList());
            }
            catch (Exception ex)
            {
                return View(new List<ModeloDiagnosticos>());
            }
        }


    }
}