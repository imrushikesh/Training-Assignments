using System;

namespace FirstDay_Assignment1_Fibonacci_Series
{
    class Series
    {

        /* Program 1 --->
                Write  program in C# to print fibonacci series 
               from 0 to n or less than n(n is number entered by user) 
                0,1,1,2,3,5,8…*/


        static void Main(string[] args)
        {
            int num_1 = 0, num_2 = 1, num_3;
            Console.Write("Enter number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write(num_1 + " " + num_2 + " ");
            for (int i = 2; i <= n; i++)
            {
                num_3 = num_1 + num_2;
                Console.Write(num_3 + " ");
                num_1 = num_2;
                num_2 = num_3;
            }
        }
    }

}
