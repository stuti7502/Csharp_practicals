class CustomException: Exception
{
    public CustomException()
    {

    }
    public CustomException(string message): base(message) { }

}
class home_page
{
   
    public void home()
    {
        admin a = new admin();
        student s = new student();
        Console.WriteLine("-----HOME PAGE-----");
        Console.WriteLine("1. Admin");
        Console.WriteLine("2. Student");
        Console.WriteLine("3. Exit");
        //EXCEPTION HANDLING
        try
        {
            
                int choice;
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        a.login();
                        break;
                    case 2:
                        Console.WriteLine("1. Login");
                        Console.WriteLine("2. Register");
                        Console.WriteLine("3. Home Page");
                        Console.WriteLine("Enter choice");
                        int y = Convert.ToInt32(Console.ReadLine());
                        s.stu_choice(y);
                        break;
                    case 3:
                        break;
                    default:
                        throw new CustomException("Wrong Input found! Number should be 1, 2 or 3!");

            }
        }
        catch(CustomException ex) 
        { 
            Console.WriteLine(ex.Message); 
        }
        finally
        {
           home();
        }
    }
}
