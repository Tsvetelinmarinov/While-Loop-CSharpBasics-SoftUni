/**
 * 05. Account Balance
 */

double totalDeposit = 0.0; //Общо всички вноски

//5.51
//69.42
//100
//NoMoreMoney

while (true)
{
    string deposit = Console.ReadLine();

    if (deposit == "NoMoreMoney")
    {
        Console.WriteLine($"Total: {totalDeposit:F2}");
        break;
    }

    if (double.Parse(deposit) < 0)
    {
        Console.WriteLine("Invalid operation!");
        Console.WriteLine($"Total: {totalDeposit:F2}");
        break;
    }

    totalDeposit += double.Parse(deposit);
    Console.WriteLine("Increase: {0:F2}", double.Parse(deposit));
}