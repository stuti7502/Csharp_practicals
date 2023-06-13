using Practical8;
//INHERITANCE
//SEALED CLASS
sealed class admin : loginig, choices
{
    properties p = new properties();
    home_page h = new home_page();
    student s = new student();
    private void stu_remove()
    {
        s.datas();
        Console.WriteLine("Write the number of a student you want to remove");
        int stu = Convert.ToInt32(Console.ReadLine());
        switch (stu)
        {
            case 1:
                p.data[0][0] = p.data[0][1] = p.data[0][2] = null;
                break;
            case 2:
                p.data[1][0] = p.data[1][1] = p.data[1][2] = null;
                break;
            case 3:
                p.stu_loginid = p.stu_pass = null;
                p.fees = 0;
                break;
            default:
                Console.WriteLine("Wrong");
                break;
        }
    }
    public void choices()
    {
        bool isadmchoice = true;
        while (isadmchoice)
        {
            Console.WriteLine("1. View Student");
            Console.WriteLine("2. Remove Student");
            Console.WriteLine("3. Home Page");

            Console.WriteLine("Enter your choice");
            int adm_choice = Convert.ToInt32(Console.ReadLine());

            switch (adm_choice)
            {
                case 1:
                    Console.Clear();
                    s.datas();
                    break;
                case 2:
                    Console.Clear();
                    stu_remove();
                    break;
                case 3:
                    Console.Clear();
                    h.home();
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
            if (adm_choice == 3)
            {
                isadmchoice = false;
            }
        }
    }
    //METHOD OVERRIDING
    public override void login()
    {
    login:
        Console.WriteLine("Login: ");
        string? loginid = Console.ReadLine();
        Console.WriteLine("Password: ");
        string? pass = Console.ReadLine();
        if (loginid == "admin" && pass == "admin")
        {
            Console.Clear();
            Console.WriteLine("Success");
            choices();
        }
        else
        {
            Console.WriteLine("Please enter correct id and password");
            goto login;
        }

    
    }
}
