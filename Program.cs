//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//
//
//entering block/////////////
int N1, N2, N3, Max;
//
Console.Clear();
Console.Write("Введите число #1 ");
N1 = int.Parse(Console.ReadLine()!);
//
Console.Write("Введите число #2 ");
N2 = int.Parse(Console.ReadLine()!);
//
Console.Write("Введите число #3 ");
N3 = int.Parse(Console.ReadLine()!);
// end of entering block/////////////
//
//
//exec block
//

Max = N1;
if (N1>N2)
{
    Max=N1;
}
else
{
    if (N2>N3)
    {
        Max = N2;
    }
    else
    {
        Max = N3;
    }
}

Console.WriteLine($"большее число = {Max}");
//
// end of exec block