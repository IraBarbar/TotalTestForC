void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

string[] s = { "qraw", "dop2", "ji85", "5754" };
void FindLessThree(string[] text, int a)
{
    bool t = false;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i].Length <= 3)
        {
            Console.Write(text[i] + " ");
            t = true;
        } 
    }
if (t == false)
Console.WriteLine("There is no element less than three characters in this array!");
}
ShowArray(s);
FindLessThree(s, 3);