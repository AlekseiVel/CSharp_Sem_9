// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Output(int m, int n)
{
    System.Console.Write(m);
    if (m >= n)
    {
        return;           
    }

    System.Console.Write(", ");
    Output(m + 1, n);
    return;

}

// void GetSum(int m, int n, int sum)
// {
//     sum = sum + n;
//     if (n <= m)
//     {
//         System.Console.Write($"Сумма элементов равна {sum}");
//         return;
//     }
//     System.Console.WriteLine();
//     GetSum(m, n -1, sum);
// }

void GetSum(int m, int n, int sum)
{
    sum = sum + m;
    if (m >= n)
    {
        System.Console.Write($"Сумма элементов равна {sum}");
        return;
    }
    System.Console.WriteLine();
    GetSum(m + 1, n, sum);
}

System.Console.WriteLine("Задайте число М?");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine("Задайте число N?");
int n = int.Parse(Console.ReadLine());
Output(m, n);
GetSum(m, n, 0);
