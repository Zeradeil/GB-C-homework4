// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNum(string massage)
{
    System.Console.Write($"{massage} => ");
    return Convert.ToInt32(System.Console.ReadLine());
}

int number = ReadNum("Введите число");
int sum = 0;

while (number > 0)
{
    sum = sum + (number % 10);
    number = number / 10;
}
System.Console.WriteLine(sum);
