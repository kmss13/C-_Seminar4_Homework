//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int ReadInt(string message)
{
    Console.Write($"{message} ");
    int value = int.Parse(Console.ReadLine());
    return value;
}

int number1 = ReadInt("Введите целое положительное число ");
int number2 = ReadInt("Введите целое положительное число ");

int getDegree(int number1, int number2)
{
    int sum = number1;
    for (int i = 1; i < number2; i++)
    {
        sum = sum * number1;
    }
    Console.Write(sum);
    return sum;
}

int result = getDegree(number1, number2);