// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] numbers = new int[4, 4]; // Создаем прямоугольный двухмерный массив размером 4 на 4

FillArrayRandomNumbers(numbers); // Вызываем метод по заполнению массива случайными числами
PrintArray(numbers); // Выводим в консоль получившийся массив
CountArray(numbers); // Вызываем метод поиска строки с наименьшей суммой в массиве


void CountArray(int[,] array) // Создаем метод поиска строки с наименьшей суммой в массиве
{
    int minSum = Int32.MaxValue;
    int indexLine = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {

        int sum = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            sum = sum + numbers[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            indexLine++;
        }
    }
    Console.WriteLine($"The smallest sum of elements equal to {minSum} is in row number {indexLine}.");
}


void FillArrayRandomNumbers(int[,] array) // Создаем метод для заполнения массива случайными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array) // Создаем метод для вывода в консоль получившегося массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}