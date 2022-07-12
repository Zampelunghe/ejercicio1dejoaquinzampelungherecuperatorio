using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1dejoaquinzampelungherecuperatorio
{
    class Program
    {
		static void Main(string[] args)
		{
			double dolares;
			double euros;
			double pesos;
			
			Console.Write($"ingrese la cantidad de dolares:");
			dolares = Double.Parse(Console.ReadLine());

			pesos = dolares * 230;
			Console.WriteLine($"Con {dolares} dolares se puede comprar {pesos} pesos en el mercado oficial:");

			pesos = dolares * 280;
			Console.WriteLine($"Con {dolares} dolares se puede comprar {pesos} pesos en el mercado paralelo:");

			euros = dolares * 1.17;
			Console.WriteLine($" {dolares} dolares equivalen a {euros} euros:");

			Console.ReadLine();
		}
    }
}
