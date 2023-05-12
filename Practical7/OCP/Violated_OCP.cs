//OCP (Ope/Close Principle) - open for extension, closed for modification)

class student
{
    public string dept { get; set; }

    public void enroll()
    {
        if(this.dept == "CE")
        {
            //enroll process of CE
            Console.WriteLine("Enrolled to CE");
        }
        else if(this.dept == "IT")
        {
            //enroll process of IT
            Console.WriteLine("Enrolled to IT");
        }
        else if (this.dept == "ME")
        {
            //enroll process of ME
            Console.WriteLine("Enrolled to ME");
        }
    }
    //the above will be modified again and agin when anyone enrolls, hence to solve this we will use OCP
}