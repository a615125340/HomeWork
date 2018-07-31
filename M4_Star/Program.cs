using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    int space = 1;//空格數
        //    int row = 1;//行數
        //    int star = 1;//星數
        //    string print = "";
        //    if (row < 2)
        //    {
        //        for (star = 1; star <= row; star++)
        //        {
        //            for (space = 1; space <= 5 - row; space++)
        //            {
        //                print += " ";
        //            }
        //            print += "*";
        //        }
        //    }
        //    Console.WriteLine(print);
        //    for (row = 1; row < 5; row++)
        //    {
        //        print = "";
        //        for (space = 2; space <= 5 - row; space++)
        //        {
        //            print += " ";
        //        }
        //        print += "*";
        //        for (star = 1; star <= row; star++)
        //        {
        //            print += "**";
        //        }
        //        Console.WriteLine(print);
        //    }

        //}
        static void Main()
        {
            Console.WriteLine("");
            Console.WriteLine("開始");

            int num_levels = 5;

            int num_blank;
            int num_star;
            int num_new_line = 1;

            num_blank = num_levels - 1;
            num_star = 1;

            int t = 1;
            while (t <= num_levels)
            {
                {
                    int i = 1;
                    while (i <= num_blank)
                    {
                        Console.Write(" ");
                        i += 1;
                    }
                }
                {
                    int i = 1;
                    while (i <= num_star)
                    {
                        Console.Write("*");
                        i += 1;
                    }
                }
                {
                    int i = 1;
                    while (i <= num_new_line)
                    {
                        Console.Write("\n");
                        i += 1;
                    }
                }


                num_blank -= 1;
                num_star += 2;
                t += 1;
            }




            Console.WriteLine("結束");
            Console.WriteLine("");
        }

    }
}
