/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

 */

Console.Clear();

string[] array = new string[7] { "Hello", "2", "world", "1563", "321", "-2", "Russia" };
Console.WriteLine("Массив строк: ");

if (IsElementExistInArray(CountElemWithThreeOrLessCharsInArray(array)))
{
    PrintArray(array);
    Console.WriteLine("\n");
    string[] newArray = CreateAndFillArrayWithThreeOrLessCharElem(CountElemWithThreeOrLessCharsInArray(array), array);
    Console.WriteLine("Новый массив из строк, длина которых меньше, либо равна 3 символам: ");
    PrintArray(newArray);
    Console.WriteLine("\n");
    PrintArray(array);
    Console.Write("  →  ");
    PrintArray(newArray);
    Console.WriteLine("\n"); ;
}
else
{
    Console.WriteLine("В массиве нет ниодного элемента, удовлетворяющего условие задачи: ");
    PrintArray(array);
    Console.Write("  →  ");
    Console.WriteLine("[]\n ");
}





int CountElemWithThreeOrLessCharsInArray(string[] arr, int count = 0)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) count++;
    }
    return count;
}


string[] CreateAndFillArrayWithThreeOrLessCharElem(int size, string[] arr)
{
    string[] ar = new string[size];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            ar[j] = arr[i];
            j++;
        }
    }
    return ar;
}


void PrintArray(string[] arr, char sep = '"')
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{sep}{arr[i]}{sep}," + " ");
    }
    Console.Write($"{sep}{arr[arr.Length - 1]}{sep}]");
}


bool IsElementExistInArray(int size)
{
    return size > 0;
}

