/*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
["Hello", "2", "world", ":-)"] → ["2", ":-)"]
["1234", "1567", "-2", "computer science"] → ["-2"]
["Russia", "Denmark", "Kazan"] → []
*/

Console.Clear();
string[] array = {"1234", "157", "-4", "computer science"};

int Count(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            count++;
    }
    return count;
}

string[] CreateNewArray(string[] array, int count)
{
    string[] NewArray = new string[count];
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            NewArray[k] = array[i];
            k++;
        }
    }
    return NewArray;
}

void PrintArray(string[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
            System.Console.Write($"\"{array[i]}\"");
        else
            System.Console.Write($"\"{array[i]}\", ");
    }
    System.Console.Write("]");
}

Console.Write("Начальный массив: ");
PrintArray(array);
Console.WriteLine();
string[] array2 = CreateNewArray(array, Count(array));
Console.Write("Отсортированный массив: ");
PrintArray(array2);
