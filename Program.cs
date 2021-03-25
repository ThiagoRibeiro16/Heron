using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Clear();

           String a , b ,c;
           double lado1 , lado2, lado3, semiPerimetro , area;

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("/Digite os lados do triângulo desejado./");
            Console.WriteLine("---------------------------------------\n");

            Console.Write("Lado 1..: ");
            a = Console.ReadLine();
            Console.WriteLine();
            
            Console.Write("Lado 2..: ");
            b = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Lado 3..: ");
            c = Console.ReadLine();
            Console.WriteLine();

            lado1 = Convert.ToDouble(a);
            lado2 = Convert.ToDouble(b);
            lado3 = Convert.ToDouble(c);

            semiPerimetro = (lado1 + lado2 + lado3) / 2;

            area = Math.Sqrt (semiPerimetro * (semiPerimetro - lado1) * (semiPerimetro - lado2) * (semiPerimetro - lado3) );
            
            Console.Write($"Semiperímetro..: {semiPerimetro}\n");
            Console.Write($"Área...........: {area}");

            
            
           

            






        }
    }
}
