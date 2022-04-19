using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DuAnCuaHang.Data;
using DuAnCuaHang.Models;

namespace DuAnCuaHang.Controllers
{
    public class DatBansController : Controller
    {
        private DuAnCuaHangContext db = new DuAnCuaHangContext();

        // GET: DatBans
       

        // GET: DatBans/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatBan datBan = await db.DatBans.FindAsync(id);
            if (datBan == null)
            {
                return HttpNotFound();
            }
            return View(datBan);
        }

        // GET: DatBans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DatBans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Title,ReleaseDate,Genre,Price")] DatBan datBan)
        {
            if (ModelState.IsValid)
            {
                db.DatBans.Add(datBan);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(datBan);
        }

        // GET: DatBans/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatBan datBan = await db.DatBans.FindAsync(id);
            if (datBan == null)
            {
                return HttpNotFound();
            }
            return View(datBan);
        }

        // POST: DatBans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Title,ReleaseDate,Genre,Price")] DatBan datBan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(datBan).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(datBan);
        }

        // GET: DatBans/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatBan datBan = await db.DatBans.FindAsync(id);
            if (datBan == null)
            {
                return HttpNotFound();
            }
            return View(datBan);
        }

        // POST: DatBans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            DatBan datBan = await db.DatBans.FindAsync(id);
            db.DatBans.Remove(datBan);
            await db.SaveChangesAsync();
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
