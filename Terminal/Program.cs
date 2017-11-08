using System;
using Dados;
using Util;

namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaPF contapf = new ContaPF();

            contapf.Depositar(100);

            Console.WriteLine("Seu saldo é: " + contapf.Saldo);

            contapf.Sacar(50);

            Console.WriteLine("Seu saldo é: " + contapf.Saldo);

            // ValidaCPF valcpf = new ValidaCPF();

            // Console.WriteLine(valcpf.validaCPF());
        }
    }
}
