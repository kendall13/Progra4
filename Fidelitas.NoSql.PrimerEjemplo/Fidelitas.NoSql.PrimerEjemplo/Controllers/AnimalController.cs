using Fidelitas.NoSql.PrimerEjemplo.Collections;
using Fidelitas.NoSql.PrimerEjemplo.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using PagedList;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Fidelitas.NoSql.PrimerEjemplo.Controllers
{
    public class AnimalController : Controller
    {

        private ContextoMongo elContexto = new ContextoMongo();


        public ActionResult LosTratamientos(string id)
        {
            var animales = elContexto.LosAnimales;
            //var filter = Builders<Animales>.Filter.Eq(x => x._id, id);

            var elAnimalito = animales.Find<Animales>(a => a._id == id).FirstOrDefault();
            return View(elAnimalito.tratamiento);
        }


        // GET: Animal
        public ActionResult Index(string currentFilter,string searchString, int? page)
        {
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var animales = elContexto.LosAnimales;
            var losAnimalitos = animales.AsQueryable();
            IEnumerable<Animales> laListaFiltrada = new List<Animales>();
            if (!String.IsNullOrEmpty(searchString))
            {
                laListaFiltrada=losAnimalitos.Where(s => s.Nombre.ToLower().Contains(searchString.ToLower())|| s.Dueno.ToLower().Contains(searchString.ToLower()));
            }
            losAnimalitos.ToList();
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            if (laListaFiltrada.Any<Animales>()||!String.IsNullOrEmpty(searchString))
            {
                return View(laListaFiltrada.ToPagedList(pageNumber, pageSize));
            }
            else
            {
                    return View(losAnimalitos.ToPagedList(pageNumber, pageSize));
            }
            
        }

        // GET: Animal/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Animal/Create
        public ActionResult Insertar()
        {
            return View();
        }

        // POST: Animal/Create
        [HttpPost]
        public ActionResult Insertar(Animales laMascota)
        {
            try
            {
                var animales = elContexto.LosAnimales;
                laMascota.tratamiento = new List<Tratamiento> ();
                animales.InsertOne(laMascota);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Animal/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Animal/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Animal/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Animal/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Create()
        {
            return View();
        }

        // POST: Animal/Create
        [HttpPost]
        public ActionResult Create(Tratamiento tratamiento)
        {
            try
            {
                var animales = elContexto.tratamientos;
                animales.InsertOne(tratamiento);
                return View();
            }
            catch
            {
                return View();
            }
        }
        
    }
}
