/* Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. 
Через строку нельзя решать само собой.*/

Console.WriteLine("Введите натуральное число: ");
int x = Convert.ToInt32(Console.ReadLine());
int amount = Convert.ToInt32(Math.Log(x, 10));
int middle = Convert.ToInt32(amount / 2);
int num_l = x % 10;

string res1 = $"Число {x} не является палиндромом";
string res2 = $"Число {x} является палиндромом";
string fin_res= "";

for (int i = 0; i <= middle; i++)
{
    if (num_l <= 4)
    {
        int a = Convert.ToInt32(Math.Pow(10, amount - i));
        int b = Convert.ToInt32(Math.Pow(10, 1));
        int c = Convert.ToInt32((Math.Pow(10, 1 + i)));
        int d = Convert.ToInt32((Math.Pow(10, i)));
        int num1_1 = x / a;
        int num1 = num1_1 % b;
        int num2_1 = x % c;
        int num2 = num2_1 / d;
        if (num1 != num2)
        {
            fin_res = res1;
            break;
        }
        fin_res = res2;
    }
    else
    {
        int a = Convert.ToInt32(Math.Pow(10, amount - 1 - i));
        int b = Convert.ToInt32(Math.Pow(10, 1));
        int c = Convert.ToInt32((Math.Pow(10, 1 + i)));
        int d = Convert.ToInt32((Math.Pow(10, i)));
        int num1_1 = x / a;
        int num1 = num1_1 % b;
        int num2_1 = x % c;
        int num2 = num2_1 / d;
        if (num1 != num2)
        {
            fin_res = res1;
            break;
        }

        fin_res = res2;

    }
}
Console.WriteLine(fin_res);