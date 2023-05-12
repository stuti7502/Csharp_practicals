//ISP(Interface segregation Principle) high - level modules / classes should not depend on low-level modules/classes
//both should depend upon abstractions.

using System;
using System.Xml.Linq;

public interface Itask
{
    void register();
    void login(string username);
    void addmarks(string subject);
    void viewmarks();
}

public class Student: Itask
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

public class faculty : Itask
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
//student class does not have to implement all the methods, since it does not have anything to do with that and same with faculty class
//(it does not need to view marks) 