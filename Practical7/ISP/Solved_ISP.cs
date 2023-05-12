public interface Itasks
{
    void register();
    void login(string username);
}
public interface Istudent
{
    void viewmarks();
}
public interface Ifaculty
{
    void addmarks(string subject);
}
public class Student : Itasks, Istudent
{
    public string name;
    public int[] marks;
    public void register()
    {
        name = Console.ReadLine();
    }
    public void login(string username)
    {
        if (username == name)
        {
            //if student is registered the name and username should match and can login
            Console.WriteLine("You are logged in!");
        }
        else
        {
            //if not then user does not exist
            Console.WriteLine("User does not exist");
        }
    }
    
    public void viewmarks()
    {
        if (marks > 90)
        {
            Console.WriteLine("A");
        }
        else if (marks > 80)
        {
            Console.WriteLine("B");
        }
        else if (marks > 70)
        {
            Console.WriteLine("C");
        }
        else (marks < 69)
        {
            Console.WriteLine("D");
        }
    }
}

public class faculty : Itasks, Ifaculty
{
    public string name;
    public int[] marks;
    public void register()
    {
        name = Console.ReadLine();
    }
    public void login(string username)
    {
        if (username == name)
        {
            //if student is registered the name and username should match and can login
            Console.WriteLine("You are logged in!");
        }
        else
        {
            //if not then user does not exist
            Console.WriteLine("User does not exist");
        }
    }
    public void addmarks(string subject)
    {

        int addmark = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < subject.Length; i++)
        {
            marks[i] = addmark;
        }
    }
}