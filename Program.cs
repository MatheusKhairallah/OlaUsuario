using System;

namespace OlaUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Por favor, digite seu nome: ");
            string nome=Console.ReadLine();

            string mensagemNome="Obrigado, " +nome+ "!";

            Console.WriteLine(mensagemNome);
        }
    }
}
