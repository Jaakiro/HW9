// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

 void ShowNumbers(int n)
{
    if (n >= 1)
    {
        System.Console.Write(n + ", ");
        ShowNumbers(n-1);
    }
}

System.Console.Write("Input num: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNumbers(n); 


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ShowNumbers2(int n, int m)
{
   if (n == m)
     return n;
  else return 
     ShowNumbers2(n + 1, m) + n;
}

System.Console.Write("Input num M: ");
int z = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input num N: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"-> {ShowNumbers2(z, m)}");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}


int Vvod (string message)
{
    System.Console.WriteLine(message);
    int vvod = Convert.ToInt32(Console.ReadLine());
    return vvod;
}


int m = Vvod("Input M- ");
int n = Vvod("Input N- ");

int AkkermanResult = Akkerman(m, n);
Console.Write($"m = {m}, n = {n} -> A(m,n) = {AkkermanResult} ");