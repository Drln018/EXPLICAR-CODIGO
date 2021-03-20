using System;
using System.Threading;

namespace ConsoleAppclase2
{
    class Program
    {
        public static string Mid(string parametro, int startIndex, int Leght)
        {
            string result = parametro.Substring(startIndex, Leght); 
            return result;
        }
        static void Main(string[] args)
        {
            string NOM; 
            string CAR;
            int K = 0;
            int P = 0;
            int longitud = 0; 
            int Espderecha = 0; 
            Console.Write("Ingrese su nombre: ");
            NOM = Console.ReadLine(); 
            Console.SetCursorPosition(1, 12); 
            Console.Write(NOM); 
            longitud = NOM.Length; 
            Espderecha = 25; 
            NOM = NOM.ToUpper(); 

            for (P = NOM.Length; P >= 1; P--) 
            {
                CAR = Mid(NOM, P -1, 1); 
                for (K = longitud; K <= Espderecha; K++) 
                {
                    Console.SetCursorPosition(K, 12); 
                    Console.Write(" " + CAR); 
                    Thread.Sleep(100); 
                }
                Espderecha = Espderecha - 1; 
                longitud = longitud -  1; 
            }
            Console.WriteLine();

        }
    }
}
