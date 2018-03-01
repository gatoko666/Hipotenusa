using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Escribir un método que acepte dos catetos y devuelve la hipotenusa (usar la clase Math para calcular la raíz cuadrada)

namespace Hipotenusa
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                try
                {
                    Console.WriteLine("Escriba un primer cateto : ");
                    string palabra1 = Console.ReadLine();
                    double cateto1 = int.Parse(palabra1);
                    Console.WriteLine("Escriba un segundo  cateto : ");
                    string palabra2 = Console.ReadLine();
                    double cateto2 = int.Parse(palabra2);

                    double hipotenusa;

                    hipotenusa = Math.Sqrt((cateto1 * cateto1 + cateto2 * cateto2));
                    Console.WriteLine("La hipotenusa es  " + hipotenusa);
                    Console.Read();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Escribe algún valor válido");
                }
            }



        }

    }
}

