using SEProject.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("SE Project Start");
        StringExpression model = new StringExpression();
        model.Set(new User());
        model.Check();        
        //Action<string> action = ConsoleString;
        //model.Set(action);
        //model.Check();

    }
    static void ConsoleString(string st)
    {
        Console.WriteLine(st);
    }
}

public class User
{
    public string UserName { get; set; }
    public void SetUserName(string userName)
    {
        this.UserName = userName + " 이름";
        Console.WriteLine(userName);
    }
}