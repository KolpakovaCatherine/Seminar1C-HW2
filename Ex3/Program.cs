/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int Digit = Convert.ToInt32(Console.ReadLine());

if (Digit == 1 || Digit == 2 || Digit == 3 || Digit == 4 || Digit == 5)
{
    Console.WriteLine ("Этот день не является выходным");
}
else if (Digit == 6 || Digit == 7)
{
    Console.WriteLine ("Этот день является выходным");
}
else
{
    Console.WriteLine ("Такого дня недели нет");
}