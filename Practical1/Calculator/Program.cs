// See https://aka.ms/new-console-template for more information


try
{
    Console.WriteLine("Enter first number");
    int first = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter second number");
    int second = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"The sum of {first} and {second} is {first + second}");
    Console.WriteLine($"The subtraction of {first} and {second} is {first - second}");
    Console.WriteLine($"The multiplication of {first} and {second} is {first * second}");
    Console.WriteLine($"The division of {first} and {second} is {first / second}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
