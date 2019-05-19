using Microsoft.AspNetCore.Mvc;
using StackOverflow.Models;
using System.Linq;

namespace StackOverflow.Controllers
{
    public class ProblemaController: Controller
    {
        private StackOverflowContext context;

        // Injeção de Dependência!
        public ProblemaController(StackOverflowContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var problemas = context.Problemas.ToList();
            return View(problemas);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Problema p)
        {
            context.Problemas.Add(p);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var p = context.Problemas.Find(id);
            
            //context.Entry(p).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            context.Problemas.Remove(p);


            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}