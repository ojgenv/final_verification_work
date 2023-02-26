/* Написать программу которая из имеющегося массива строк формирует массив из строк,
длинна которых меньше либо равна 3-м символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами. */

Console.WriteLine("введите элементы массива строкчерез пробел");
string[] Arr = GetArray();
PrintArray(Arr);
PrintArray(GetNewArray(Arr));

string[] GetArray()
{
    string? text = Console.ReadLine();
    return text.Split(' ');
}

void PrintArray(string[] Arr)
{
    foreach (string item in Arr)
    {
        Console.Write(item + " ");        
    }
    Console.WriteLine();
} 

string[] GetNewArray(string[] arr)
{
    int length = 3;
    int counter = 0;
    int arrayLength = arr.Length;
    string[] NewArray = new string[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        if (arr[i].Length <= length)
        {
            NewArray[counter] = arr[i];
            counter++;
        }        
    }
    Array.Resize(ref NewArray, counter);
    return NewArray;
}