using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un numero:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            int[] array = new int[n];
            int producto = 1;

            for (int i = 0; i < array.Length; i++)
            {
                Random rand = new Random();
                array[i] = rand.Next(20); // Set value limit to 20

                producto *= array[i];
            }
            Console.WriteLine("\nLa multiplicacion es igual a: " + producto);

            if (producto % 2 == 0)
            {
                int sum = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }

                Console.WriteLine("\nLa suma total es: " + sum);
            }
            else { Console.WriteLine("\n0"); }

            Console.Read();
        }
    }
}
