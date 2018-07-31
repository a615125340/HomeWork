using System;
class Program {
    static void Main(string[] args) {
        //Console.WriteLine("開始");
        //// fix #1    印出 九九乘法表
        ////  煩請用 while 做出來
        //Console.WriteLine("1x1= 1 1x2= 2 1x3= 3 1x4= 4 1x5= 5 1x6= 6 1x7= 7 1x8= 8 1x9= 9 ");
        //Console.WriteLine("2x1= 2 2x2= 4 2x3= 6 2x4= 8 2x5=10 2x6=12 2x7=14 2x8=16 2x9=18 ");

        //Console.WriteLine(); Console.WriteLine();
        //Console.WriteLine("結束");
        //Console.WriteLine(); Console.WriteLine();
        //Console.WriteLine();
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

