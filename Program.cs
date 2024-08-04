using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inicio:
                Console.Clear();
                Banco m1 = new Banco();
                Comprar m2 = new Comprar();
                Console.WriteLine("Bem vindo ao Banco GS!");
                Console.Write("Digite seu nome completo: ");
                m1.Nome = Console.ReadLine();
                m1.Verificacao();
                Console.WriteLine("Crie sua senha:");
                m1.Senha = Console.ReadLine();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("As informações da conta são:");
                m1.InfoConta();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Deseja depositar: (S / N)");
                if (Banco.VerificaSaque(Convert.ToChar(Console.ReadLine().ToLower())))
                {
                    Console.WriteLine("Quanto deseja depositar:");
                    m1.Deposito = Convert.ToDouble(Console.ReadLine());
                    m1.DepositarDin(m1.Deposito);
                }
                Console.WriteLine("Deseja fazer um saque: (S / N)");
                if (Banco.VerificaSaque(Convert.ToChar(Console.ReadLine().ToLower())))
                {
                    Console.WriteLine("Quanto deseja sacar:");
                    m1.Sacar = Convert.ToDouble(Console.ReadLine());
                    m1.SacarDin(m1.Saldo);
                }
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Precisa de um emprestimo: (S / N)");
                if (Banco.VerificaSaque(Convert.ToChar(Console.ReadLine().ToLower())))
                {
                    Console.WriteLine("O limite de emprésitmo é 8000 reais");
                    Console.WriteLine("Quanto deseja de emprestimo:");
                    m1.Empres = Convert.ToDouble(Console.ReadLine());
                    m1.DpEmpres(m1.Empres);
                }
                Console.WriteLine("-----------------------------------");
                Fornecedor.EscolherProdutos();
                Fornecedor.Calcular();
                Console.Write("O que desejas comprar: ");
                m2.OqComprar = Console.ReadLine();
                m2.Comprou(m2.OqComprar);
                m2.VerificaUnis(m2.OqComprar);
                m2.Verificasaldo(m1.Saldo, m1.Senha);
                m2.DiminuiEstoque(m2.OqComprar);
            Console.WriteLine("Deseja finalizar: ");
            string term = Console.ReadLine();
            if (term != "Sim") {
                goto Inicio;
            }
            Console.ReadKey();
        }
    }  
}
