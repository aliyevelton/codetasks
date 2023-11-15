namespace TaskEnums.Utils
{
    public class IncorrectPasswordException: Exception
    {
        public IncorrectPasswordException(string message) : base(message)
        { 
        }

    }
}
