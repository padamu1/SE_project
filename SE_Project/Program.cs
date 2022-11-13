using SEProject;
using SEProject.Data;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("SE Project Start");
        StringExpression model = new StringExpression();
        model.Set(new User());

        Stopwatch st = new Stopwatch();
        st.Start();
        string context = "SetUserName(\"new user\")";
        StringParser stringParser = new StringParser();
        stringParser.Parse(context);
        model.Start(stringParser);
        st.Stop();

        Console.WriteLine("1.경과 시간 : " + st.Elapsed.ToString());

        st = new Stopwatch();
        st.Start();
        User user = new User();
        user.SetUserName("user name");

        st.Stop();
        Console.WriteLine("2.경과 시간 : " + st.Elapsed.ToString());
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