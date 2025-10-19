using System;

namespace CarrinhoDeCompra
{
    class Program
    {

        // Exercicio Array e Listas

        public static void Main(string[] args)
        {
            Produto[] produtos = new Produto[]
            {
                new Produto("Teclado Mecanico", 150.9),
                new Produto("Mouse Logitech", 80.9),
                new Produto("Monitor LG 29", 1200.0)
            };

            List<Produto> carrinhoDeCompra = new List<Produto>();

            foreach (Produto item in produtos)
            {
                carrinhoDeCompra.Add(item);
            }

            Produto produto4 = new Produto("Headset Hyperx", 150.0);

            carrinhoDeCompra.Add(produto4);

            foreach (Produto item in carrinhoDeCompra)
            {
                Console.WriteLine($"Produto: {item.Nome} - Preço: {item.Preco:C}");
            }

            // ------------------------------------------------------------------------

            // Exercicio Array
            string[] alunos = new string[5];

            alunos[0] = "Naruto Uzumaki";
            alunos[1] = "Sakura Haruno";
            alunos[2] = "Sasuke Uchiha";
            alunos[3] = "Itachi Uchiha";
            alunos[4] = "Shino Aburami";

            Console.WriteLine("Nome dos alunos: ");
            foreach (string item in alunos)
            {
                Console.WriteLine($"Nome: {item}");
            }
        }
    }
}
