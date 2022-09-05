// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵) 2, 4 -> 16
/*
int Degree(int num_A, int num_B){
  int res = 1;
  for(int i=1; i <= num_B; i++){
    res = res * num_A;
  }
    return res;
}

Console.Write("Введите первое число: ");
int num_A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num_B = Convert.ToInt32(Console.ReadLine());

int res_deg = Degree(num_A, num_B);
Console.WriteLine("Ответ: " + res_deg);
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11 82 -> 10 9012 -> 12
/*
int Sum(int num){
    int x = Convert.ToString(num).Length;
    int y = 0;
    int z = 0;
    for (int i = 0; i < x; i++){
      y = num - num % 10;
      z = z + (num - y);
      num = num / 10;
    }
   return z;
  }

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int sum_num = Sum(num);
Console.WriteLine("Сумма сумма всех цифр: " + sum_num);
*/

// Выполнил задачу из конца семинара, лишь потом заметил еёё отличие от того что на сайте. К сожелению, выполнить второй выриант не смог.
//  Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
void Print(int[] coll){
  int count = coll.Length;
  int i = 0;
  Console.Write("[");
  while(i < count){
    Console.Write(coll[i]);
    i++;
    if (i < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 

int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
}

Print(array);
*/