using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBasico9
{
    class EjercicioBasico9
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Introduzca el primer número entero: ");
                Int16 primer_numero = Convert.ToInt16(Console.ReadLine());
                Console.Write("Introduzca el segundo número entero: ");
                Int16 segundo_numero = Convert.ToInt16(Console.ReadLine());
                Double resultado = primer_numero / (segundo_numero * 1.0);
                Console.WriteLine("El reslutado de dividir " + primer_numero + " entre " + segundo_numero + " es " + resultado);
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (System.DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(System.FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
