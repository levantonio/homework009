// Задача 68: Напишите программу вычисления
//  функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа num1 и num2.

// n = 2, m = 3 -> A(num1,num2) = 9
// n = 3, m = 2 -> A(num1,num2) = 29

Console.WriteLine("Введите натуральное число1: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число2: ");
int m = Convert.ToInt32(Console.ReadLine());

int FuncAkkerman(int num1, int num2)
{
    if (num1 == 0)
        return num2 + 1;
    else if (num2 == 0)
        return FuncAkkerman(num1 - 1, 1);
    else //A(m>0 && n>0)
        return FuncAkkerman(num1 - 1, FuncAkkerman(num1, num2 - 1));
}

int result = FuncAkkerman(n, m); 
Console.WriteLine($"A({n},{m}) = {result}");
