// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int ReadNum(string massage)
{
    System.Console.Write($"{massage} => ");
    return Convert.ToInt32(System.Console.ReadLine());
}
void PrintArray(int[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        System.Console.Write($"{matrix[i]} ");

    }
}
int[] FillArray()
{
    int[] array = new int[8];
    for (int j = 0; j < array.Length; j++)
    {
        array[j] = ReadNum($"Введите число {j + 1}");
    }
    return array;
}

int[] matrix = FillArray();
PrintArray(matrix);
