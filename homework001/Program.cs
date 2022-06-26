/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
*/
Console.WriteLine("Введите трех значное число : ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number / 10 ;
Console.WriteLine( result % 10  );