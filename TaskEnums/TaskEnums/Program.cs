using TaskEnums;
using TaskEnums.Utils;

try
{
    User user = new("Elton", "alielton@gmail.com", "122Elton");
    Console.WriteLine(user.ShowInfo());
}
catch(IncorrectPasswordException ex)
{
    Console.WriteLine(ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}