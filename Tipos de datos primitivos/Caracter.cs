using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_de_datos_primitivos
{
    class Caracter
    {
        public static void IniciarPrueba()
        {
            try
            {
                int opcion = -1;
                do
                {
                    Console.WriteLine("0 - Salir");
                    Console.WriteLine("1 - Verificar tipo de caracter");
                    Console.WriteLine("2 - Cambiar a minuscula");
                    Console.WriteLine("3 - Cambiar a mayuscula");
                    Console.WriteLine("Eliga una opcion: ");
                    opcion = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (opcion)
                    {
                        case 0:
                            Console.WriteLine("Saliendo ...");
                            break;
                        case 1:
                            Console.WriteLine("Ingrese un caracter: ");
                            char caracter = Char.Parse(Console.ReadLine());
                            //es una letra?
                            if (char.IsLetter(caracter)) Console.WriteLine($"{caracter} es una letra");
                            //es un numero?
                            if (char.IsDigit(caracter)) Console.WriteLine($"{caracter} es un numero");
                            //es minuscula?
                            if (char.IsLower(caracter)) Console.WriteLine($"{caracter} es minuscula");
                            //es mayuscula?
                            if (char.IsUpper(caracter)) Console.WriteLine($"{caracter} es mayuscula");
                            //es un espacio en blanco?
                            if (char.IsWhiteSpace(caracter)) Console.WriteLine($"{caracter} es un espacio en blanco");
                            LimpiarCampos();
                            break;

                        case 2:
                            Console.WriteLine("Ingresar caracter en minuscula: ");
                            char minuscula = char.Parse(Console.ReadLine());
                            if (char.IsLetter(minuscula))
                            {
                                Console.WriteLine($"{minuscula} -> {char.ToUpper(minuscula)}");
                            }
                            else
                            {
                                Console.WriteLine($"{minuscula} no es un caracter en minuscula");
                            }
                            LimpiarCampos();
                            break;

                        case 3:
                            Console.WriteLine("Ingresar caracter en minuscula: ");
                            char mayuscula = char.Parse(Console.ReadLine());
                            if (char.IsLetter(mayuscula))
                            {
                                Console.WriteLine($"{mayuscula} -> {char.ToUpper(mayuscula)}");
                            }
                            else
                            {
                                Console.WriteLine($"{mayuscula} no es un caracter en minuscula");
                            }
                            LimpiarCampos();
                            break;

                        default:
                            Console.WriteLine("Opcion ingresada incorrecta");
                            LimpiarCampos();
                            break;
                    }
                } while (opcion != 0);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void LimpiarCampos()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}
