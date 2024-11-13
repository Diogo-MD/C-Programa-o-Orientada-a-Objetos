using System;

namespace CsharpStudies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool completo = false; // True of False
            char genero = 'F'; // Character unique
            byte n1 = 122; // Value -127 to 126
            float n2 = 4.1f;
            double n3 = 4.2;
            string nome = "Maria"; // Cadeia de caracteres unicode IMUTÁVEL, Não pode ser alterado após ser criado
            object obj1 = "Alex"; // Classe genérica. 
            object obj2 = 4.10f;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
        }
    }
}
