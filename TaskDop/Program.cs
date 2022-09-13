

int[] InputArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите " + (i + 1) + "-ый элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int[] RandomArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

int[] SumArray(int[] arr, int n)
{
    int[] sum = new int[n];
    for (int i = 0; i < n; i++)
    {
        if (i == 0)
            sum[i] = arr[i] + arr[i + 1] + arr[arr.Length - 1];
        if (i == arr.Length - 1)
            sum[i] = arr[i - 1] + arr[0] + arr[arr.Length - 1];
        if (i != 0 && i != arr.Length - 1)
            sum[i] = arr[i - 1] + arr[i] + arr[i + 1];

    }
    return sum;
}

int Sravnenie(int[] sum)
{
    int max = sum[0];
    for (int i = 0; i < sum.Length; i++)
    {
        if (sum[i] > max)
            max = sum[i];
    }
    return max;
}


Console.Write("Введите количество кустов черники: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Выбор метода заполнения ягод на кустах: ");
Console.WriteLine("1: Заполнение в ручную: ");
Console.WriteLine("2: Заполнение случайым образом: ");
int k = Convert.ToInt32(Console.ReadLine());
int[] arr=new int[n];
if (k == 1)
{
   arr = InputArray(n);
}


if (k == 2)
{
   arr = RandomArray(n);
}

int[] sum = SumArray(arr, n);
Console.WriteLine("Количество ягод на каждом кусте [" + string.Join(", ", arr) + "]");
Console.WriteLine("Сумма ягод с соседними кустами [" + string.Join(", ", sum) + "]");
Console.Write("Максимальное число ягод " + Sravnenie(sum));