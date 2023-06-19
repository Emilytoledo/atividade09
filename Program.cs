using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula09__produtos
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> produto = new List<string> { "Pepsi e Fanta" };

            Console.WriteLine("Bem-vindo ao Emy Store");
            Console.WriteLine("");
            Console.WriteLine("Dgite 1 para cadastrar e 2 para listar");
            string resposta = Console.ReadLine();




            if ( resposta == "1")


            {
                Console.WriteLine("Digite seu nome do produto");
                string produtos = Console.ReadLine();

                int contador = 0;
                bool existe = false;
                                                                                                            


                if (produtos.Contains(produtos.ToLower() ) )
                {

                    Console.WriteLine("Esse produto já está na lista...");
                    existe = true;
                }


                else
                {
                    produto.Add(produtos);
                    Console.WriteLine("Produto adicionado");                          
                }


                else
                {
                    string texto = "";
                    int contador = 0;
                   
                    
                    while (contador < produtos.Count)
                    {

                        string nome = produtos[contador];
                        string primeira_letra = nome.Substring(0, 1).ToUpper();
                        string resto = nome.Substring()
                        
                        
                        
                        
                        Console.WriteLine($"Nome:{produtos[contador]}");
                        contador++;
                    }

                    texto=texto.Substring(0,texto.Lenght-2);
                    

                    Console.WriteLine(texto);

                     
                }
            }                                       

                        

        }



    }
}
