using System;
using System.Text;

namespace GeradorDeSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de caracteres que terá sua senha: ");
            int qtd = int.Parse(Console.ReadLine());

            while (qtd > 0)
            {
                string caracteresPossiveis =
                    "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                    "abcdefghijklmnopqrstuvwxyz" +
                    "0123456789" +
                    "!@#$%&";

                Random sorteio = new Random();
                int numeroSorteado = 0;
                StringBuilder senha = new StringBuilder();

                for (int i = 0; i < qtd; i++)
                {
                    numeroSorteado = sorteio.Next(0, caracteresPossiveis.Length - 1);
                    senha.Append(caracteresPossiveis[numeroSorteado]);
                }
                Console.WriteLine();
                Console.WriteLine(senha.ToString());
                Console.WriteLine();
                Console.Write("Digite o número de caracteres que terá sua senha: ");
                qtd = int.Parse(Console.ReadLine());
            }
        }
    }
}