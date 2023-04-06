// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadNum(string massage)
{
    System.Console.Write($"{massage} => ");
    return Convert.ToInt32(System.Console.ReadLine());
}
int Erect(int numberA, int numberB)
{
    int num = numberA;
    for (int i = 1; i < 1 + numberB; i++)
    {
        int num = num * numberA;
    }
    return num;
}
int numberA = ReadNum("Введите число A");
int numberB = ReadNum("Введите число B");
int erected = Erect(numberA, numberB);
System.Console.WriteLine($"{numberA}, {numberB} -> ");
