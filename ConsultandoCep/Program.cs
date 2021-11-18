using Caelum.Stella.CSharp.Http;
using System;
using System.Net.Http;

namespace ConsultandoCep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Digite um Cep Válido ");
            string cep = Console.ReadLine();

            // Consultando o Web Service do Via Cep 
            ViaCEP viaCEP = new ViaCEP();
            string enderecoJson = viaCEP.GetEnderecoJson(cep);
            Console.WriteLine(enderecoJson);

            //Trazendo apenas Logradouro e Bairro
            var endereco = viaCEP.GetEndereco(cep);
            Console.WriteLine(string.Format("Logradouro:{0}, Bairro: {1} ", endereco.Logradouro, endereco.Bairro));

            Console.ReadKey();
        }      

    }

}
