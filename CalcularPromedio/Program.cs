using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularPromedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2=0 , num3=0, promedio=0;
            Console.WriteLine("Calcular el promedio de 3 números");
            Console.WriteLine("Ingrese el primer valor");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer valor");
            num3 = Convert.ToInt32(Console.ReadLine());
            promedio = (num1 + num2 + num3) / 3;
            Console.WriteLine("Los datos ingresados son: " + num1 + " " + num2 + " " + num3);
            Console.WriteLine("El promedio de los valores es: " + promedio);
            Console.ReadLine();
        }
    }
}
