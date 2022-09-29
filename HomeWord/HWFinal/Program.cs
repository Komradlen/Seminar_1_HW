//Просто для дальнейшего удобства
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");

if (n>m)
    for (int i = m; i <= n; i++)
        Console.Write($"{i} ");
else
    for (int i = n; i <= m; i++)
        Console.Write($"{i} ");
*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");

int Sum(int m, int n)
{
    if (m == n)
        return n;
    return n + Sum(m, n - 1);
}
Console.WriteLine($"Сумма: {Sum(m, n)}");
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/*Скажу честно, не мог долго понять причину по которой не совпадает ответ с примером с сайта: m = 2, n = 3 -> A(m,n) = 29
Как я понял, там закралась ошибка ибо такой результат возможен только при m = 3, n = 2. Надеюсь, что это так, а не я что-то упустил.*/
/*
int m = InputInt("Введите положительное M: ");
int n = InputInt("Введите положительное N: ");
Console.WriteLine($"A({m}, {n}) = {Funct_Akker(m, n)}");

int Funct_Akker(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Funct_Akker(m - 1, 1);
    else
        return Funct_Akker(m - 1, Funct_Akker(m, n - 1));
}
*/