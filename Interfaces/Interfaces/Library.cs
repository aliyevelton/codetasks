using Interfaces.Exceptions;
using Interfaces.Interface;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Interfaces
{
    public class Library : IEntity
    {
        public int Id { get; set; }
        public int BookLimit { get; set; }
        private Book[] Books = new Book[0];
        public bool isDeleted { get; set; } = false;
        public bool bookExists = false;
        public Library(int bookLimit)
        {
            BookLimit = bookLimit;
        }

        public void AddBook(Book book)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (!Books[i].IsDeleted)
                {
                    for(int j = 0; j < Books.Length; j++)
                    {
                        if (Books[j].Name == book.Name)
                        {
                            bookExists = true;
                        }
                    }
                }
            }
            if (bookExists)
            {
                throw new AlreadyExistsException("bu kitab var canciyer");
            }
            else if (Books.Length == BookLimit)
            {
                throw new CapacityLimitException("kitabxana doludu");
            }
            else
            {
                Array.Resize(ref Books, Books.Length + 1);
                Books[Books.Length - 1] = book;
                Console.WriteLine("kitab ugurla elave olundu");
            }
        }

        public Book GetBookById(int id)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Id == id)
                {
                    if (!Books[i].IsDeleted) return Books[i];
                }
            }
            throw new NotFoundException("bele kitab yoxdu");
        }
    }
}