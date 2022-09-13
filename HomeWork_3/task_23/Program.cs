// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Please, enter your number: "); //Запрашиваем число у пользователя.
int num = Convert.ToInt32(Console.ReadLine()); // Присваиваем введенное значение переменной num и преобразуем его в числовое значение.

void Koob(int[] num) // Создаем метод для расчета куба числа.
{
    int counter = 0;
    int length = num.Length;
    while (counter < length)
    {
        num[counter] = Convert.ToInt32(Math.Pow(counter, 3));
        counter++;
    }
}

void PrintArray(int[] coub) // Создаем метод для отображения массива с расчетными кубами числа.
{
    int count = coub.Length;
    int index = 1;
    while (index < count)
    {
        Console.Write(coub[index] + " ");
        index++;
    }
}

int[] arr = new int[num + 1]; //Создаем массив.
Koob(arr); //Вызываем метод расчета кубов.
PrintArray(arr); // Вызываем метод отображения массива.