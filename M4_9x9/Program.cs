using System;
class Program {
    static void Main(string[] args) {
        int i = 1;
        int j = 1;
        while (i <= 9) 
        {
            while (j <= 9) 
            {
                Console.Write(i + "x" + j + "=");
                if (i * j < 10)
                {
                    Console.Write(" ");
                }
                Console.Write(i * j + ",");
                j++;
            }
            Console.WriteLine("");
            i++;
            j = 1;
        }

    }
}

