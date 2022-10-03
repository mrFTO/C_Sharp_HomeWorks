// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int size = InputInt("Please enter a matrix size: "); // Запрашиваем размер матриц у пользователя
int[,] matrixOne = new int[size, size]; // Создаем двухмерный массив для первой матрицы 
int[,] matrixTwo = new int[size, size]; // Создаем двухмерный массив для второй матрицы
int[,] matrixMulti = new int[size, size]; // Создаем массив для результата умножения матриц

FillArrayRandomNumbers(matrixOne); // Заполняем первую матрицу случайными числами
FillArrayRandomNumbers(matrixTwo); // Заполняем вторую матрицу случайными числами


Console.WriteLine("First matrix: ");
PrintArray(matrixOne); // Выводим в консоль первую матрицу
Console.WriteLine();
Console.WriteLine("Second matrix: ");
PrintArray(matrixTwo); // Выводим в консоль вторую матрицу
Console.WriteLine();
Console.WriteLine("The multiplication of the resulting matrices is: ");
CountMatrix(matrixMulti); // Используем метод для умножения первой и второй матриц
PrintArray(matrixMulti); // Выводим результат умножения матриц


void CountMatrix(int[,] array) // Метод для нахождения произведения двух матриц 
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            for (int k = 0; k < size; k++)
            {
                matrixMulti[i, j] = matrixMulti[i, j] + (matrixOne[i, k] * matrixTwo[k, j]);
            }
        }
    }
}

int InputInt(string output) // Метод для запроса данных от пользователя
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void FillArrayRandomNumbers(int[,] array) // Метод для заполнения массива случайными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array) // Метод для вывода в консоль получившегося массива
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