using System;

namespace first_homework_task_1_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int evem_numbet = 40;
            for (int i = 0; i <= 40; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + "");
                }
            }
            Console.ReadKey();




            int[] oddnumbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            for (int i = 0; i < oddnumbers.Length; i++)
            {
                if (oddnumbers[i] % 2 == 1)
                {
                    sum += oddnumbers[i];
                }
            }
            Console.WriteLine(sum);




            double p, pin_num;
            double PI = 3.14;
            Console.WriteLine("Dairənin radiusunu daxil edin");
            p = Convert.ToDouble(Console.ReadLine());
            pin_num = 1 * PI * p;
            Console.WriteLine("Dairə perimetri {0}", pin_num);
            Console.Read();


        }
    }
}
