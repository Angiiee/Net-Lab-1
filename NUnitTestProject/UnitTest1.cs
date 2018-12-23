using NUnit.Framework;
using Lab1.entity;
using Lab1.collection;

namespace Tests
{
    public class Tests
    {
        private BookShopItem bookShop;

        [SetUp]
        public void Setup()
        {
            bookShop = new BookShopItem();
            bookShop.BookShop.Add(new Book(152718, "Book Name 1", "Thomson/Reuters", 1997, 84, 27.5m, "hard", new string[3] {"Author1", "Author2", "Author3" }));
            bookShop.BookShop.Add(new Book(152718, "Book Name 2", "Pearson", 1987, 84, 27.5m, "hard", new string[2] { "Author5", "Author4" }));
            bookShop.BookShop.Add(new Book(152718, "Book Name 3", "Thomson/Reuters", 1977, 84, 27.5m, "soft", new string[1] { "Author1" }));
            bookShop.BookShop.Add(new Book(152718, "Book Name 4", "Thomson/Reuters", 1998, 84, 27.5m, "hard", new string[3] { "Author2", "Author5", "Author7" }));
            bookShop.BookShop.Add(new Book(152718, "Book Name 5", "Penguin Random House", 2000, 84, 27.5m, "soft", new string[3] { "Author8", "Author9", "Author6" }));
            bookShop.BookShop.Add(new Book(152718, "Book Name 6", "Pearson", 2001, 84, 27.5m, "soft", new string[3] { "Author1", "Author2", "Author5" }));
        }

        [Test]
        public void TestFindBooksByAuthor()
        {
            string author = "Author2";
            Assert.AreEqual(3, bookShop.FindBooksByAuthor(author).BookShop.Count);
        }

        [Test]
        public void TestFindBooksByPublisher()
        {
            string publisher = "Thomson/Reuters";
            Assert.AreEqual(3, bookShop.FindBooksByPublisher(publisher).BookShop.Count);
        }

        [Test]
        public void TestFindBooksPublishedSinceYear()
        {
            int year = 1997;
            Assert.AreEqual(3, bookShop.FindBooksPublishedSinceYear(year).BookShop.Count);
        }
    }
}