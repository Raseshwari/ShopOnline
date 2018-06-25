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
    public class BooksController:Controller
    {
        private IbookDetails _bookDetails;

        public BooksController(IbookDetails bookDetails)
        {
            _bookDetails = bookDetails;
        }

        public IActionResult Details()
        {
            var model = _bookDetails.GetAllBooksInfo();
            return View(model);
        }

        public IActionResult Info(int id)
        {
            var model = _bookDetails.GetBookById(id);
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
        public IActionResult Create(BookEditModel model)
        {
            if (ModelState.IsValid)
            {
                var newBook = new Books();
                newBook.BookName = model.BookName;
                newBook.Type = model.Type;
                newBook.BookAuthor = model.BookAuthor;

                newBook = _bookDetails.Add(newBook);
                return RedirectToAction(nameof(Info), new { id = newBook.BookId });
            }
            else
            {
                return View();
            }
            
        }
    }
}
