// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0

Console.Write("Please enter the length of the array: "); // Запрашиваем длину массива у пользователя
int size = Convert.ToInt32(Console.ReadLine()); //Объявляем переменную size и присваиваем ей значение длинны массива, преобразованное в числовое значение 
int[] numbers = new int[size]; // Создаем массив заданной длинны

void FillArrayRandomNumbers(int[] numbers) // Создаем метод, заполняющий массив случайными числами
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 10);

    }
    Console.Write("Array created: ");
}
void PrintArray(int[] numbers) // Создаем метод, отображающий содержимое массива
{
    Console.Write("[ ");
    for (int j = 0; j < numbers.Length; j++)
    {
        Console.Write(numbers[j] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

void CountArray(int[] numbers) // Создаем метод для подсчета суммы нечетных элементов массива
{
    int count = 0;

    for (int a = 1; a < numbers.Length; a += 2)
        count = count + numbers[a];

    Console.WriteLine($"The sum of the array elements in odd positions is: {count}.");
}
// Вызываем созданные методы
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
CountArray(numbers);