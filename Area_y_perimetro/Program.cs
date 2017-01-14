using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_y_perimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1, b, h, p;
            Console.WriteLine("Opciones 1)Area 2)Perimetro");
            n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Digite la base");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite la altura");
                    h = int.Parse(Console.ReadLine());
                    p = b * h / 2;
                    Console.Write("El resultado: " + p);
                    break;
                case 2:
                    Console.WriteLine("Dijite la base");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dijite la altura");
                    h = int.Parse(Console.ReadLine());
                    p = b * h;
                    Console.WriteLine("El resultado es:" + p);
                    break;
            }
            Console.ReadLine();
        }
    }
}
