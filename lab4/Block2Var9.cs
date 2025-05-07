using System;
using System.Text;

public static class StringTask
{
    public static void Run()
    {
        Console.Write("Введіть рядок: ");
        string input = Console.ReadLine()!;

        string result = TransformString(input);

        Console.WriteLine("Перетворений рядок: " + result);
    }

    private static string TransformString(string input)
    {
        StringBuilder letters = new StringBuilder();
        StringBuilder digits = new StringBuilder();

        foreach (char ch in input)
        {
            if (char.IsLetter(ch))
                letters.Append(ch);
            else if (char.IsDigit(ch))
                digits.Insert(0, ch); 
        }

        return letters.ToString() + digits.ToString();
    }
}
