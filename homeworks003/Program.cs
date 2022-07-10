/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите день недели : ");
int day = Convert.ToInt32(Console.ReadLine());
if (day <= 5 ) 
{
    Console.WriteLine( day + " день недели  - будний день");
}
else
{
    Console.WriteLine( day + " день недели  - выходной день");
}
Console.WriteLine();