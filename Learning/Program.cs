// Inciando processo de aprendizagem

using System.Globalization;

namespace Learning
{
    public static class Program
    {
        public static void Main(string[] args)
        {
             
            var time = DateTime.UtcNow.ToString("dd-M-yyyy");
            Console.WriteLine($"{time}");
        }

    }

}



