using System;
using System.Threading;

namespace Console1
{
    class Program
    {
        public static void dibuja(int cantidad)
        {                                       
            {
                int Nvertical = 22; 
                int Nhorizontal = 77; 
                int Esbajo = 2; 
                int Esderecha = 2; 
                int F, C, A;

                for (A = 1; A <= cantidad; A++)

                {
                    for (F = Esderecha; F <= Nhorizontal; F++)
                    {
                        Console.SetCursorPosition(F, Nvertical); Console.Write("?");
                        Console.SetCursorPosition(F, Esbajo); Console.Write("?");
                    }
                    for (C = Esbajo; C <= Nvertical; C++)
                    {
                        Console.SetCursorPosition(Esderecha, C); Console.Write("X");
                        Console.SetCursorPosition(Nhorizontal, C); Console.Write("X");
                    }
                    Esbajo = Esbajo + 1;
                    Nvertical = Nvertical - 1; 
                    Esderecha = Esderecha + 1; 
                    Nhorizontal = Nhorizontal - 1;
                }

            }//for principal
                Console.WriteLine();
        }

        static void Main(string[] args)
        {
            for (int tam=1; tam <9; tam++)
            {
                dibuja(tam); 
                Thread.Sleep(1000); 
            }
            Console.SetCursorPosition(25, 24); 
            Console.Write("Pulse una tecla");
        
        }
        //end class
    }
}
