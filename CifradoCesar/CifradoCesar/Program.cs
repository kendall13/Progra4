using System;

namespace CifradoCesar
{
    class Program
    {
        static string abc = "abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ";

        static void Main(string[] args)
        {
            //String mensaje = "Cada vez que escucho hablar de ese gato, empiezo a sacar mi pistola.";

            
            
            Console.ReadKey();




        }

        static int GetPosABC(char caracter)
        {
            for (int i = 0; i < abc.Length; i++)
            {
                if(caracter == abc[i]){
                    return i;
                }
            }
                return -1;
        }




    }
}
