/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int GetNumberA(string messege)
{
    Console.WriteLine(messege);
    int numA = int.Parse(Console.ReadLine()??"");
    return numA;
}

int GetNumberB(string messege)
{
    Console.WriteLine(messege);
    int numB = int.Parse(Console.ReadLine()??"");
    return numB;
    
}
int GetPow(int a, int b)
{
    double result = Math.Pow(a, b);
    return Convert.ToInt32(result);
}
int numA = GetNumberA("Введите число А: ");
int numB = GetNumberB("Введдите число B которое будет степенью: ");
int pow = GetPow(numA, numB);
Console.WriteLine($"\n{numA} в степени {numB} = {pow}");