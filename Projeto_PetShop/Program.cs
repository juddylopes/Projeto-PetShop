



using System.Text.RegularExpressions;

namespace  Projeto_PetShop
{
    class Program
    {
        static void Main (string[] args)
        {
            //cadastro de numero de celular do cliente 
            string padraoNumeroCelular = "[9][0-9]{8}";
            string numeroCelularCliente = "Número de celular do cliente sem dígitos: 973426997";
            if (Regex.IsMatch(numeroCelularCliente, padraoNumeroCelular))
            {
                Match numeroCorreto = Regex.Match(numeroCelularCliente, padraoNumeroCelular);
                Console.WriteLine("Número cadastrado: " + numeroCorreto);
            }
            else
            {
                Console.WriteLine("Número de celular inválido.");
            }







        }

    }
}
