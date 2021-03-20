using System;
using System.Threading;

namespace ConsoleAppotro
{
    class Program
    { 
        public static string generaletra() //metodo llamado genera letra
        {
            Random ran = new Random(); //random crea numeros aleatorios
                                       //nueva version del metodo

            int num = Convert.ToInt32(ran.Next(100)); //num va a ser igual a ran
            // Console.WriteLine($"El numero generado es: {num}");
            string respuesta = ""; //se abre comillas simples
            if (((num > 0) & (num < 256))) //numero es mayor a cero y menor a 256
            {
                respuesta = Convert.ToString((char)num); //respues va a ser igual al numero generado
            }
            return respuesta; //la respuesta regresara
        }
        static void Main(string[] args)
        {
            byte can, k;
            string linea;
            Console.Write("Cuantos numeros: ");
            linea = Console.ReadLine(); //se guardara en linea
            can = byte.Parse(linea); //can se vconvertira en linea
            string letras = ""; //comillas simples
            for (k=1; k <= can; k++)
            {
                letras = generaletra(); //las letras va a ser igual al metodo generaletra
                Console.WriteLine($"El codigo es {letras} ");
 
            }

        }
    }
}
