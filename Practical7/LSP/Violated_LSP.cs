//Liskov Subsitution Principle - you should be able to use any derived class instead of a parent class and have it behave in the
//same manner without modification

class Program
{
    static void Main(string[] args)
    {
        staff Staff = new student();
        Console.WriteLine(Staff.GetName());
    }
}
public class staff
{
    public virtual string GetName()
    {
        return "staff_name";
    }
}
public class student : staff
{
    public override string GetName()
    {
        return "student_name";
    }
}

//In above example student cannot replace staff, but in main method when we can store the child class object in the
//Parent class Reference variable i.e. staff Staff = new student(); and when we call the GetName i.e. staff.GetName(),
//then we are getting the student_name, not the name of the staff. That means once the child object is replaced
//i.e. staff storing the student object, the behavior is also changed