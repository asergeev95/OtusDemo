using System;
using System.Collections.Generic;
using System.Linq;
using OtusDemoApplication.ApplicationServices.Models;

namespace OtusDemoApplication.ApplicationServices
{
    public class BookShopService
    {
        private static Shop _shop;

        public BookShopService()
        {
            _shop = new Shop()
            {
                Books = new List<Book>()
            };
        }

        public BookShopService(int initialBooksCount)
        {
            _shop = new Shop
            {
                Books = Enumerable.Range(1, initialBooksCount).Select(index => new Book()
                {
                    Name = $"Book with random name {index}"
                }).ToList()
            };
        }

        public void AddBookToShop(Book book)
        {
            _shop.Books.Add(book);
        }

        public void BuyRandomBook()
        {
            if (_shop.Books.Any())
            {
                _shop.Books.RemoveAt(0);
                return;
            }

            throw new ArgumentNullException();
        }

        public int GetBooksCount()
        {
            return _shop.Books.Count;
        }
    }
}