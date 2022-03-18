using System;

namespace _1900_contar_x_y_crescente_ou_decescente
{
    internal class Program
    {
        static void Main(string[] args)
        {
                        
            Console.WriteLine("Contagem em ondem crescente ou decescente");
            Console.WriteLine("Serve para exercícios de algoritimos 19 e 20");
            Console.WriteLine();
              
            Console.Write("Ordem da contagem, insira c para CRESCENTE e d para DECRESCENTE: ");
            string ordem = Console.ReadLine();
            Console.WriteLine();
              
            if (ordem == "c" )
            {
                Console.WriteLine("CRESCENTE:");

                Console.Write("Valor de início (MENOR): ");
                int i1 = int.Parse(Console.ReadLine());

                Console.Write("Valor de final  (MAIOR): ");
                int f1 = int.Parse(Console.ReadLine());

                Console.WriteLine();

                for (int contador = i1; contador <= f1-1; contador++)
                {
                    Console.Write(contador + ", ");
                }
                Console.WriteLine(f1 + ".");
                Console.WriteLine();
            }            
            else if (ordem == "d")
            {

                Console.WriteLine("DECRESCENTE:");

                Console.Write("Valor de início (MAIOR): ");
                int i2 = int.Parse(Console.ReadLine());

                Console.Write("Valor de final  (MENOR): ");
                int f2 = int.Parse(Console.ReadLine());

                Console.WriteLine();

                for (int contador = i2; contador >= f2 + 1; contador--)
                {
                    Console.Write(contador + ", ");
                }
                Console.WriteLine(f2 + ".");
                Console.WriteLine();
            }
            else
            {

                Console.WriteLine("inicie novamente e insira c ou d");

            }

            Console.WriteLine("fim");
            Console.ReadLine();

        }
    }
}
