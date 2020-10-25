using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JETech.SIC.Web.Models.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JETech.SIC.Web.Controllers.Client
{
    public class ClientController : Controller
    {        

        private string GetPathView(string viewName)
        {
            return "Views/Client/ClientMant/" + viewName + ".cshtml";
        }

        // GET: ClientController
        public ActionResult Index()
        {
            List<ClientViewModel> listClient = new List<ClientViewModel>
            {
                new ClientViewModel
                {
                    FullName = "Jose Feliz",
                    FirstName = "Jose",
                    LastName = "Feliz",
                    CellPhome = "809-999-9999",
                    StatusName = "ACTIVO"
                },
                new ClientViewModel
                {
                    FullName = "Manuel Almonte",
                    FirstName = "Manuel",
                    LastName = "Almonte",
                    CellPhome = "809-999-9999",
                    StatusName = "ACTIVO"
                },
                new ClientViewModel
                {
                    FullName = "Miladys Santana",
                    FirstName = "Miladys",
                    LastName = "Santana",
                    CellPhome = "809-999-9999",
                    StatusName = "ACTIVO"
                },
                new ClientViewModel
                {
                    FullName = "Andrick Lora",
                    FirstName = "Andrick",
                    LastName = "Lora",
                    StatusName = "ACTIVO"
                }
            };

            return View(GetPathView("Index"), listClient);
        }

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            return View(GetPathView("Create"));
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
