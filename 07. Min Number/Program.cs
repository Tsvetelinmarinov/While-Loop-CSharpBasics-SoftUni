/**
 * 07. Min Number
 */

//Най-голямото число, което може да се запише в 'int'
int minValue = 2147483647;

//-10
//20
//- 30
//Stop

while (true)
{
    string input = Console.ReadLine();

    if (input == "Stop") 
    {
        Console.WriteLine(minValue);
        break; 
    }

    if (int.Parse(input) < minValue) { minValue = int.Parse(input); }
}