# Main
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*Console.WriteLine("Введите трёхзначное число ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num / 10 % 10;
Console.WriteLine(result);*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.WriteLine("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());
string numText = Convert.ToString(num);
if (numText.Length > 2)
{ 
    Console.WriteLine("Третья цифра " + numText[2]);
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число дня недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());

void DayOfTheWeek (int dayNum) 
{
  if (dayNum == 6 || dayNum == 7)
  {
  Console.WriteLine("Выходной день");
  }
  else if (dayNum < 1 || dayNum > 7) {
    Console.WriteLine("Ошибка, ввели неправильное чило дня недели");
  }
  else Console.WriteLine("Рабочий день");
}

DayOfTheWeek(dayNum);
