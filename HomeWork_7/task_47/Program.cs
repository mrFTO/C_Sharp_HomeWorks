// Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


Console.Write("Please enter the number of rows: "); // Запрашиваем у пользователя желаемое количество строк в массиве
int m = Convert.ToInt32(Console.ReadLine()); // Присваиваем введенное значение переменной m, преобразованной в числовое значение. 
Console.Write("Please enter the number of columns: "); // Запрашиваем у пользователя желаемое количество строк в массиве
int n = Convert.ToInt32(Console.ReadLine()); // Присваиваем введенное значение переменной n, преобразованной в числовое значение. 
double[,] numbers = new double[m, n]; // Создаем двухмерный массив размером m,n
FillArrayRandomNumbers(numbers); // Вызываем метод по заполнению массива случайными вещественными числами
PrintArray(numbers); // Выводим в консоль получившийся массив

void FillArrayRandomNumbers(double[,] array) // Создаем метод для заполнения массива случайными вещественными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array) // Создаем метод для вывода в консоль получившегося массива
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