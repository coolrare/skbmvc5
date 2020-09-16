using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ClientsController : Controller
    {
        static List<Client> data = new List<Client>() {
            new Client() { Id = 1, Name = "Duotify", Phone = "0222221111" },
            new Client() { Id = 2, Name = "Miniasp", Phone = "0937348483" },
            new Client() { Id = 3, Name = "SKBank", Phone = "0483743829" },
        };

        public ClientsController()
        {
        }

        // GET: Clients
        public ActionResult Index()
        {
            return View(data);
        }

        // GET: Clients/Details/5
        public ActionResult Details(int id)
        {
            var item = data.FirstOrDefault(p => p.Id == id);

            return View(item);
        }

        // GET: Clients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clients/Create
        [HttpPost]
        public ActionResult Create(Client client)
        {
            try
            {
                data.Add(client);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clients/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Clients/Edit/5
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

        // GET: Clients/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clients/Delete/5
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
    }
}
