using Lab1.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.collection
{
    public class BookShopItem
    {
        private List<Book> bookShop;

        public List<Book> BookShop { get => bookShop; set => bookShop = value; }

        public BookShopItem()
        {
            BookShop = new List<Book>();
        }

        public BookShopItem(List<Book> bookShop)
        {
            BookShop = bookShop;
        }

        public override bool Equals(object obj)
        {
            var item = obj as BookShopItem;
            return item != null &&
                   EqualityComparer<List<Book>>.Default.Equals(BookShop, item.BookShop);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(BookShop);
        }

        public BookShopItem FindBooksByAuthor(string author)
        {
            BookShopItem foundBooks = new BookShopItem();
            foreach (Book book in BookShop)
            {
                if (book.Authors != null)
                {
                    foreach (string auth in book.Authors)
                    {
                        if (auth.Equals(author))
                        {
                            foundBooks.BookShop.Add(book);
                        }
                    }
                }

            }
            return foundBooks;
        }

        public BookShopItem FindBooksByPublisher(string publisher)
        {
            BookShopItem foundBooks = new BookShopItem();
            foreach (Book book in BookShop)
            {
                if (book.PublishingHouse.Equals(publisher))
                {
                    foundBooks.BookShop.Add(book);
                }

            }
            return foundBooks;
        }

        public BookShopItem FindBooksPublishedSinceYear(int year)
        {
            BookShopItem foundBooks = new BookShopItem();
            foreach (Book book in BookShop)
            {
                if (book.Year > year)
                {
                    foundBooks.BookShop.Add(book);
                }

            }
            return foundBooks;
        }
    }
}
