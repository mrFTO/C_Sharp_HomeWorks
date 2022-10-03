// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 

//Создаем массив размером 4 на 4 
int size = 4;
int[,] numbers = new int[size, size];

int num = 1;
int i = 0;
int j = 0;
// Метод спирального заполнения массива
void SpiralArray(int[,] array) 
{

    while (num <= size * size)
    {
        numbers[i, j] = num;
        if (i <= j + 1 && i + j < size - 1)
            ++j;
        else if (i < j && i + j >= size - 1)
            ++i;
        else if (i >= j && i + j > size - 1)
            --j;
        else
            --i;
        ++num;
    }
}
// Вызов методов
SpiralArray(numbers);
PrintArray(numbers);

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
