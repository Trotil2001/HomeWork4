/*
Задача 29: Напишите программу, которая задаёт массив из 8 
элементов и выводит их на экран.

1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
*/

int[] inputArray()
{
    int[] arr=new int[8];
    for (int i =0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите " + (i+1) + "-ый элемент массива");
        arr[i]=Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void outputArray(int[] arr)
{
    Console.WriteLine();
    Console.WriteLine("[" + string.Join(", ", arr)+ "]");
}
outputArray(inputArray());
