using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private BookStoreContext context { get; set; }


        public HomeController(BookStoreContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
            return RedirectToAction("List", "Book");
        }

        [HttpPost]
        public IActionResult Edit(int id, double price)
        {
            Book book = context.Books.Find(id);
            book.Price = price;
            context.SaveChanges();
            return RedirectToAction("List", "Book");

        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {
            context.Books.Remove(book);
            context.SaveChanges();
            return RedirectToAction("List", "Book");
        }
    }
}
