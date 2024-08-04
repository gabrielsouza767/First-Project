using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer02
{
    internal  class Banco
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Saldo { get; set; }
        public double Sacar { get; set; }
        public char Ver { get; set; }
        public double Deposito { get; set; }
        public string Senha { get; set; }
        public double Empres { get; set; } 
        public Banco() {
            this.Saldo = 0;
            this.Nome = "Nome nao informado";
            this.Cpf = "Cpf nao informado";
        }
        //Metodo para verificar o cpf
        public void Verificacao()
        {
            Console.Write("Digite o seu CPF:");
            Cpf= Console.ReadLine();
            int[] vetorCpf = new int[11];
            try
            {
                for (int i = 0; i < vetorCpf.Length; i++)
                {
                    vetorCpf[i] = Convert.ToInt32(Cpf[i]);
                }
            }catch (Exception ex) { Console.WriteLine("Cpf incorreto"); }
        }
        // Metodo de mostrar as informaçoes
        public void InfoConta()
        {
            Console.WriteLine("Nome completo: "+Nome);
            Console.WriteLine("Cpf: "+Cpf);
            Console.WriteLine("Saldo da conta atual : "+Saldo);
            Console.WriteLine("Sua senha: "+Senha);
        }
        // Metodo de deposito de dinheiro
        public double DepositarDin(double deposito)
        {
            Console.Write("Confirme com sua senha: ");
            string sen = Console.ReadLine();
            while (sen != Senha)
            {
                Console.WriteLine("Senha incorreta");
                Console.Write("Confirme a senha novamente: ");
                sen = Console.ReadLine();
            }
                Saldo += deposito;
                Console.WriteLine("Sua conta tem agora :" + Saldo);
            return Saldo;
        }
        //Metodo de sacar dinheiro
        public double SacarDin(double saldo)
        {
            Console.Write("Confirme com sua senha: ");
            string sen = Console.ReadLine();
            while (sen != Senha)
            {
                Console.WriteLine("Senha incorreta");
                Console.Write("Confirme a senha novamente: ");
                sen = Console.ReadLine();
            }
                if (saldo > 0)
                {
                    if (Sacar <= saldo)
                    {
                        saldo -= Sacar;
                        Console.WriteLine("Sua conta ficou com : " + saldo + " depois do saque de " + Sacar);
                    }
                }
            else {
                Console.WriteLine("Nao foi possivel efetuar o saque...");
            }
            return saldo;
        }   
           
        //Metodo de fazer um emprestimo
        public void DpEmpres(double empres)
        {

            if (empres <= 8000)
            {
                Console.Write("Confirme com sua senha: ");
                string sen=Console.ReadLine();
                while (sen != Senha)
                {
                    Console.WriteLine("Senha incorreta");
                    Console.Write("Confirme a senha novamente: ");
                    sen = Console.ReadLine();
                }
                    Saldo -= Sacar;
                    Saldo += empres;
                    Console.WriteLine("Sua conta recebeu o emprestimo de " + empres + " ficando com o saldo de: " + Saldo);
                
            }
        }
        //Metodo para saber se  havera o deposito ou nao
        public static bool VerificaSaque(char ver)
        {
            return ver == 's';
        }
        
    }
}
