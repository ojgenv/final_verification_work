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
    int x = 0;
    int z = arr.Length;
    string[] NewArray = new string[z];
    for (int i = 0; i < z; i++)
    {
        if (arr[i].Length <= length)
        {
            NewArray[x] = arr[i];
            x++;
        }        
    }
    Array.Resize(ref NewArray, x);
    return NewArray;
}