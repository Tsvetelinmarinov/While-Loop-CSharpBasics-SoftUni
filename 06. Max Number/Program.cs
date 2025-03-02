/**
 * 06. Max Number
 */

int maxValue = -2147483648; //Най малкото число, което може да бъде записано в 'int'

//100
//99
//80
//70
//Stop

while (true)
{
    string currentInputStream = Console.ReadLine();

    if (currentInputStream == "Stop")
    {
        break;
    }

    if (int.Parse(currentInputStream) > maxValue)
    {
        maxValue = int.Parse(currentInputStream);
    }
}

Console.WriteLine(maxValue);