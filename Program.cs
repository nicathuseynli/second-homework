using System;

namespace first_homework_task_1_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            Console.WriteLine("Even Numbers :");
            for (i = 1; i <= 40; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

           
        }
    }
}
