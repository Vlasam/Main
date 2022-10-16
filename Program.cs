//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double FindDistans(double x, double y, double e, double a, double b, double c)
{
    double num = 0;
    num = (x - a) * (x - a) + (y - b) * (y - b) + (e - c) * (e - c);
    num = Math.Sqrt(num);
    return num;
}

Console.Write("Введите координату x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату e: ");
double e = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату c: ");
double c = Convert.ToDouble(Console.ReadLine());

double findDistans = FindDistans(x, y, e, a, b, c);
Console.WriteLine(findDistans);
*/

//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void ShowNumbers(int num)
{
    int count = 1;
    while(count <= num)
    {
        double n = Math.Pow(count, 3);
        Console.Write(n + " ");
        count++;
    }
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowNumbers(number);
*/

 //Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
int A = num.Length;

if (A == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"{num} - Является");
    }
    else
    {
        Console.WriteLine($"{num} - Не является");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {num} - не является пятизначным");
}
*/

