// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Please enter the raw position number: "); // Запрашиваем у пользователя  количество строк в массиве
int m = Convert.ToInt32(Console.ReadLine()); // Присваиваем введенное значение переменной m, преобразованной в числовое значение. 
Console.Write("Please enter the column position number: "); // Запрашиваем у пользователя желаемое количество строк в массиве
int n = Convert.ToInt32(Console.ReadLine()); // Присваиваем введенное значение переменной n, преобразованной в числовое значение. 
int[,] numbers = new int[5, 5]; // Создаем двухмерный массив размером 5 на 5 чисел
FillArrayRandomNumbers(numbers); // Вызываем метод по заполнению массива случайными числами
PrintArray(numbers); // Выводим в консоль получившийся массив
CountPosition(numbers); // Вызываем метод по определению значения числа расположенного по заданному адресу в массиве

// Метод по определению значения числа расположенного по заданному адресу в массиве
void CountPosition(int[,] numbers)
{
    if (m > numbers.GetLength(0) || n > numbers.GetLength(1))
    {
        Console.WriteLine("No such value.");
    }
    else
    {
        Console.WriteLine($"The value of the element located in the {m} row of the {n} column is: {numbers[m - 1, n - 1]}");
    }
}

void FillArrayRandomNumbers(int[,] array) // Создаем метод для заполнения массива случайными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) / 10;
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