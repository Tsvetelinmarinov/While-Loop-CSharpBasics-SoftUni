/**
 * 02. Password
 */

string username = Console.ReadLine();
string password = Console.ReadLine();

//"Welcome {username}!".

while (true)
{
    string guess = Console.ReadLine();

    if (guess == password)
    {
        Console.WriteLine($"Welcome {username}!");
        Environment.Exit(0);
    }
}