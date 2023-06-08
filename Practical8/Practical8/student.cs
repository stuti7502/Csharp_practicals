using Practical8;
//INHERITANCE
class student : loginig
{
    properties p = new properties();
    home_page h = new home_page();
    
   //METHOD OVERLOADING
    public void stu_choice(int x)
    {
        bool isstu_choice = true;
        while (isstu_choice)
        {
            
            try
            {
                Console.WriteLine("Enter your choice");

                switch (x)
                {
                    case 1:
                        Console.Clear();
                        login();
                        break;
                    case 2:
                        Console.Clear();
                        stu_register();
                        break;
                    case 3:
                        Console.Clear();
                        h.home();
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
                if (x == 3)
                {
                    isstu_choice = false;
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
    public void stu_choice()
    {
        bool isstu_choice2 = true;
        while (isstu_choice2)
        {

            Console.WriteLine("1. View Details");
            Console.WriteLine("2. Pay Fees");
            Console.WriteLine("3. LogOut");
            try
            {
                Console.WriteLine("Enter your choice");
                int stu_choice = Convert.ToInt32(Console.ReadLine());

                switch (stu_choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Name " + p.stu_loginid);
                        Console.WriteLine("Password " + p.stu_pass);
                        Console.WriteLine("Fees Pending " + p.fees);
                        break;
                    case 2:
                        Console.Clear();
                        pay_fees();
                        break;
                    case 3:
                        Console.Clear();
                        h.home();
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
                if (stu_choice == 3)
                {
                    isstu_choice2 = false;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
    public void datas()
    {


        if (p.data[0][0] == null)
        {
            Console.WriteLine(" ");
        }
        else
        {
            Console.WriteLine($"1. Name : {p.data[0][0]}, Password : {p.data[0][1]}, Fees amount pending: {p.data[0][2]}");
        }
        if (p.data[1][0] == null)
        {
            Console.WriteLine(" ");
        }
        else
        {
            Console.WriteLine($"2. Name : {p.data[1][0]}, Password : {p.data[1][1]}, Fees amount : {p.data[1][2]}");
        }

        if (p.data[2][0] == "" || p.data[2][0] == null || p.fees == 0)
        {
            Console.WriteLine(" ");
        }
        else
        {
            Console.WriteLine($"3. Name : {p.data[2][0]}, Password : {p.data[2][1]}, Fees amount : {p.data[2][2]}");
        }

    }


    public void stu_register()
    {
        Console.WriteLine("Register: ");
        p.stu_loginid = Console.ReadLine();
        Console.WriteLine("Password: ");
        p.stu_pass = Console.ReadLine();
        Console.WriteLine("Account registered successfully");
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.Clear();
        stu_choice();

    }
    //METHOD OVERRIDING
    public override void login()
    {
        if (p.data[2][0] == "")
        {
            Console.WriteLine("Please register first");
            stu_register();
        }
        else
        {
        login:
            Console.WriteLine("Login: ");
            string? loginid = Console.ReadLine().ToUpper();
            Console.WriteLine("Password: ");
            string? pass = Console.ReadLine().ToUpper();

            if (loginid == p.stu_loginid.ToUpper() && pass == p.stu_pass.ToUpper())
            {
                Console.WriteLine("Success");
                stu_choice();
            }
            else
            {
                Console.WriteLine("Wrong login id or password");
                goto login;
            }
        }

    }
    public void pay_fees()
    {
        if (p.fees == 0)
        {
            Console.WriteLine("Fees has been already paid");
            stu_choice();
        }
        else
        {
            bool isfees = true;
            while (isfees)
            {
                Console.WriteLine("Press 1: if you want to pay in installments");
                Console.WriteLine("Press 2: all together");
                int fees_choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input amount");
                p.stu_fees = Convert.ToInt32(Console.ReadLine());
                switch (fees_choice)
                {
                    case 1:
                        if (p.stu_fees == 15000)
                        {
                            if (p.fees == 30000)
                            {
                                Console.WriteLine("First Installment Paid");
                                p.fees = p.fees - 15000;
                                stu_choice();
                            }
                            else
                            {
                                Console.WriteLine("Second Installment Paid");
                                p.fees = p.fees - 15000;
                                stu_choice();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please enter 15000 as amount");
                            pay_fees();
                        }
                        break;
                    case 2:
                        if (p.fees == 30000)
                        {
                            if (p.stu_fees == 30000)
                            {

                                Console.WriteLine("Success!");
                                p.fees = p.fees - 30000;
                                stu_choice();
                            }
                            else
                            {
                                Console.WriteLine("Please enter 30000 as amount");
                                stu_choice();
                            }
                        }
                        else
                        {
                            Console.WriteLine("You had opted for installment!");
                            stu_choice();
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;

                }
                if (fees_choice == 1 || fees_choice == 2)
                {
                    isfees = false;
                }
            }
        }
    }


   
}