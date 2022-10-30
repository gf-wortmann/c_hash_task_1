//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
////
//entering block/////////////
int intN1; 
string strResult = "Нет";
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
if (intN1%2==0)
{
    strResult = "Да";
}

Console.WriteLine($"{strResult}");
//
// end of exec block