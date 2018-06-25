using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopOnline.Models;
using ShopOnline.Services;

namespace ShopOnline.Pages.LipColors
{
    public class EditModel : PageModel
    {
        private ILipColorsDetails _lipColorDetails;

        [BindProperty]
        public LipColor LipColor { get; set; }
        public EditModel(ILipColorsDetails lipColorDetails)
        {
            _lipColorDetails = lipColorDetails;
        }
        public IActionResult OnGet(int id)
        {
            LipColor = _lipColorDetails.GetLipColorById(id);
            if (LipColor == null) {
                return RedirectToAction("Details", "Lip");
            }

            return Page();
        }

        public IActionResult OnPost() {
            if (ModelState.IsValid) {
                _lipColorDetails.Update(LipColor);
                return RedirectToAction("Info", "Lip", new { id = LipColor.Cprodid });
            }

            return Page();
        }
    }
}