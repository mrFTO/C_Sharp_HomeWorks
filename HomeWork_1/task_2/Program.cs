//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Please, enter your first number: "); //Запрашиваем первое число у пользователя
int num1 = Convert.ToInt32(Console.ReadLine()); // Присваиваем введенное значение переменной num1 и преобразуем его в числовое значение.
Console.WriteLine("Please, enter your second number: ");//Запрашиваем второе число у пользователя.
int num2 = Convert.ToInt32(Console.ReadLine()); //Присваиваем введенное значение переменной num2 и преобразуем его в числовое значение.
//  Если значение переменной певого числа больше, чем значение переменной второго числа, то выводим в консоль результат, если сравнение верно. 
if (num1 > num2)
{
    Console.WriteLine("The first number " + num1 + " is greater than the second number " + num2);
}
//Иначе, если значение переменной первого числа меньше, чем значение переменной второго числа, то выводим в консоль результат, если сравнение верно
else if (num1 < num2)
{
    Console.WriteLine("The first number " + num1 + " is less than the second number " + num2);
}
// Иначе, выводим в консоль сообщение, что числа равны.
else
{
    Console.WriteLine("Both numbers are equal. " + num1 + " = " + num2);
}


