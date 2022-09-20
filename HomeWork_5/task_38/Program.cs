// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Please enter the length of the array: "); // Запрашиваем длину массива у пользователя
int size = Convert.ToInt32(Console.ReadLine()); //Объявляем переменную size и присваиваем ей значение длинны массива, преобразованное в числовое значение 
double[] numbers = new double[size]; // Создаем массив заданной длинны

void FillArrayRandomNumbers(double[] numbers) // Создаем метод, заполняющий массив случайными числами
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 10);

    }
    Console.Write("Array created: ");
}

void PrintArray(double[] numbers) // Создаем метод, отображающий содержимое массива
{
    Console.Write("[ ");
    for (int j = 0; j < numbers.Length; j++)
    {
        Console.Write(numbers[j] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

void CountArray(double[] numbers) // Создаем метод для определения разницы между максимальным и минимальным элементами массива.
{
    double min = Int32.MaxValue;
    double max = Int32.MinValue;

    for (int a = 0; a < numbers.Length; a++)
    {
        if (numbers[a] > max)
        {
            max = numbers[a];
        }
        if (numbers[a] < min)
        {
            min = numbers[a];
        }
    }

    Console.WriteLine($"The maximum number in the array is {max}, The minimum number in the array is: {min}");
    Console.WriteLine($"The difference between the maximum array number and the minimum array number is: {max - min}");

}
// Вызываем созданные методы
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
CountArray(numbers);