using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Exer02
{
    internal class Comprar
    {
        private int compraUni;
        public string OqComprar { get; set; }
        double tmp3;
        double precoNovo;
        public Comprar()
        {
            this.compraUni = 0;
            this.OqComprar = null;
        }
        //Metodo para ver se a pessoa escolheu um produto disponivel na loja
        public void Comprou(string oqComprar)
        {
            foreach (string s in Fornecedor.Produtos)
            {
                if (s == oqComprar)
                {
                    precoNovo = Fornecedor.Preco * 1.20;
                    return;
                }
            }
            Console.WriteLine("Nao temos este produto no momento");
        }
        // Metodo para ver se há estoque disponivel do produto 
        public void VerificaUnis(string oqComprar) {
            Console.WriteLine("Voce quer quantas unidades: ");
            compraUni = int.Parse(Console.ReadLine());
            for (int i = 0; i < Fornecedor.Produtos.Length; i++) {
                if (Fornecedor.Produtos[i] == oqComprar) {
                    if (Fornecedor.Quantidade[i] >= compraUni) {
                        tmp3 = compraUni*precoNovo;
                        Console.WriteLine("Preço a pagar: "+tmp3);
                    }
                }

            }
            
            }
        public void DiminuiEstoque(string oqComprar)
        {
            for (int i = 0; i < Fornecedor.Produtos.Length; i++)
            {
                if (Fornecedor.Produtos[i] == oqComprar)
                {
                    int cont=Fornecedor.Quantidade[i]-=compraUni;
                    if (cont>0)
                    {
                        Console.WriteLine("Caso queira comprar mais, ainda temos!");
                        Console.WriteLine("Temos o estoque de " + Fornecedor.Quantidade[i] + " do produto " + oqComprar);
                    }
                    
                }
            }
        }
        //Metodo para verificar se há saldo suficiente para pagar
        public void Verificasaldo(double saldo,string senha)
        {
            Console.WriteLine("Confirme sua senha:");
            string sen=Console.ReadLine();
            while (sen != senha)
            {
                Console.WriteLine("Senha incorreta");
                Console.Write("Confirme a senha novamente: ");
                sen = Console.ReadLine();
            }
            if (saldo >= tmp3)
            {
                Console.WriteLine("Compra aprovada");
            }
            else
            {
                Console.WriteLine("Compra nao aprovada");
            }
        }
    }
}
