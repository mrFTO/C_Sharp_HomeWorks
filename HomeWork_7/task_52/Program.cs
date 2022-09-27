// Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Please enter the number of rows: "); // Запрашиваем у пользователя желаемое количество строк в массиве
int m = Convert.ToInt32(Console.ReadLine()); // Присваиваем введенное значение переменной m, преобразованной в числовое значение. 
Console.Write("Please enter the number of columns: "); // Запрашиваем у пользователя желаемое количество строк в массиве
int n = Convert.ToInt32(Console.ReadLine()); // Присваиваем введенное значение переменной n, преобразованной в числовое значение. 
int[,] numbers = new int[m, n]; // Создаем двухмерный массив размером m,n
FillArrayRandomNumbers(numbers); // Вызываем метод по заполнению массива случайными числами
PrintArray(numbers); // Выводим в консоль получившийся массив
CountSumArray(numbers); // Выводим средние арифметические для каждого столбца массива


void FillArrayRandomNumbers(int[,] array) // Создаем метод для заполнения массива случайными вещественными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void CountSumArray(int[,] array) // Метод для определения среднего арифметического элементов каждого столбца
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            average = (average + numbers[i, j]);
        }
        average = average / m;
        Console.Write(average + "; ");
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