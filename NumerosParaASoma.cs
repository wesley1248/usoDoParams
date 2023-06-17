using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params {
    internal class NumerosParaASoma {
        // Método que recebe uma quantidade variável de números como parâmetros
        public static void Array(params int[] numeros)
        {
            // Solicita ao usuário que digite os números separados por vírgulas
            Console.WriteLine("Digite abaixo os numeros separados por virgulas(,)");
            Console.Write("Numeros: ");
            string entrada = Console.ReadLine();
            string[] numerosString = entrada.Split(',');

            // Converte os números fornecidos pelo usuário em um array de inteiros
            numeros = new int[numerosString.Length];
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = int.Parse(numerosString[i]);
            }

            // Variável para armazenar a soma dos números
            int resultadoDaSoma = 0;

            // Calcula a soma dos números fornecidos
            foreach (int numero in numeros)
            {
                resultadoDaSoma += numero;
            }

            // Exibe o resultado da soma
            Console.WriteLine("A soma dos numeros é: " + resultadoDaSoma);
        }
    }
}
