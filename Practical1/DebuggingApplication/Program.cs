
string userResponse = Console.ReadLine();

if (Convert.ToBoolean(int.Parse(userResponse))) //this will show exceptions: "System.FormatException: 'Input string was not in a correct format.' "
{

    Console.WriteLine("The entered value is a integer");

}
