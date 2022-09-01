// Задача 8: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет 23432 -> да 12821 -> да
/*
void Palindrome(string x){
  if (x[0]==x[4] || x[1]==x[3]){
    Console.WriteLine($"Число {x} является палиндром.");
  }
  else Console.WriteLine($"Число {x} не является палиндром.");
}

Console.Write("Введите пятизначное число: ");
string? num = Console.ReadLine();

if (num!.Length == 5){
  Palindrome(num);
}
else {
     Console.WriteLine($"Число {num} не пятизначное.");
}
*/

// Задача 9: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84 A (7,-5, 0); B (1,-1,9) -> 11.53
/*
int position(string pos, string num)
{
    Console.Write($"Введите координату {pos} {num} точки: ");
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = position("X", "первой");
int y1 = position("Y", "первой");
int z1 = position("Z", "первой");
int x2 = position("X", "второй");
int y2 = position("Y", "второй");
int z2 = position("Z", "второй");

double Decision(double x1, double x2, double y1, double y2, double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
}
double lenght =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );
Console.WriteLine($"Расстояние между точками: {lenght}");
*/


//Задача 10: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27 5 -> 1, 8, 27, 64, 125*/
/*
void Cube(int x){
    int count = 1;
    while(count<=x){
            Console.Write(count*count*count + ", ");
            count++;
    }
}

Console.Write("Введите положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0){
    Cube(num);
}
else{
    Console.Write("Введено неверное число");
}
*/