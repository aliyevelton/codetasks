namespace Interface
{
    internal class Library
    {
        public int BookLimit { get; set; }
        private Book[] Books { get; set; }

        public Library(int bookLimit)
        {
            BookLimit = bookLimit;   
        }

        public void AddBook(Book book)
        {

        }
    }
}
