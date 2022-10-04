// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. 

int n = InputNumbers("Введите N: "); // Запрашиваем значение N у пользователя
int count = 2;
PrintNumber(n, count); // Вызов метода вывода чисел
Console.Write(1); // По условию задачи, промежуток от N до 1, то в конце списка чисел будет 1.

void PrintNumber(int n, int count) // Метод вывода списка четных чисел в промежутке от N до 1 с помощью рекурсии.
{
    if (count > n) return;
    PrintNumber(n, count + 2);
    Console.Write(count + ", ");
}

int InputNumbers(string input) // Метод для запроса данных у пользователя
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}


