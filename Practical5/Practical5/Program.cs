int[] a = new int[5];

for(int i = 0; i < 5; i++)
{
    Console.WriteLine($"Enter {i+1} element");
    a[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("\n---Display Numbers---");
try
{
    for (int i = 0; i < 6; i++)
    {
        Console.WriteLine(i + a[i]);
    }
}
catch(Exception ex)
{
    Console.WriteLine("\n---Exception message---");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.ToString());
}
finally
{
    Console.WriteLine("\n---Finally Block---");
    Console.WriteLine("This is finally block");
}