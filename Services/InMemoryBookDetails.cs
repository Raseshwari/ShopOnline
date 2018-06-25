using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopOnline.Models;

namespace ShopOnline.Services
{
    /*public class InMemoryBookDetails : IbookDetails
    {
        List<Books> _books;

        public InMemoryBookDetails()
        {
            _books = new List<Books>
            {
                new Books{BookId=45, BookAuthor="Khalid Hosseini", BookName="Thousand Splendid Suns"},
                new Books{BookId=66, BookAuthor="Jeffrey Archery", BookName="Prisoner of Birth"},
                new Books{BookId=75, BookAuthor="Sidney Sheldon", BookName="Angels and Demons" }
            };
        }

        public Books Add(Books book)
        {
            book.BookId = _books.Max(b => b.BookId) + 1;
            _books.Add(book);
            return book;
        }

        public IEnumerable<Books> GetAllBooksInfo()
        {
            return _books.OrderBy(b => b.BookName);
        }

        public Books GetBookById(int id)
        {
            return _books.FirstOrDefault(b => b.BookId == id);
        }

        
    }*/
}
