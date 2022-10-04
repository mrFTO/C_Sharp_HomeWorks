// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int m = InputInt("Please enter a value for M: ");
int n = InputInt("Please enter a value for N: ");
Console.WriteLine($"The sum of the elements from {m} to {n} is: {CountNaturalSum(m, n)}");

int InputInt(string input) // Метод для запроса данных у пользователя
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int CountNaturalSum(int m, int n) // Метод поиска суммы натуральных элементов
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}