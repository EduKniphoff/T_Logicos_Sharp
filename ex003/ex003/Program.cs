using System;
using System.Threading;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String entrada;
                int entradaConvertida = 0;
                do
                {
                    //Colocamos o imput dos numeros que vao ser utilizados e convertemos com "ToInt"
                    Console.Write("Digite os dois ultimos numeros de seu RU: ");
                    entrada = Console.ReadLine();
                    try
                    {
                        entradaConvertida = Convert.ToInt32(entrada);
                    }
                    catch
                    {
                        entradaConvertida = 0;

                    }
                    if (entradaConvertida > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entrada Inválida!");
                    }
                } while (true);
                Console.WriteLine("Numeros Primos: ");

                //Executamos os códigos para definir as Threads e criamos a lógica para definir se um número é primo usando for loops e if/else

                int quantidadeThreads = entradaConvertida <= 10 ? 1 : Decimal.ToInt32(Decimal.Ceiling(entradaConvertida / 10)) + 1;
                Console.WriteLine(quantidadeThreads);
                for (var i = 1; i <= quantidadeThreads; i++)
                {
                    int inicial = i == 1 ? 1 : ((i - 1) * 10 + 1);
                    int final = i == 1 ? (entradaConvertida <= 10 ? entradaConvertida : i * 10) : (i * 10 < entradaConvertida ? i * 10 : entradaConvertida);

                    //Usando a Thread como solicitado
                    Thread t1 = new(() =>
                    {
                        Primo(inicial, final, entradaConvertida);
                    });

                    //Chamamos a t1
                    t1.Start();

                }
            }
            catch
            {
                Console.WriteLine("Erro!");
            }



        }
        public static void Primo(int inicial, int final, int n)
        {
            List<int> numeroPrimo = new();

            for (var i = inicial; i <= final; i++)
            {
                for (var e = 2; e <= n; e++)
                {
                    if ((i % e) == 0 && i != e)
                    {
                        break;
                    }
                    else
                    {
                        numeroPrimo.Add(i);
                    }
                    foreach (var numerosPrimo in numeroPrimo)
                    {
                        Console.WriteLine(numerosPrimo);
                    }

                }
            }
        }


    }
}
