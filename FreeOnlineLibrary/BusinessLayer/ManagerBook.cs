using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;
using ServiceLayer;

namespace BusinessLayer
{
    public class ManagerBook
    {
        /// <summary>
        /// This is the business manager for the book domain object. The manager 
        /// calls the service layer functions for the class.
        /// </summary>
        /// <param name="bk"> book object</param>
        public void InsertBook(Book bk)
        {
            var bookRepo = ServiceLayer.Factory.Creates("Book");
            bookRepo.Insert(bk);
        }

        public void Update(Book bk)
        {
            var bookRepo = ServiceLayer.Factory.Creates("Book");
            bookRepo.Update(bk);
        }

        public void Delete(Book bk)
        {
            var bookRepo = ServiceLayer.Factory.Creates("Book");
            bookRepo.Delete(bk);
        }

        public IQueryable<Book> GetAll()
        {
            var bookRepo = ServiceLayer.Factory.Creates("Book");
            return (bookRepo.GetAll().OfType<Book>());
        }

        public IQueryable<Book> SearchByTitle(string title)
        {
            var bookRepo = ServiceLayer.Factory.Creates("Book");
            return (bookRepo.GetBySpecificKey("BookTitle", title).OfType<Book>());
        }

         public IQueryable<Book> SearchByAuthor(string author)
        {
            var bookRepo = ServiceLayer.Factory.Creates("Book");
            return (bookRepo.GetBySpecificKey("Author", author).OfType<Book>());
        }
    }
}
