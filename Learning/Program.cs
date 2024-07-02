// Inciando processo de aprendizagem

using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Learning
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            double numeroA = ObterNumero(1);
            double numeroB = ObterNumero(2);
            string operacao = ObterOperacao(numeroA, numeroB);
            Console.WriteLine($"Expressão: {operacao}");
        }

        private static double ObterNumero(int index)
        {
            while (true)
            {
                Console.WriteLine($"Escreva o {index}º número:");
                string? valorA = Console.ReadLine();
                var resultadoConversaoA = double.TryParse(valorA, out var numeroA);
                if (resultadoConversaoA == false)
                {
                    Console.WriteLine("Digite o valor corretamente!");
                    continue;
                }

                return numeroA;
            }
        }
        private static string ObterOperacao(double numA, double numB) 
        {
            Console.WriteLine("Selecione a opereção desejada:");
            string[] operacoes = new string[] { "1-Soma", "2-Subtração", "3-Multiplicação", "4-Divisão" };
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine(operacoes[i]);    
            }

            while (true)
            {
                var operacao = Console.ReadLine()?.ToLower();
                var resultado = string.Empty;
                switch (operacao)
                {
                    case "soma" or "1":
                        resultado = FormatarResultado(numA + numB);
                        return $"{numA} + {numB} = {resultado}";
                    case "subtração" or "2":
                        resultado = FormatarResultado(numA - numB);
                        return $"{numA} - {numB} = {resultado}";
                    case "multiplicação" or "3":
                        resultado = FormatarResultado(numA * numB);
                        return $"{numA} * {numB} = {resultado}";
                    case "divisão" or "4":
                        resultado = FormatarResultado(numA / numB);
                        return $"{numA} / {numB} = {resultado}";
                    default:
                        Console.WriteLine("Opção inválida, escreva corretamente!");
                        break;
                }                        
            }
        }

        private static string FormatarResultado(double resultado)
        {
            var sections = resultado.ToString().Split(',');
            var resultadoString = sections[0];

            var decimals = "00";
            if (sections.Length == 2)
            { 
                decimals = sections[1].Substring(0, 2); 
            }

            var retorno = string.Empty;
            var count = 0;

            for (var i = 1; i <= resultadoString.Length; i++)
            {
                if (count != 0 && count % 3 == 0)
                    retorno = '.' + retorno;

                retorno = resultadoString[resultadoString.Length - i] + retorno;
                count++;
            }

            return $"{retorno},{decimals}";
        }
    }
}