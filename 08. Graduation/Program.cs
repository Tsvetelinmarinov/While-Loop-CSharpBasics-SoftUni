/**
 * 08. Graduation
 */

string studentName = Console.ReadLine();
int classCounter = 0;
int lowGradesCounter = 0;
double average = 0.0;
int gradesCounter = 0;

//При успешно завършване на 12-ти клас да се отпечата : 
//"{име на ученика} graduated. Average grade: {средната оценка от цялото обучение}"

//Gosho
//5
//5.5
//6
//5.43
//5.5
//6
//5.55
//5
//6
//6
//5.43
//5

while (true)
{
    if (classCounter == 12)
    {
        Console.WriteLine($"{studentName} graduated. Average grade: {average / gradesCounter:F2}");
        break;
    }

    double grade = double.Parse(Console.ReadLine());
    average += grade;
    gradesCounter++;
    
    if (grade >= 4)
    {
        classCounter++;
    }
    else
    {
        lowGradesCounter++;
    }

    if (lowGradesCounter == 2)
    {
        Console.WriteLine($"{studentName} has been excluded at {++classCounter} grade");
        Environment.Exit(0);
    }
}

//В случай, че ученикът е изключен от училище, да се отпечата:
//"{име на ученика} has been excluded at {класа, в който е бил изключен} grade"