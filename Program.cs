//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N..
//
//
//entering block/////////////а
int intN1, intResult=2; 
//
Console.Clear();
Console.Write("Введите число ");
intN1 = int.Parse(Console.ReadLine()!);
//
// end of entering block/////////////
//
//
//exec block
//
if (intN1 > 2)
{  
while (intResult <= intN1)
{
    Console.WriteLine($"{intResult}");
    intResult = intResult + 2;
}
} else
{
    Console.WriteLine($"слишком малое число...");
}
//
// end of exec block