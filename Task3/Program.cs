/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]

ввод элеменетов через консоль (через запятую. использовать метод string.Split())
*/
int [] GetArray(string message)
{
    Console.WriteLine(message);
    string str = Console.ReadLine()??"";
    string [] strArray = str.Split(',');
    int [] numArray = new int[strArray.Length];
    for (int i = 0; i < strArray.Length; i++)
    {
        numArray[i] = int.Parse(strArray[i]);    
    }
    return numArray;
}

int [] resultArray = GetArray("Введите числа через запятую:");
Console.WriteLine("Итоговый массив:");
Console.Write("[");

void PrintArray(int [] array)
{
    for (int i = 0; i < resultArray.Length; i++)
    { 
        if (i < resultArray.Length - 1)
            Console.Write($"{resultArray[i]}, ");
        else
            Console.Write($"{resultArray[i]}");
    }
}
PrintArray(resultArray);
Console.Write("]");