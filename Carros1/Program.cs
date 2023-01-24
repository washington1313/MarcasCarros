using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Carros1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] carros = new string[6];
            
            for(int contadorCarros = 0; contadorCarros < carros.Length; contadorCarros++) 
            {
                Console.WriteLine("Digite o fabricante do veículo: ");
                carros[contadorCarros] = Console.ReadLine();
                    
                Console.Clear();
            }
            for (int contadorCarros = 0; contadorCarros < carros.Length; contadorCarros++)
            {
                Console.WriteLine(carros[contadorCarros]);
                
            }
                Console.ReadKey();

        }
    }
}
