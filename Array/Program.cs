
string[] CreateArray()
{
    string[] newArray = new string[] {"fkdlf", "644hgf2", "52f", "gfy", "54rwj", "dgt", "hyrtej"};
    return newArray;
}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

string[] Three (string[] array)
{
    for(int i = 0; i < array.Length; i++)
        if(array[i].Length <= 3)
            Console.WriteLine(array[i] + " ");
    return array;
}

string[] array = CreateArray();
ShowArray(array);

string[] array2 = Three(array);
