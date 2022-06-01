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
            string aux = ""; // auxiliar var

            Console.WriteLine("Digite el PIN de seguridad: ");
            string pin = Console.ReadLine();

            foreach (var number in pin)
            {
                bool num = int.TryParse(number.ToString(), out int n); // returns true when it can be parso to int

                if (num == true)
                {
                    // save numbers in auxiliar var
                    aux += number;
                }
            }

            PinValidation(aux);

            Console.Read();
        }

        // Pin validation method
        static void PinValidation(string pin)
        {
            if (pin.Count() == 4 || pin.Count() == 6)
            {
                bool verify = false;

                // Separe the string and count how many times every char appear
                foreach (var number in pin.GroupBy(p => p).Where(p => p.Count() != 1))
                {
                    // Assing true only if a char repeats
                    verify = true;
                }

                if (verify == true)
                {
                    Console.WriteLine("\n" + pin + " - Pin Invalido");
                }
                else { Console.WriteLine(pin + " - Pin Valido"); }
            }
            else { Console.WriteLine(pin + " - Pin Invalido"); }
        }
    }
}
