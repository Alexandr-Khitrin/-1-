string[] array = AskArray();

void outupArray(string[] array)
{
    string[] input = new string[array.Length];
     for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            input[i] = array[i]; ;
            Console.Write($"{input[i]}, ");
        }
    }
    Console.WriteLine();
}

void PrintArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]}, ");
    }
    Console.WriteLine();
}

string[] AskArray()
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}

outupArray(array);
Console.WriteLine();
PrintArray(array);