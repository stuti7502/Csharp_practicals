class Program
{
    static void Main(string[] args)
    {
        Iperson person = new staff();
        Console.WriteLine(person.GetName());
        person = new student();
        Console.WriteLine(person.GetName());
    }
}
public interface Iperson
{
    string GetName();
}
public class staff: Iperson
{
    public string GetName()
    {
        return "staff_name";
    }
}
public class student : Iperson
{
    public string GetName()
    {
        return "student_name";
    }
}

//In the above example, it will not conflict and give the correct output