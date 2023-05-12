//SRP(Single Responsibilty Principle) - Every software module should have only one reason to change.

private class student
{
    public string name { get; set; }
    public int[] marks { get; set; }
    public void register()
    {
        //registering student to college
        name = Console.ReadLine();
    }
    public void login(string username)
    {
        //loging to college wesite/app by student
        if(username == name)
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
        //adding marks of student by faculty
        int addmark = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < subject.Length; i++)
        {
            marks[i] = addmark;
        }

    }

    public void viewmarks()
    {
        //marks view by students
        if(marks > 90)
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
        else(marks < 69)
        {
            Console.WriteLine("D");
        }
    }
}