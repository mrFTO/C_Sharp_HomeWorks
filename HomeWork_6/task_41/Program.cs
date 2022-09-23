// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Please enter numbers separated by commas: "); // Запрашиваем у пользователя ввод чисел через запятую.
int[] numbers = StringToNum(Console.ReadLine()); // Создаем массив и помещаем в него введенные пользователем числа, преобразованные из строки в метод
PrintArray(numbers); // Вызов метода по отображению полученного массива
CountArray(numbers); // Вызов метода по определению чисел больше 0

void CountArray(int[] array) // Метод по определению чисел больше 0
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            sum++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"The number of entered numbers greater than zero is equal to: {sum}");
}


int[] StringToNum(string input) // Метод по преобразованию введенных чисел в массив из строки
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int[count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input[i] != ',')
        {
            if (i != input.Length - 1)
            {
                temp += input[i].ToString();
                i++;
            }
            else
            {
                temp += input[i].ToString();
                break;
            }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}


void PrintArray(int[] array) // Метод по отображению массива
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}