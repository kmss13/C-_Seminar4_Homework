// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите целое положительное число ");
int inputedNum = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int getSum(int num)
{

    while (inputedNum > 0)
    {
        int d = inputedNum % 10;//отсекаем последнюю цифру и записываем в d
        inputedNum = inputedNum / 10;// пересохраняем результат деления без остатка
        sum += d;         
    }
    Console.Write($"Сумма цифр числа = {sum} ");
    return sum;
}

int result = getSum(inputedNum);