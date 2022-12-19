// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


int[] GetArrayUser(int size)
{
    int[] res = new int[size];
    Console.Write($"Создаем массив из {size} элементов");
    Console.WriteLine();
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите число массива: ");
        int A = int.Parse(Console.ReadLine()!);
        res[i] = A;
    }
    return res;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int GetPositivNumbers(int[] arr)
{
    int count = 0;

    foreach (int el in arr)
    {
        if (el > 0) count += 1;
    }
    return count;
}
Console.Write("Введите длину массива, который вы хотите задать: ");
int num = int.Parse(Console.ReadLine()!);
int[] array = GetArrayUser(num);
PrintArray(array);
Console.WriteLine();

int PositiveCount = GetPositivNumbers (array);
Console.Write($"Количество чисел больше нуля = {PositiveCount}");
