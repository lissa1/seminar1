//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("ввeдите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("ввeдите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine("max = " + number1);
    Console.WriteLine("min = " + number2);
}
else if (number1 == number2)
{
  Console.WriteLine($"числа равны {number1} = {number2}");
}
else
{
    Console.WriteLine("max = " + number2);
    Console.WriteLine("min = " + number1);
}