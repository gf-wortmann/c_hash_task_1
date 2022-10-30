// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//
//
//entering block/////////////
int N1, N2, result;
//
Console.Clear();
Console.Write("Введите число #1");
N1 = int.Parse(Console.ReadLine()!);
//
Console.Write("Введите число #2");
N2 = int.Parse(Console.ReadLine()!);
// end of entering block/////////////
//
//
//exec block
//
if N1 > N2 {
    result = N1;
    else
    {
        result = N2;
    }
}
Console.WriteLine($"большее число = {result}");
//
// end of exec block