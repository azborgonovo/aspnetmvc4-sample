using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc4ApplicationSample.Domain.Models;
using Mvc4ApplicationSample.Infrastructure.Data;
using Mvc4ApplicationSample.Domain.Repositories;

namespace Mvc4ApplicationSample.Controllers
{
    public class PessoasController : Controller
    {
        private IPessoasRepository _pessoas;

        public PessoasController(IPessoasRepository pessoas)
        {
            if (pessoas == null) throw new ArgumentNullException("pessoas");

            _pessoas = pessoas;
        }

        //
        // GET: /Pessoas/

        public ActionResult Index()
        {
            return View(_pessoas.Pessoas.ToList());
        }

        //
        // GET: /Pessoas/Details/5

        public ActionResult Details(int id = 0)
        {
            Pessoa pessoa = _pessoas.Find(id);
            if (pessoa == null)
            {
                return HttpNotFound();
            }
            return View(pessoa);
        }

        //
        // GET: /Pessoas/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Pessoas/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                _pessoas.Add(pessoa);
                _pessoas.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pessoa);
        }

        //
        // GET: /Pessoas/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Pessoa pessoa = _pessoas.Find(id);
            if (pessoa == null)
            {
                return HttpNotFound();
            }
            return View(pessoa);
        }

        //
        // POST: /Pessoas/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                _pessoas.Update(pessoa);
                _pessoas.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pessoa);
        }

        //
        // GET: /Pessoas/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Pessoa pessoa = _pessoas.Find(id);
            if (pessoa == null)
            {
                return HttpNotFound();
            }
            return View(pessoa);
        }

        //
        // POST: /Pessoas/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var pessoa = _pessoas.Find(id);
            _pessoas.Remove(pessoa);
            _pessoas.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            _pessoas.Dispose();
            base.Dispose(disposing);
        }
    }
}