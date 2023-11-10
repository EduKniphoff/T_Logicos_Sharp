using System;
using System.Collections.Generic;
using System.Globalization;


//Eduardo D Kniphoff RU 3768302
namespace ex02
{
    internal class Produto
    {

        //Definimos o que vamos usar aqui.
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Valot total do estoque
        public double TotalEstoque()
        {
            return Preco * Quantidade;
        }

        //Adicionando e retirando produtos
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

        //Expondo as informações
        public override string ToString()
        {
            return Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                +", "
                +Quantidade
                +"unidades, Total: $ "
                + TotalEstoque().ToString("F2", CultureInfo.InvariantCulture)
                ;
        }

    }

}
