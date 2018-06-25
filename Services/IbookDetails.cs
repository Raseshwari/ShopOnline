using ShopOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOnline.Services
{
    public interface IbookDetails
    {
        IEnumerable<Books> GetAllBooksInfo();

        Books GetBookById(int id);

        Books Add(Books book);

        Books Update(Books book);
    }
}
