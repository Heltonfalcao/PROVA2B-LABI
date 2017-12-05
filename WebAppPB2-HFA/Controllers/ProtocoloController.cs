using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAppPB2_HFA.Models;

namespace WebAppPB2_HFA.Controllers
{
    public class ProtocoloController : Controller
    {
        private ProtocolosContext db = new ProtocolosContext();

        // GET: Protocolo
        public ActionResult Index()
        {
            return View(db.Protocolos.ToList());
        }

        // GET: Protocolo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Protocolo protocolo = db.Protocolos.Find(id);
            if (protocolo == null)
            {
                return HttpNotFound();
            }
            return View(protocolo);
        }

        // GET: Protocolo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Protocolo/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Numero,Detalhes,Enumerador")] Protocolo protocolo)
        {
            if (ModelState.IsValid)
            {
                db.Protocolos.Add(protocolo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(protocolo);
        }

        // GET: Protocolo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Protocolo protocolo = db.Protocolos.Find(id);
            if (protocolo == null)
            {
                return HttpNotFound();
            }
            return View(protocolo);
        }

        // POST: Protocolo/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Numero,Detalhes,Enumerador")] Protocolo protocolo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(protocolo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(protocolo);
        }

        // GET: Protocolo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Protocolo protocolo = db.Protocolos.Find(id);
            if (protocolo == null)
            {
                return HttpNotFound();
            }
            return View(protocolo);
        }

        // POST: Protocolo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Protocolo protocolo = db.Protocolos.Find(id);
            db.Protocolos.Remove(protocolo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
