using System;
using System.Globalization;

namespace ex02{

    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Inicie com os dados do produto:  ");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("O valor em estoque é de: ");

            produto.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("INFORMAÇÕES: " + produto);
            Console.WriteLine();

            Console.WriteLine("Atualizando estoque!" + produto);
            Console.Write("Digite o número de produtos a serem adicionados: ");
            int quantidade = int.Parse(Console.ReadLine());
            produto.AdicionarProduto(quantidade);
            Console.WriteLine("Atualizando estoque!" + produto);
            Console.WriteLine();


            Console.WriteLine("Atualizando estoque! " + produto);
            Console.Write("Digite o número de produtos a serem removidos: ");
            quantidade = int.Parse(Console.ReadLine());
            produto.RemoverProduto(quantidade);
            Console.WriteLine("Atualizando estoque! " + produto);
            Console.WriteLine();


        }
    }
}