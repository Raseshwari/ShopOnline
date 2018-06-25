using Microsoft.AspNetCore.Mvc;
using ShopOnline.Models;
using ShopOnline.Services;
using ShopOnline.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOnline.Controllers
{
    public class LipController : Controller
    {
        private ILipColorsDetails _lipColorDetails;

        public LipController(ILipColorsDetails lipColorDetails)
        {
            _lipColorDetails = lipColorDetails;
        }

        public IActionResult Details()
        {
            var model = _lipColorDetails.GetAll();
            return View(model);
        }

        public IActionResult Info(int id)
        {
            var model = _lipColorDetails.GetLipColorById(id);
            if (model == null)
            {
                return RedirectToAction(nameof(Details));
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(LipEditModel lipEditModel)
        {
            if (ModelState.IsValid)
            {
                var newLipColor = new LipColor();
                newLipColor.Cprodname = lipEditModel.Cprodname;
                newLipColor.CShade = lipEditModel.CShade;
                newLipColor = _lipColorDetails.AddLipColor(newLipColor);
                return RedirectToAction(nameof(Info), new { id = newLipColor.Cprodid});
            }
            else
            {
                return View();
            }
        }
        
    }
}
