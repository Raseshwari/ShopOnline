using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopOnline.Models;
using ShopOnline.Services;


namespace ShopOnline.Pages.Book
{
    public class EditModel : PageModel
    {
        private IbookDetails _ibookDetails;

        [BindProperty]
        public Books Books { get; set; }

        public EditModel(IbookDetails ibookDetails)
        {
            _ibookDetails = ibookDetails;
        }
        public IActionResult OnGet(int id)
        {
            Books = _ibookDetails.GetBookById(id);
            if (Books == null) {
                return RedirectToAction("Details", "Books");
            }

            return Page();
        }

        public IActionResult OnPost() {
            if (ModelState.IsValid) {
                _ibookDetails.Update(Books);
                return RedirectToAction("Info", "Books", new { id=Books.BookId});
            }

            return Page();
        }
    }
}