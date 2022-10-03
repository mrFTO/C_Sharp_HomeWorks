// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Запрашиваем три размерности.
int dimOne = InputInt("Please enter dimension 1: ");
int dimTwo = InputInt("Please enter dimension 2: ");
int dimThree = InputInt("Please enter dimension 3: ");
// Проверка размера массива
int countNumbers = 89;
if (dimOne * dimTwo * dimThree > countNumbers)
{
    Console.Write("The array is too large, please try again.");
    return;
}
// Наполнение массива по заданным параметрам с использованием метода 
int[,,] resultNumbers = Create3DMassive(dimOne, dimTwo, dimThree);

for (int i = 0; i < resultNumbers.GetLength(0); i++)
{
    for (int j = 0; j < resultNumbers.GetLength(1); j++)
    {
        for (int k = 0; k < resultNumbers.GetLength(2); k++)
        {
            Console.WriteLine($"[{i},{j},{k}] - {resultNumbers[i, j, k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Метод создания трехмерного массива
int[,,] Create3DMassive(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[countNumbers];
    int num
     = 10;
    for (int i = 0; i < values.Length; i++)
        values[i] = num
        ++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = values[valueIndex++];
            }
        }
    }
    return array;
}


int InputInt(string output) // Метод для запроса данных от пользователя
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}