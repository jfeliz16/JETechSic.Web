using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtreme.AspNet.Mvc;
using JETech.SIC.Web.Models.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JETech.NetCoreWeb.Controls.Menu;
using DevExtreme.AspNet.Data;

namespace JETech.SIC.Web.Controllers.Client
{
    public class ClientMantController : Controller
    {        

        private string GetPathView(string viewName)
        {
            return "Views/Client/ClientMant/" + viewName + ".cshtml";
        }

        // GET: ClientController
        public ActionResult Index()
        {
            //List<ClientViewModel> listClient = new List<ClientViewModel>
            //{
            //    new ClientViewModel
            //    {
            //        FullName = "Jose Feliz",
            //        FirstName = "Jose",
            //        LastName = "Feliz",
            //        CellPhome = "809-999-9999",
            //        StatusName = "ACTIVO"
            //    },
            //    new ClientViewModel
            //    {
            //        FullName = "Manuel Almonte",
            //        FirstName = "Manuel",
            //        LastName = "Almonte",
            //        CellPhome = "809-999-9999",
            //        StatusName = "ACTIVO"
            //    },
            //    new ClientViewModel
            //    {
            //        FullName = "Miladys Santana",
            //        FirstName = "Miladys",
            //        LastName = "Santana",
            //        CellPhome = "809-999-9999",
            //        StatusName = "ACTIVO"
            //    },
            //    new ClientViewModel
            //    {
            //        FullName = "Andrick Lora",
            //        FirstName = "Andrick",
            //        LastName = "Lora",
            //        StatusName = "ACTIVO"
            //    }
            //};

            return View(GetPathView("Index"));
        }

        //[HttpGet]
        //public ActionResult Get()
        //{
        //    List<ClientViewModel> listClient = new List<ClientViewModel>
        //    {
        //        new ClientViewModel
        //        {
        //            FullName = "Jose Feliz",
        //            FirstName = "Jose",
        //            LastName = "Feliz",
        //            CellPhome = "809-999-9999",
        //            StatusName = "ACTIVO"
        //        },
        //        new ClientViewModel
        //        {
        //            FullName = "Manuel Almonte",
        //            FirstName = "Manuel",
        //            LastName = "Almonte",
        //            CellPhome = "809-999-9999",
        //            StatusName = "ACTIVO"
        //        },
        //        new ClientViewModel
        //        {
        //            FullName = "Miladys Santana",
        //            FirstName = "Miladys",
        //            LastName = "Santana",
        //            CellPhome = "809-999-9999",
        //            StatusName = "ACTIVO"
        //        },
        //        new ClientViewModel
        //        {
        //            FullName = "Andrick Lora",
        //            FirstName = "Andrick",
        //            LastName = "Lora",
        //            StatusName = "ACTIVO"
        //        }
        //    };

        //    return listClient;
        //}

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
        public ActionResult Create(AddClientViewModel model)
        {            
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(GetPathView("Create"));
                }
                return RedirectToAction(GetPathView("Index"));
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

        [HttpGet]
        public object GetActions(DataSourceLoadOptions loadOptions) {
            IEnumerable<MenuItem> menuItems = new []
            {
                new MenuItem{                    
                    icon = "more",
                    items  = new[] {
                        new MenuItem {
                            text = "Enable//Disable"
                        },
                        new MenuItem {
                            text = "Print",
                            icon = "print"                            
                        }
                    } 
                }
            };

            return DataSourceLoader.Load(menuItems, loadOptions);
        }
    }
}
