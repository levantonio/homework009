// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число1: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число2: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumNaturalNumber(int num1, int num2)
{
    int result = 0;
    if (num1 == 0 || num2 ==0) return 0;
    if (num1 == num2) return result + num2;
    result =  num1 + SumNaturalNumber(num1 + 1, num2);
    return result;
}

if(m <= n)
{
    int result = SumNaturalNumber(m, n);
    Console.WriteLine($"Сумма чисел в промежутке от {m} до {n} = {result}");
}

else Console.WriteLine($"число {m} больше числа {n}. Введите правильно");