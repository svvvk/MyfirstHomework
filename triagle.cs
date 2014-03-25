namespace IsoscelesTriangle
{
    using System;

    internal class IsoscelesTriangle
    {
        private static void Main()
        {
            char ch = '©';
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int length = 4;
            Console.Write(new string(' ', length - 1));
            Console.Write(ch);
            Console.WriteLine(new string(' ', length - 1));
            int middleSpace = 1;
            for (int i = length - 2; i > 0; i--, middleSpace += 2)
            {
                Console.Write(new string(' ', i));
                Console.Write(ch);
                Console.Write(new string(' ', middleSpace));
                Console.Write(ch);
                Console.WriteLine(new string(' ', i));
            }
            length *= 2;
            for (int i = 0; i < length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(ch);
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }
}