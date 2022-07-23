/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите M");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());

int SumInterval(int a, int b)
{
    int result = 0;
    if (a == b + 1) return result;
    return result += a + SumInterval(a + 1, b);
}

Console.WriteLine(SumInterval(M, N));


