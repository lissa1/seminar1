//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("ввeдите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("ввeдите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("ввeдите третье число ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (max > number2)
{
    if (max > number3)
    {
        max = number1;
    }
    else
    {
        max = number2;
    }

}
else
{
    if (number2 > number3)
    {
        max = number2;
    }
    else 
    {
        max = number3;
    }
}
Console.WriteLine("max = " + max);
