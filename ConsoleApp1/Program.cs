using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade = 17;
            string cidade = "CJO";

            Console.WriteLine("ola seja bem vindo.Digite seu nome.");
                nome=Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("digite sua cidade");
            cidade = Console.ReadLine();
           
            //See https://aka.ms/new-console-templa for more
            Console.WriteLine("hello, world");
            Console.WriteLine("Nome: {0}");
            Console.WriteLine("idade: {0}");
            Console.WriteLine("Cidade: {0}");
            //Console.WriteLine("Nime: {0} \n idade: {1} anos \n cidade {2}", nome, idade, cidade);
        }
    }
}
