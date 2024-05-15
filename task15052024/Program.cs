using System;

class Program
{
    static void Main(string[] args)
    {
        int number1 = 10;
        int number2 = 35 ;
        int counter = 0;
        for (int i = number1; i <= number2; i++)
        {
            if (i % 2 != 0)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}
