using System;

class Program
{
    static void Main()
    {
        string text = "Code Academy";
        int[] charcounter = new int[256];
        foreach (char c in text)
        {
            charcounter [(int)c]++; 
        }
        for (int i = 0; i < charcounter.Length; i++)
        {
            if (charcounter[i] > 0)
            {
                Console.WriteLine($"{(char)i} - {charcounter[i]}");
            }
        }
    }
}
