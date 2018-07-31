using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4
{
    class Program
    {
        static void Main(string[] args)
        {
            int space = 1;//空格數
            int row = 1;//行數
            int star = 1;//星數
            string print = "";
            if (row < 2)
            {
                for (star = 1; star <= row; star++)
                {
                    for (space = 1; space <= 5 - row; space++)
                    {
                        print += " ";
                    }
                    print += "*";
                }
            }
            Console.WriteLine(print);
            for (row = 1; row < 5; row++)
            {
                print = "";
                for (space = 2; space <= 5 - row; space++)
                {
                    print += " ";
                }
                print += "*";
                for (star = 1; star <= row; star++)
                {
                    print += "**";
                }
                Console.WriteLine(print);
            }

        }
    }
}
