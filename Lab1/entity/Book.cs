using System;
using System.Collections.Generic;

namespace Lab1.entity
{
    /*5. Book: id, Название, Автор (ы), Издательство, Год издания, Количество страниц,
         Цена, Тип переплета.
         Создать массив объектов. Вывести:
         a) список книг заданного автора;
         b) список книг, выпущенных заданным издательством;
         c) список книг, выпущенных после заданного года
     */
    public class Book
    {
        private long id;
        private string name;
        private string publishingHouse;
        private int year;
        private int pageNumber;
        private decimal price;
        private string bindingType;
        private string[] authors;

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string PublishingHouse { get => publishingHouse; set => publishingHouse = value; }
        public int Year { get => year; set => year = value; }
        public int PageNumber { get => pageNumber; set => pageNumber = value; }
        public decimal Price { get => price; set => price = value; }
        public string BindingType { get => bindingType; set => bindingType = value; }
        public string[] Authors { get => authors; set => authors = value; }

        public Book()
        {
        }

        public Book(long id, string name, string publishingHouse, int year, int pageNumber, decimal price, string bindingType, string[] authors)
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


        public override bool Equals(object obj)
        {
            var book = obj as Book;
            return book != null &&
                   Id == book.Id &&
                   Name == book.Name &&
                   PublishingHouse == book.PublishingHouse &&
                   Year == book.Year &&
                   PageNumber == book.PageNumber &&
                   Price == book.Price &&
                   BindingType == book.BindingType &&
                   EqualityComparer<string[]>.Default.Equals(Authors, book.Authors);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, PublishingHouse, Year, PageNumber, Price, BindingType, Authors);
        }
    }
}
