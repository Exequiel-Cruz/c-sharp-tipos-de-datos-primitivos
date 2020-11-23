using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_de_datos_primitivos
{
    class NumeroDecimal
    {
        public static void IniciarPrueba()
        {
            Console.WriteLine("Pruebas con numeros decimales");
            try
            {
                int opcion = -1;
                do
                {
                    Console.WriteLine("1 - FLOAT");
                    Console.WriteLine("2 - DOUBLE");
                    Console.WriteLine("3 - DECIMAL");
                    Console.WriteLine("4 - Operaciones tipicas con numeros enteros");
                    Console.WriteLine("5 - SALIR");
                    Console.WriteLine("Eliga una opcion: ");
                    opcion = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine($"Float decimal 4 bytes rango de {float.MinValue} a {float.MaxValue}");
                            var flotante = 20648.25F;
                            Console.WriteLine($"Ejemplo numero float: {flotante}");
                            LimpiarCampos();
                            break;
                        case 2:
                            Console.WriteLine($"Double 8 bytes rango de {double.MinValue} a {double.MaxValue}");
                            var nroDouble = 105.22e2d;
                            Console.WriteLine($"Ejemplo numero decimal: {nroDouble}");
                            LimpiarCampos();
                            break;
                        case 3:
                            Console.WriteLine($"Decimal 16 bytes rango de {decimal.MinValue} a {decimal.MaxValue}");
                            var nroDecimal = 14475.36e3m;
                            Console.WriteLine($"Ejemplo numero decimal: {nroDecimal}");
                            LimpiarCampos();
                            break;
                        case 4:
                            Console.WriteLine("Ingresa el primer numero:");
                            var numero1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa el segundo numero");
                            var numero2 = double.Parse(Console.ReadLine());
                            Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
                            Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}");
                            Console.WriteLine($"{numero1} * {numero2} = {numero1 * numero2}");
                            Console.WriteLine($"{numero1} / {numero2} = {numero1 / numero2}");
                            LimpiarCampos();
                            break;
                        case 5:
                            Console.WriteLine("Saliendo ...");
                            break;
                        default:
                            Console.WriteLine("Opcion ingresada es incorrecta. Ingrese nuevamente");
                            LimpiarCampos();
                            break;
                    }
                } while (opcion != 5);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void LimpiarCampos()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}
