/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

int GetNumber (string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()??"");
    return result;
}
int SummDigitNumber (int digit)
{
    int summDigit = 0;
    if (digit > 0)
    {
        while (digit / 10 > 0)
        {   while (digit > 10)
            {
                summDigit = summDigit + digit % 10;
                digit = digit / 10;
            }
           summDigit = summDigit + digit % 10;
        } 
    }

    digit = digit * (-1);

    while (digit / 10 > 0)
    {   while (digit > 10)
        {
            summDigit = summDigit + digit % 10;
            digit = digit / 10;
        }
        summDigit = summDigit + digit % 10;
    } 
    return summDigit;
}
int digit = GetNumber("Введите число А: ");
int result = SummDigitNumber(digit);
Console.WriteLine($"\nСумма цифр числа {digit} = {result}");