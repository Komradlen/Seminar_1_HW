//Задача 5: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
void sec_number(){
    int num = new Random().Next(100,1000);
    Console.WriteLine("Случайное число это " + num);
    int sec_num = (num - (num /100 *100) - (num %10)) /10;
    Console.WriteLine("Второе число это " + sec_num);
}

sec_number();
*/


//Задача 6: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
void thrd_number(string num){
    if (num.Length > 2){
        Console.WriteLine("Третье число " + num[2]);
    }
    else {
        Console.WriteLine("Третьего числа нет");
    }
}

Console.Write("Введи число: ");
int numbers = Convert.ToInt32(Console.ReadLine());
string number = Convert.ToString(numbers);
thrd_number(number);
*/


//Задача 7: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
void Day(int x){
    if (x == 6 || x == 7){
        Console.Write("Это выходной");
    }
    else if (x < 1 || x > 7){
    Console.Write("Введен неверный номер дня");
    }
    else{
        Console.Write("Это будни");
    }
}

Console.Write("Введите номер дня недели (1-7): ");
int num_Day = Convert.ToInt32(Console.ReadLine());
Day(num_Day);
*/