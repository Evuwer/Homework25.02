/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.WriteLine("Введите натуральное число: ");
int x = Convert.ToInt32(Console.ReadLine());
string res = $"{x} -> ";
for (int i = 1; i <= x; i++)
{
    int tmp = i * i * i;
    res += $"{tmp}, ";
}
Console.WriteLine(res);