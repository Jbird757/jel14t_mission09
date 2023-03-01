using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jel14t_mission09.Models
{
    public class EFBookstoreRepository :IBookstoreRepository
    {
        private BookstoreContext _context { get; set; }

        public EFBookstoreRepository (BookstoreContext temp)
        {
            _context = temp;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
