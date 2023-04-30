using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double l1;
            double l2;
            double l3;

            Console.Write("insira o valor da primeira lateral: ");
            l1 = double.Parse(Console.ReadLine());

            Console.Write("insira o valor da Segunda lateral: ");
            l2 = double.Parse(Console.ReadLine());

            Console.Write("insira o valor da Terceira lateral: ");
            l3 = double.Parse(Console.ReadLine());

            if ((l1 > l2+l3) || (l2 > l1+l3) || (l3 > l1+l2))
                if ((l1 == l2) && (l1==l3))
                Console.WriteLine("Os lados formam um triângulo equilátero.");
                else 
                    if ((l1==l2 && l1<l3) || (l1 == l3 && l1 < l2) || (l3 == l2 && l3 < l1))
                    Console.WriteLine("Os lados formam um triângulo Isósceles.");
                    else
                    Console.WriteLine("Os lados formam um triângulo escaleno.");
            else
            Console.WriteLine("os valores atribuídos para os lados não formam um triângulo.");

        }
    }
}
