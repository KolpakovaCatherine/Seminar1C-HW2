/*Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("Введите трехзначное число: ");
int Digit = Convert.ToInt32(Console.ReadLine());

while (Digit < 100 || Digit > 999)
{
    Console.WriteLine("Это не трехзначное число. Введите трехзначное число: ");
    Digit = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(Digit%100/10);

