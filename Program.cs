using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace External_Evaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            int uchenici = int.Parse(Console.ReadLine());

            double m2 = 0.0;
            double m3 = 0.0;
            double m4 = 0.0;
            double m5 = 0.0;
            double m6 = 0.0;


            for (int i = 0; i < uchenici; i++)
            {
                double tochki = double.Parse(Console.ReadLine());

                if (tochki >= 0 && tochki < 22.5)
                {
                    m2++;
                }
                else if (tochki >= 22.5 && tochki < 40.5)
                {
                    m3++;
                }
                else if (tochki >= 40.5 && tochki < 58.5)
                {
                    m4++;
                }
                else if (tochki >= 58.5 && tochki < 76.5)
                {
                    m5++;
                }
                else if (tochki >= 76.5 && tochki <= 100)
                {
                    m6++;
                }
            }

            double Percent2 = m2 * 100 / uchenici;
            double Percent3 = m3 * 100 / uchenici;
            double Percent4 = m4 * 100 / uchenici;
            double Percent5 = m5 * 100 / uchenici;
            double Percent6 = m6 * 100 / uchenici;

            Console.WriteLine($"{Percent2:f2}% poor marks");
            Console.WriteLine($"{Percent3:f2}% satisfactory marks");
            Console.WriteLine($"{Percent4:f2}% good marks");
            Console.WriteLine($"{Percent5:f2}% very good marks");
            Console.WriteLine($"{Percent6:f2}% excellent marks");
            



        }
    }
}
