using Rent.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rent.UI.Web.Areas.Equipments.Controllers
{
    public class EquipmentController : Controller
    {
        //
        // GET: /Equipments/Equipment/
        public ActionResult Index()
        {
            var EquipmentProcess = new Process.EquipmentProcess();
            var lista = EquipmentProcess.All();
            return View(lista);
        }

        public ActionResult Create()
        {
            var model = new Equipment();

            model.ChangedBy = 0;
            model.ChangedOn = DateTime.Now;
            model.CreatedBy = 0;
            model.CreatedOn = DateTime.Now;

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(Equipment equipment)
        {
            switch(equipment.Year)
            {
                case 0: equipment.Year = 2010; break;
                case 1: equipment.Year = 2011; break;
                case 2: equipment.Year = 2012; break;
                case 3: equipment.Year = 2013; break;
                case 4: equipment.Year = 2014; break;
                case 5: equipment.Year = 2015; break;
                case 6: equipment.Year = 2016; break;
                case 7: equipment.Year = 2017; break;
            }

            var EquipmentProcess = new Process.EquipmentProcess();
            EquipmentProcess.Add(equipment);

            return RedirectToAction("Index");
        }
	}
}