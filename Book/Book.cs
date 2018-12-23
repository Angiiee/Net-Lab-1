using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{

    /*5. Book: id, Название, Автор (ы), Издательство, Год издания, Количество страниц,
         Цена, Тип переплета.
         Создать массив объектов. Вывести:
         a) список книг заданного автора;
         b) список книг, выпущенных заданным издательством;
         c) список книг, выпущенных после заданного года
     */
    class BookItem
    {
        private long id;
        private string name;
        private string publishingHouse;
        private byte year;
        private int pageNumber;
        private decimal price;
        private string bindingType;
        private string[] authors;

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string PublishingHouse { get => publishingHouse; set => publishingHouse = value; }
        public byte Year { get => year; set => year = value; }
        public int PageNumber { get => pageNumber; set => pageNumber = value; }
        public decimal Price { get => price; set => price = value; }
        public string BindingType { get => bindingType; set => bindingType = value; }
        public string[] Authors { get => authors; set => authors = value; }

        public BookItem()
        {
        }

        public BookItem(long id, string name, string publishingHouse, byte year, int pageNumber, decimal price, string bindingType, string[] authors)
        {
            Id = id;
            Name = name;
            PublishingHouse = publishingHouse;
            Year = year;
            PageNumber = pageNumber;
            Price = price;
            BindingType = bindingType;
            Authors = authors;
        }

        public override string ToString()
        {
            string separator = "\n";
            string result = "Book:" + separator;
            result += "Id: " + Id + separator;
            result += "Name: " + Name + separator;
            result += "Page Number: " + PageNumber + separator;
            if (Authors != null)
            {
                result += "Authors: " + separator;
                foreach (string author in Authors)
                {
                    result += author + separator;
                }
            }

            result += "Publishing House: " + PublishingHouse + separator;
            result += "Year: " + Year + separator;
            result += "Binding Type: " + BindingType + separator;
            result += "Price: " + Price + separator;
            return result;
        }

        public static List<BookItem> FindBooksByAuthor(List<BookItem> books, string author)
        {
            List<BookItem> foundBooks = new List<BookItem>();
            foreach (BookItem book in books)
            {
                if (book.Authors != null)
                {
                    foreach (string auth in book.Authors)
                    {
                        if (auth.Equals(author))
                        {
                            foundBooks.Add(book);
                        }
                    }
                }

            }
            return foundBooks;
        }
    }
}
