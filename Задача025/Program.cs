//  Напишите цикл, который принимает на вход два числа (A и B) и возводит 
//  число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// result*= a;

System.Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите возводимую степень");
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 0; i < b; i++) result=result*a;
{
    System.Console.WriteLine($"{result}");
}

// System.Console.WriteLine("Введите число");
// ushort n = ushort.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите возводимую степень");
// byte k = byte.Parse(Console.ReadLine());
// ulong p = 1;
// for (byte i = 0; i < k; ++i) p *= n;
// Console.WriteLine($"{n} ^ {k} = {p}", n, k, p);
