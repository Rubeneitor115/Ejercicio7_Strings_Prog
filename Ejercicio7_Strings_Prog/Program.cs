/***
 * Ruben Bernal Ramos
 * CSI1
 */

namespace Ejercicio7_Strings_Prog
{
    /// <summary>
    /// Clase principal de la aplicación
    /// rbr - 110324
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal de la aplicación
        /// rbr - 110324
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //Declaro las variables
            string frase;
            int numeroPalabras = 1;

            //Pido la frase por consola
            Console.WriteLine("Introduzca una frase: ");
            frase = Console.ReadLine();

            //Muestro la frase introducida
            Console.WriteLine("La frase introducida es: " + frase);

            //Calculo el número de palabras
            for (int i=0; i<frase.Length; i++)
            {
                if (frase[i]==' ')
                {
                    numeroPalabras = numeroPalabras + 1;
                }
            }

            //Muestro por consola el número de palabras
            Console.WriteLine("La frase introducida tiene " + numeroPalabras + " palabras.");
        }
    }
}