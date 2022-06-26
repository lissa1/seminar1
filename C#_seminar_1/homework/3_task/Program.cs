//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("ввeдите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.Write("число четное");
}
else
{
    Console.Write("число нечетное");
}
