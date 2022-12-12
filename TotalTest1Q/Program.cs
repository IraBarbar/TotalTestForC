void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}


//string[] s = { "qraw", "dop", "ji85", "5754" };
string[] MadeNewArr()
{
    int size = 4;
    string[] userArray = new string[size];

    for (int i = 0; i < userArray.Length; i++)
    {
        Console.WriteLine($"Введите любые символы {size - i} раза через 'ENTER' ");
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
        Console.WriteLine("There is no element less than three characters in this array!");
    else
        Console.Write($" - в этих значениях длина, где  <= {a} символа !");
}
string[] yorArray = MadeNewArr();
Console.Write($" Ваш массив: ");
ShowArray(yorArray);

FindLessThree(yorArray, 3);
