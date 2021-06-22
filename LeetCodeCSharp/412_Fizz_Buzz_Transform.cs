using System;

namespace LeetCodeCSharp
{
    public class Fizz_Buzz_Transform
    {
        public static string FizzBuzz(int n, int m) {
            string str = "";
            int starNo = n>m? m:n;
		    int endNo = n>m? n:m;

            for(int i = starNo; i <= endNo; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    str += "FizzBuzz, ";
                    continue;
                }
                if(i % 3 == 0)
                {
                    str += "Fizz, ";
                    continue;
                }
                if(i % 5 == 0)
                {
                    str += "Buzz, ";
                    continue;
                }
                
                str += i.ToString()+", ";
            }
            return str.Substring(0, str.Length -2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("-----FizzBuzz-----");
            Console.WriteLine(FizzBuzz(1, 3));
            Console.WriteLine(FizzBuzz(1, 5));
            Console.WriteLine(FizzBuzz(5, 15));
        }
    }
}