using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_Grado_Radianes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, p, ds;
            double c;
            Console.WriteLine("Opcion 1)Radianes>>2)Grados");
            n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("Digite los grados");
                p = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite 3.1415927");
                ds = int.Parse(Console.ReadLine());
                c = p * ds / 180;
                Console.WriteLine("La conversion es: " + c);

                if (n == 2)

                    Console.WriteLine("Digite los radianes");
                p = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite 3.1415927");
                ds = int.Parse(Console.ReadLine());
                c = p / 180 * ds;
                Console.WriteLine("La conversion es: " + c);

            }
        }
    }
}
