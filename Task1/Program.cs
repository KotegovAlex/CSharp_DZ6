/* Задача 1: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int[] Promt(string message)
{
    Console.Write(message);
    int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[" + array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write(", " + array[i]);
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}

int PositiveNumberCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}


int[] numbers = Promt("Введите числа через пробел: ");
PrintArray(numbers);

Console.WriteLine($"Количество чисел > 0 равно: {PositiveNumberCount(numbers)}");