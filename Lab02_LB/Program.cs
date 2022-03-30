using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_LB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            double perimetro;
            double area;
            Console.WriteLine("Ingrese un Valor para X:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un Valor para Y:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El lado X es: " + x);
            Console.WriteLine("El lado Y es: " + y);
            perimetro = (2 * (x + y));
            area = x * y;
            Console.WriteLine("El Perimetro es: " + perimetro);
            Console.WriteLine("El Area es: " + area);
            Console.Read();
        }
    }
}
