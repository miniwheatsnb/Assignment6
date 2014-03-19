using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcPet.Utilities;
using System.Net;
using MvcPet.Models;

namespace MvcPet.Controllers
{
    public class InventoryController : Controller
    {
        private InventoryDisplay invDisplay = new InventoryDisplay();
        //
        // GET: /Inventory/
        public ActionResult Index()
        {
            return View(invDisplay.GetPetList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inventory inv = invDisplay.GetInventoryItem(id);
            if (inv == null)
            {
                return HttpNotFound();
            }
            return View(inv);
        }
	}
}