abstract class Department
{
    public int dept_id { get; set; }
    public abstract void Enroll();
}

//instead of modifiying above class we will make an extension, hence we are not violating OCP
class CE_dept: Department
{
    public override void Enroll()
    {
        Console.WriteLine("Enrolled to CE");
    }
}
class IT_dept: Department
{
    public override void Enroll()
    {
        Console.WriteLine("Enrolled to IT");
    }
}
