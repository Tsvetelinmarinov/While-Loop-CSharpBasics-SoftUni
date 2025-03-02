/**
 * 04. Sequence 2k + 1
 */

//Напишете програма, която чете число n, въведено от потребителя, и отпечатва всички числа ≤ n от редицата: 1, 3, 7, 15, 31, ….
//Всяко следващо число се изчислява като умножим предишното с 2 и добавим 1.

int targetNumber = int.Parse(Console.ReadLine());
int startNumber = 1;

while (startNumber <= targetNumber)
{
    Console.WriteLine(startNumber);
    startNumber += startNumber + 1;
}