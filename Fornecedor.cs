using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Exer02
{
    static class Fornecedor
    {
        // Declaraçao de variáveis
        private static string[] produtos= new string[5];
        private static int[] quantidade= new int[5];
        public static string[] Produtos { get { return produtos; } set {
                for (int i = 0; i < value.Length; i++)
                {
                    produtos[i] = value[i];
                }
            } }
        public static double Estoque { get; set; } = 50;
        public static int[] Quantidade { get { return quantidade; } set {
                for (int i = 0; i < value.Length; i++)
                {
                    quantidade[i] = value[i];
                }
            } }
        public static int Preco { get; set; } = 50;
        //Metodo para definir os produtos disponiveis e a quantidade deles
        public static void EscolherProdutos()
        {
            Console.WriteLine("Fornecedor para Logista");
            for (int i = 0; i < produtos.Length; i++) {
                Console.WriteLine("Digite os produtos que voce quer, ate 5: ");
                produtos[i] = Console.ReadLine();
            }
            for (int i = 0; i < produtos.Length; i++)
            {
                Console.WriteLine("Digite a quantidade de cada produto que quer, ate 50 de cada:");
                quantidade[i] = int.Parse(Console.ReadLine());
            }
        }
        //Metodo para calcular o preço base para a loja pagar
        public static void Calcular()
        {
            int tmp = 0;
            for (int i=0;i<produtos.Length;i++) {
                 tmp = quantidade[i] *Preco ;
            }
            Console.WriteLine("Preço final de todos os produtos: "+tmp + " com o preço de 200 R$ cada produto");
        }
}   }
