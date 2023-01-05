
string[] Task(string[] array)
{
    int length = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length < 4)
        {
            length++;
        }
    }

    string[] newArray = new string[length];
    length = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length < 4)
        {
            newArray[length] = array[i];
            length++;
        }
    }
    return newArray;
}


void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


string[] GetArray(int length)
{
    string[] array = new string[length];

    for (int i = 0; i < length; i++)
    {
        Console.Write("Введите " + i + " элемент: ");
        array[i] = Console.ReadLine();
        Console.WriteLine();
    }
    return array;
}


Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] array = GetArray(length);
string[] newArray = Task(array);
PrintArray(newArray);