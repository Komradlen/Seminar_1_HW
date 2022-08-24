//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*i
nt a, b;

Console.Write("Введите первое число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());

if (a < b){
    Console.WriteLine("Наибольшее число: " + b);
}
else{
    Console.WriteLine("Наибольшее число: " + a);
}
*/


//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
int a, b, c, x;

Console.Write("Введите первое число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
c = Convert.ToInt32(Console.ReadLine());

if (a < b){
    x = b;
}
else{
    x = a;
}
if (c < x){
    Console.WriteLine("Наибольшее число: " + x);
}
else{
    Console.WriteLine("Наибольшее число: " + c);
}
*/


//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
int a;
double b;

Console.Write("Введите число: ");
a = Convert.ToInt32(Console.ReadLine());
b = a % 2;

if (b == 0){
    Console.WriteLine("Да");
}
else{
    Console.WriteLine("Нет");
}
*/


//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
int a, n;

Console.Write("Введите число: ");
a = Convert.ToInt32(Console.ReadLine());
n = 2;

while (n <= a ){
    Console.Write(n + " ");
    n = n + 2;
}
*/