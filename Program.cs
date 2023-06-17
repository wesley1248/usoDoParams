using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params {
    internal class Program {
        static void Main(string[] args)
        {
            // Exibe uma mensagem de boas-vindas e solicita ao usuário que digite os números separados por vírgula
            Console.WriteLine("Ola, digite abaixo separado por virgula (,) os números para serem somados!!");
            
            // Chama o método "Array" da classe "NumerosParaASoma" para realizar a soma dos números
            NumerosParaASoma.Array();
            
            // Aguarda o usuário pressionar uma tecla antes de encerrar o programa
            Console.ReadKey();
        }
    }
}
