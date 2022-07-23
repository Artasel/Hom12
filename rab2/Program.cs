/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/

Console.WriteLine("Введите M");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());

int Akkerman(int number, int argument)
{
    if (number == 0) return argument + 1;
    else if(argument == 0)  return Akkerman(number - 1, 1);
    else return Akkerman(number - 1, Akkerman(number, argument - 1));

}

Console.WriteLine(Akkerman(M, N));