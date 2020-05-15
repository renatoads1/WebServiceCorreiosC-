using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebServiceCorreios
{
    using WSCep;
    class Program
    {
        static void Main(string[] args)
        {
            
            using (var ws = new AtendeClienteClient()) 
            {
                try
                {
                    Console.WriteLine("Escreva seu Cep:");
                    string cep = Console.ReadLine();
                    //var resposta = ws.consultaCEPAsync(cep).Result;
                    var resposta = ws.consultaCEP(cep);
                    //Console.WriteLine(String.Format(":{0}", resposta.@return.bairro));
                    Console.WriteLine(String.Format("Endereço: {0}", resposta.end));
                    Console.WriteLine(String.Format("Bairro: {0}", resposta.bairro));
                    Console.WriteLine(String.Format("Cidade: {0}", resposta.cidade));
                    Console.WriteLine(String.Format("Estado: {0}", resposta.uf));
                    Console.ReadKey();
                }
                catch (System.Exception err)
                {
                    Console.WriteLine(err);
                    Console.ReadKey();
                }
                

            }

        }

    }
}
