/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int expont(int n, int s)
{
    int res = 1;
    for (int i = 0; i < s; i++)
    {
        res = res * n;
    }
    return res;
}

Console.Write("Введите число А: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень B: ");
int s = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"{n} в степени {s} = {expont(n, s)}.");