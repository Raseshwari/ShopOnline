using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopOnline.Data;
using ShopOnline.Models;

namespace ShopOnline.Services
{
    public class SqlBooksData : IbookDetails
    {
        private ShopOnlineDbContext _context;

        public SqlBooksData(ShopOnlineDbContext context)
        {
            _context = context;
        }
        public Books Add(Books book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return book;
        }

        public IEnumerable<Books> GetAllBooksInfo()
        {
            return _context.Books.OrderBy(b => b.BookId);
        }

        public Books GetBookById(int id)
        {
            return _context.Books.FirstOrDefault(b => b.BookId == id);
        }

        public Books Update(Books book)
        {
            _context.Attach(book).State = EntityState.Modified;
            _context.SaveChanges();
            return book;
        }
    }
}
