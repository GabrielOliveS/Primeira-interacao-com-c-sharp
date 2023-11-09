// Inciando processo de aprendizagem

using System.Globalization;

namespace Learning
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            bool erro = true;
            string valor1 = null;
            string valor2 = null;

            while (erro == true) 
            {
                Console.Write("Digite o primeiro valor: ");
                valor1 = Console.ReadLine();
                Console.Write("Digite o segundo valor: ");
                valor2 = Console.ReadLine();
                if (valor1 == null || valor2 == null || valor1 == "" || valor2 == "") 
                {
                    Console.WriteLine("Escreva um valor válido");
                }
                else
                {
                    erro = false;
                }
           
                
            }
            var soma = int.Parse(valor1) + int.Parse(valor2);
            Console.WriteLine(soma);
            Console.ReadKey();
             
        }

    }

}



