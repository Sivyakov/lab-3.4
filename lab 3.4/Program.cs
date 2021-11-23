using System;

namespace lab_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("|     x       |      y       |");
                for (double x = 1; x <= 3; x += 0.2)
                {
                    double y = x * x * x - 7 * x - 7;
                    Console.WriteLine("|{0,13:F1}|{1,14:F2}|", x, y);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
