// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.Write("Введите число: " );
 int numberM = Convert.ToInt32(Console.ReadLine());
 System.Console.Write("Введите число: " );
 int numberN = Convert.ToInt32(Console.ReadLine());
RoadTonSum( numberM , numberN);

void RoadTonSum(int numberM ,int numberN)
{
    Console.Write(SumMiN(numberM - 1, numberN));
}
int SumMiN(int numberM,int numberN)
{
    int result = numberM;
    {
        if(numberM == numberN)
        return 0;
        else
        {
            numberM++;
            result= numberM + SumMiN(numberM,numberN);
            return result;
        }
    }
}





