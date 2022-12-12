void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

string[] MadeNewArr()
{
    int size = 4;
    string[] userArray = new string[size];

    for (int i = 0; i < userArray.Length; i++)
    {
        Console.WriteLine($"Input any characters {size - i} times by pressing 'ENTER' ");
        userArray[i] = Console.ReadLine();
    }
    return userArray;
}
void FindLessThree(string[] text, int a)
{
    bool t = false;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i].Length <= a)
        {
            Console.Write(text[i] + " ");
            t = true;
        }
    }
    if (t == false)
        Console.WriteLine($"There is no element less than {a} characters in this array!");
    else
        Console.Write($" - in these values the length <= {a} characters !");
}
string[] yourArray = MadeNewArr();
Console.Write($"Your array:  ");
ShowArray(yourArray);

FindLessThree(yourArray, 3);
