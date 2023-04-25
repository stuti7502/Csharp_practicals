// See https://aka.ms/new-console-template for more information

//Create a Cutomer_Account class 

namespace Practical2
{
    class Customer_Account
    {
        //declare variables
        string? bank_name;
        long customer_accountNo;
        string customer_name;

        //Constructor
        private Customer_Account(long accountNo, string customerName)
        {
            //initializing member class
            customer_accountNo = accountNo;
            customer_name = customerName;
        }


        //create a method
        public void printInfo()
        {
            //prints all members
            Console.WriteLine("Bank Name: " + bank_name);
            Console.WriteLine("Account Number: " + customer_accountNo);
            Console.WriteLine("Customer Name: " + customer_name);
        }

        static void Main()
        {
            //define customer_Account in main method

            Console.WriteLine("Enter Account Number");
            var account = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Customer Name");
            string customer = Console.ReadLine();
            Customer_Account customer_acc = new Customer_Account(account, customer);
            Console.WriteLine("Enter Bank Name");
            //Customer_Account customer_acc = new Customer_Account(123, "Stuti");
            customer_acc.bank_name = Console.ReadLine();
            customer_acc.printInfo();
        }


    }
}