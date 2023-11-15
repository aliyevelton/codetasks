using TaskEnums.Utils;

namespace TaskEnums
{
    internal class User : Account
    {
        private static int _id = 0;
        public int Id { get; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        private string password;
        public string Password
        {
            get => password;
            set
            {
                if (PasswordChecker(value))
                    password = value;
                else throw new IncorrectPasswordException("Shifre teleblere uygun deyil");
            }
        }

        public User(string fullname, string email, string password)
        {
            _id++;
            Id = _id;
            Fullname = fullname;
            Email = email;
            Password = password;
        }

        public override bool PasswordChecker(string Password)
        {
            bool upperchecker = false;
            bool lowerchecker = false;
            bool hasdigit = false;
            if (Password.Length >= 8)
            {

                for (int i = 0; i < Password.Length; i++)
                {
                    if (Char.IsUpper(Password[i]))
                    {
                        upperchecker = true;
                    }
                    if (Char.IsLower(Password[i]))
                    {
                        lowerchecker = true; 
                    }
                    if (Char.IsDigit(Password[i]))
                    {
                        hasdigit = true; 
                    }
                }
                if (hasdigit && upperchecker && lowerchecker)
                    return true;
            }
            return false;
        }

        public override string ShowInfo()
        {
            return $"Id:{Id}, Full Name: {Fullname}, Email: {Email}";
        }
    }
}
