using System;

namespace kt28H6
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] num={1,2,3,4};

         for(int i =0; i<num.Length; i++)
         {
            var answer= num[i];
            int result = answer * 2;
            System.Console.WriteLine(result);
         }
        }
    }
}
