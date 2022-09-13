/*
Задача 27: Напишите программу, которая принимает на вход 
число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

*/

void Sum(int number)
{
    int count = 0, LastDigit = 0, sum = 0;

    if (number < 0)
        number *= (-1);
//Находим последнюю цифру числа и суммируем.
    while (number > 0)
    {
        LastDigit = number % 10;//Последня цифра числа
        sum += LastDigit;
        number /= 10;
        count++;
    }
    Console.WriteLine($"Сумма чисел = {sum}");
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Sum(n);