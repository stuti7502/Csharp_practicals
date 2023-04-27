
internal class Program
{
    private static void Main(string[] args)
    {
        first:
        Console.WriteLine("Enter first number");
        string first = Console.ReadLine();
        bool checkstr = int.TryParse(first, out int first1);
        if (checkstr == true)
        {
        second:
            Console.WriteLine("Enter second number");
            string second = Console.ReadLine();
            bool checkstr1 = int.TryParse(second, out int second1);
            if (checkstr1 == true)
            {
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
            else
            {
                Console.WriteLine("Not a number! Enter number");
                goto second;
            }
        }
        else
        {
            Console.WriteLine("Not a number! Enter number");
            goto first;
        }
    }
}