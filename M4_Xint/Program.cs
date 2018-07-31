using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xint
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;//隨機整數
            string y;//使用者猜的字串
            bool z;//string轉int
            int a = 0;//使用者猜的數字
            int b = 1;//最小值初始值
            int c = 100;//最大值初始值
            ConsoleColor ori = Console.ForegroundColor;//字體顏色變數
            x = (int)(new Random().NextDouble() * 100 + 1);//隨機數字1至100

            while (x != a)
            {
                Console.WriteLine("請隨機輸入" + b + "至" + c + "數值");
                y = Console.ReadLine();
                z = int.TryParse(y, out a);//string轉int
                if (a < b || a > c)
                {
                    Console.ForegroundColor = ConsoleColor.Red;//錯誤警告顏色
                    Console.WriteLine("輸入的數值超過範圍");
                    Console.ForegroundColor = ori;//恢復顏色
                }
                else
                {
                    if (a < x)
                    {
                        b = a;
                    }
                    if (a > x)
                    {
                        c = a;
                    }
                }
            }
            Console.WriteLine("恭喜你猜對了，答案是" + x);

        }
    }
}
