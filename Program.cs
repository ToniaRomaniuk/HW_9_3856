// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n = ReadInt("Введите положительное число: ");
int m = 1;

if (n < 1)
{
    Console.WriteLine("Ввели не положительное число!");
}

else 
{
    Console.WriteLine(NaturalNumbers(n, m));
}
Console.WriteLine();

int NaturalNumbers(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNumbers(n, m + 1)}, ");
    return m;
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int elementM = ReadInt("Введите значение начального элемента M: ");
int elementN = ReadInt("Введите значение конечного элемента N: ");
Console.WriteLine();
Console.WriteLine($"Сумма элементов от {elementM} до {elementN} = {SumNaturalElements(elementM, elementN)}");
Console.WriteLine();


int SumNaturalElements(int elementM, int elementN)
{
    if (elementM == elementN)
        return elementN;
    return elementN + SumNaturalElements(elementM, elementN - 1);
}

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите два положительных числа: m и n.");
int numM = ReadInt("Введите m: ");
int numN = ReadInt("Введите n: ");
Console.WriteLine();
Console.WriteLine($"A({numM}, {numN}) = {AkkermanFunction(numM, numN)}");

int AkkermanFunction(int numM, int numN)
{
    if (numM == 0)
        return numN + 1;
    if (numM > 0 && numN == 0)
        return AkkermanFunction(numM - 1, 1);
    else
        return AkkermanFunction(numM - 1, AkkermanFunction(numM, numN - 1));
}