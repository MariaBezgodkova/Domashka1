// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int a = 1; // неизменяемое число
int b = 21;  // задаем второе число
while (a <= b)
{ if (a % 2 == 0)
{
      Console.Write (a);
      Console.Write ("  ");
}
    a = a+1;
}
    