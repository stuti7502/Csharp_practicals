
public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }

    //tight coupling
    private IStudentRepository _stdRepo = new IStudentRepository();

    public Student()
    {

    }

    public void Save()
    {
        _stdRepo.AddStudent(this);
    }
}

public interface IStudentRepository
{
    void AddStudent(Student std);
    void EditStudent(Student std);
    void DeleteStudent(Student std);

    IList<Student> GetAllStudents();
}

public class StudentRepository: IStudentRepository
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

//Creating objects using the new keyword at all places is repeated code and also make unit testing impossible