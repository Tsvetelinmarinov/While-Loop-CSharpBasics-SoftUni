/**
 * 03. Sum Numbers
 */

//Напишете програма, която чете цяло число от конзолата и на всеки следващ ред цели числа,
//докато тяхната сума стане по-голяма или равна на първоначалното число.
//След приключване да се отпечата сумата на въведените числа.

//20

int targetValue = int.Parse(Console.ReadLine());

int sum = 0;

while (true)
{
    int input = int.Parse(Console.ReadLine());

    sum += input;

    if (sum >= targetValue) { break; }
}

Console.WriteLine(sum);