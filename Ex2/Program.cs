/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введите число: ");
int Digit = Convert.ToInt32(Console.ReadLine());

if (Digit < 100)
{
    Console.WriteLine("Третьей цифры нет!");
}
else
{
    string str = Digit.ToString();
    Console.WriteLine(str[2]);
}