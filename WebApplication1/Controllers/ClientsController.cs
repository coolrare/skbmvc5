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
        public ActionResult Index(string keyword = null)
        {
            IEnumerable<Client> searched;

            if (String.IsNullOrEmpty(keyword))
            {
                searched = data;
            }
            else
            {
                searched = data.Where(p => p.Name.Contains(keyword));
            }

            return View(searched);
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
            if (ModelState.IsValid)
            {
                data.Add(client);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: Clients/Edit/5
        public ActionResult Edit(int id)
        {
            var item = data.FirstOrDefault(p => p.Id == id);

            return View(item);
        }

        // POST: Clients/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Client client)
        {
            if (ModelState.IsValid)
            {
                var item = data.FirstOrDefault(p => p.Id == id);

                item.Name = client.Name;
                item.Phone = client.Phone;

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: Clients/Delete/5
        public ActionResult Delete(int id)
        {
            var item = data.FirstOrDefault(p => p.Id == id);

            return View(item);
        }

        // POST: Clients/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var item = data.FirstOrDefault(p => p.Id == id);
                data.Remove(item);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
