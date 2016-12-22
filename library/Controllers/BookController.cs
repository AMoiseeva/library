using library.Models;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System;

namespace library.Controllers
{
    public class BookController : Controller
    {
        BookDbContext db = new BookDbContext();

        [HttpGet]
        public ActionResult Index()
        {
            var context = new BookDbContext();
            var list = context.Books.ToList();
            ViewBag.Books = list.OrderBy(x=>x.Name);
            return View();
        }

        [HttpGet]
        public ActionResult Page(int bookId)
        {
            var context = new BookDbContext();
            Book book = context.Books.FirstOrDefault(x => x.Id == bookId);
            ViewBag.book = book;
            ViewBag.comments = context.Comments.Where(x => x.BookId == bookId).ToList();
            ViewBag.links = context.Metas.Where(x => x.BookId == bookId).ToList();
            return View();
        }

        [HttpPost]
        public ActionResult AddComment(int bookId, string comm)
        {
            var context = new BookDbContext();
            context.Comments.Add(new Comment
            {
                Text = comm,
                BookId = bookId
            });
            context.SaveChanges();
            return RedirectToAction("Page",new { @bookId = bookId });
        }

        [HttpGet]
        public ActionResult Attribute(int id)
        {
            var context = new BookDbContext();
            List<string> attribute;
            if (id == 1)
            { attribute = context.Books.Select(x => x.Genre).Distinct().ToList();
                ViewBag.str = "Жанры";
                    }
            else
            { attribute = context.Books.Select(x => x.Author).Distinct().ToList();
                ViewBag.str = "Авторы";
            }
            attribute.Sort();
            ViewBag.attribute = attribute;
            ViewBag.id = id;
            return View();
        }

        [HttpGet]
        public ActionResult List(string attribute, int id)
        {
            var context = new BookDbContext();
            List<Book> list;
            if (id ==1)
                list = context.Books.Where(x => x.Genre == attribute).ToList();
            else
                list = context.Books.Where(x => x.Author == attribute).ToList();
            ViewBag.Books = list;
            ViewBag.attribute = attribute;
            return View();
        }

        [HttpGet]
        public FileContentResult LoadingBook(int metaId)
        {
            var context = new BookDbContext();
            var meta = context.Metas.FirstOrDefault(x => x.Id == metaId);
            Link link = context.Links.FirstOrDefault(x => x.Id == meta.LinkId);
            var file = new FileContentResult(link.Book, "application/octet-stream");
            var book = context.Books.FirstOrDefault(x => x.Id == meta.BookId);
            file.FileDownloadName = book.Name + " - " + book.Author + '.' + meta.Format.ToString();
            return file;
        }
    }
}