// Задача 14: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
void random (int[] num)
{
    for(int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(100,1000);
    }
}
void print (int[] num)
{
    for(int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите размер рандомного массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] num= new int[size];
random(num);
Console.WriteLine("Рандомный массив:");
print(num);
int count = 0;

for (int x = 0; x < num.Length; x++)
if (num[x] % 2 == 0)
count++;

Console.WriteLine($"Количество чётных чисел: {count}");
*/

// Задача 15: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
void random(int[] num)
{
    for(int i = 0; i < num.Length; i++)
        {
            num[i] = new Random().Next(1,10);
        }
}
void print(int[] num)
{
    for(int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i] + " ");
        }
    Console.WriteLine();
}

Console.WriteLine("Введите размер рандомного массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
random(num);
Console.WriteLine("Рандомный массив: ");
print(num);
int sum = 0;

for (int x = 0; x < num.Length; x+=2)
    sum = sum + num[x];

    Console.WriteLine($"Сумма элемнтов на нечётных местах: {sum}");
*/

// Задача 16: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
/*
void random(double[] num)
{
    for(int i = 0; i < num.Length; i++)
        {
            num[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void print(double[] num)
{
    for(int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i] + " ");
        }
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] num = new double[size];
random(num);
Console.WriteLine("Рандомный массив: ");
print(num);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int x = 0; x < num.Length; x++)
{
    if (num[x] > max)
        {
            max = num[x];
        }
    if (num[x] < min)
        {
            min = num[x];
        }
}

Console.WriteLine($"Разница между макс. и мин. значением: {max - min}");
*/