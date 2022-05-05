using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q01
{
    class Program
    {
        static void Main(string[] args)
        {
            string errorMsg = "請輸入正整數";
            string inputText = "Hello";

            Console.Write("請輸入列數：");
            string input = Console.ReadLine();

            int number = 0;
            if(Int32.TryParse(input, out number))
            {
                if(number < 0)
                {
                    Console.WriteLine(errorMsg);
                }
                else
                {
                    int totalLength = number + 5;

                    Console.WriteLine();

                    StringProcess process = new StringProcess();
                    int index = 0;
                    for(int i=0;i<number;i++)
                    {
                        int length = totalLength - i;
                        var result = process.GetPartString(inputText, index, length, totalLength);
                        Console.WriteLine(result.Item1);
                        index = result.Item2;
                    }
                }

            }
            else
            {
                Console.WriteLine(errorMsg);
            }





            Console.WriteLine();
            Console.WriteLine("請輸入任意鍵結束!");
            Console.ReadKey();
        }
    }
}
