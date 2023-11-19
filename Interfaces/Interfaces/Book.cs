using Interfaces.Interface;

namespace Interfaces
{
    public class Book : IEntity
    {
        private static int _id = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public bool IsDeleted { get; set; } = false;

        public Book(string name, string authorName, int pageCount)
        {
            _id++;
            Id = _id;
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
        }

        public string ShowInfo(string Name, string AuthorName, int PageCount)
        {
            return $"Name: {Name}, Author: {AuthorName}, Page Count: {PageCount}";
        }

        public static bool operator <(Book book1, Book book2) => book1.PageCount < book2.PageCount;
        public static bool operator >(Book book1, Book book2) => book1.PageCount > book2.PageCount;
    }
}