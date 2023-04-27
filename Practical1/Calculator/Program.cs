
internal class Program
{
    private static void Main(string[] args)
    {
        first:
        Console.WriteLine("Enter first number");
        string first = Console.ReadLine();
        bool checkstr = decimal.TryParse(first, out decimal first1);

        //if statement checks if the FIRST numbere entered is string or number, if it is string it will go to else
        if (checkstr == true)
        {
        second:
            Console.WriteLine("Enter second number");
            string second = Console.ReadLine();
            bool checkstr1 = decimal.TryParse(second, out decimal second1);
            //if statement checks if the SECOND numbere entered is string or number, if it is string it will go to else
            if (checkstr1 == true)
            {

                //exception for handling operation related errors
                try
                {
                    Console.WriteLine($"The sum of {first} and {second} is {first1 + second1}");
                    Console.WriteLine($"The subtraction of {first} and {second} is {first1 - second1}");
                    Console.WriteLine($"The multiplication of {first} and {second} is {first1 * second1}");
                    Console.WriteLine($"The division of {first} and {second} is {first1 / second1}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            //if the SECOND number entered is string, it will show error and will ask for input again
            else
            {
                Console.WriteLine("Not a number! Enter number");
                goto second;
            }
        }
        //if the FIRST number entered is string, it will show error and will ask for input again
        else
        {
            Console.WriteLine("Not a number! Enter number");
            goto first;
        }
    }
}