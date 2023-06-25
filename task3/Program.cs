//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int[] GenerateArray(int len, int min, int max)
// {
//     int[] list = new int[len];//Создаём массив
//     Random rnd = new Random();//генератор случайных чисел
//     for (int i = 0; i < list.Length; i++)//цикл для заполнения массива рандомным значением
//     {
//         list[i] = rnd.Next(min, max); //присваиваем значению рандомное число в диапазон от 0 до 1000 и подставляем это значение в массив по местоположению индекса

//     }
//     return list;
// }

// void PrintArray(int[] Array)
// {
//     for (int i = 0; i < Array.Length; i++)
//     {
//         Console.Write(Array[i] + "");
//     }
// }

// int[] arr = GenerateArray(8, 0, 10);

// PrintArray(arr);

Console.Write("Введите количество элементов массива ");
int inputedNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный порог случайных значений ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный порог случайных значений ");
int max = Convert.ToInt32(Console.ReadLine());

int[] GenerateArray(int len, int min, int max)
{
    int[] list = new int[len];//Создаём массив
    Random rnd = new Random();//генератор случайных чисел
    for (int i = 0; i < list.Length; i++)//цикл для заполнения массива рандомным значением
    {
        list[i] = rnd.Next(min, max); //присваиваем значению рандомное число в диапазон от 0 до 1000 и подставляем это значение в массив по местоположению индекса

    }
    return list;
}

void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i] + " ");
    }
}

int[] arr = GenerateArray(inputedNum, min, max);

PrintArray(arr);




