using System;
class Program
{
    static void Main(string[] args)
    {
        for (int i = 2; i <= 100; i++)// 被除數
        {
            for (int k = 2; k <= i; k++)// 除數
            {
                if (i % k == 0 && i != k) // 排除所有在 i=k 之前 能被k整除(餘數為0)的整數
                {
                    break;
                }
                if (i % k == 0 && i == k) // 輸出所有在 i=k 且 i%k=0的數
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

