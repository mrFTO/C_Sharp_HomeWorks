// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Write("Please enter the number of rows: "); // Запрашиваем у пользователя желаемое количество строк в массиве
int m = Convert.ToInt32(Console.ReadLine()); // Присваиваем введенное значение переменной m, преобразованной в числовое значение. 
Console.Write("Please enter the number of columns: "); // Запрашиваем у пользователя желаемое количество строк в массиве
int n = Convert.ToInt32(Console.ReadLine()); // Присваиваем введенное значение переменной n, преобразованной в числовое значение. 
int[,] numbers = new int[m, n]; // Создаем двухмерный массив размером m,n
FillArrayRandomNumbers(numbers); // Вызываем метод по заполнению массива случайными числами
Console.WriteLine(); // Отступ
Console.WriteLine("Initial array:");
PrintArray(numbers); // Выводим в консоль получившийся массив
ArraySort(numbers); // Вызываем метод сортировки массива
Console.WriteLine(); // Отступ
Console.WriteLine("Ordered array:");
PrintArray(numbers);// Выводим в консоль отсортированный массив

void ArraySort(int[,] array)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < numbers.GetLength(1) - 1; z++)
            {
                if (numbers[i, z] < numbers[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
                {
                    int temp = 0;
                    temp = numbers[i, z];
                    numbers[i, z] = numbers[i, z + 1];
                    numbers[i, z + 1] = temp;
                }
            }
        }
    }
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