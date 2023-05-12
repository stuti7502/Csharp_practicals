//DIP - Dependency Inversion Principle -- High-level modules should not depend on low-level modules. Both should depend on abstraction
public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }

    //tight coupling
    private StudentRepository _stdRepo = new StudentRepository();

    public Student()
    {

    }

    public void Save()
    {
        _stdRepo.AddStudent(this);
    }
}

public class StudentRepository
{
    public void AddStudent(Student std)
    {
        Console.WriteLine("student added");
    }

    public void DeleteStudent(Student std)
    {
        Console.WriteLine("student deleted");
    }

    public void EditStudent(Student std)
    {
        Console.WriteLine("edit details");
    }

    public IList<Student> GetAllStudents()
    {
        Console.WriteLine("student details");
    }
}