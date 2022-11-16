/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введите число: ");
int Digit = Convert.ToInt32(Console.ReadLine());

int GetSecondDigit(int k)
{
    while (k >= 1000) k /= 10;
    int d = k % 10;
    return d;
}

if (Digit < 100)
{
    Console.WriteLine("Третьей цифры нет!");
}
else
{
    //string str = Digit.ToString(); решение через превращение в строку
    //Console.WriteLine(str[2]);
    Console.WriteLine(GetSecondDigit(Digit));
}