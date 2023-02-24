//  Напишите программу, которая принимает 
//  на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


System.Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int result = 0;
for (int i = 0; i < x; i++)
{
    result += x % 10;
    x = x / 10;

}
Console.WriteLine(result);
