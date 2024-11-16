using System;
using System.Globalization;

namespace CsharpStudies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bool completo = false; // True of False
            // char genero = 'F'; // Character unique
            // byte n1 = 122; // Value -127 to 126
            // float n2 = 4.1f;
            // double n3 = 4.2;
            // string nome = "Maria"; // Cadeia de caracteres unicode IMUTÁVEL, Não pode ser alterado após ser criado
            // object obj1 = "Alex"; // Classe genérica. 
            // object obj2 = 4.10f;

            // Console.WriteLine(completo);
            // Console.WriteLine(genero);
            // Console.WriteLine(n1);
            // Console.WriteLine(n2);
            // Console.WriteLine(n3);
            // Console.WriteLine(nome);
            // Console.WriteLine(obj1);
            // Console.WriteLine(obj2);

            // System.Console.WriteLine("Bom dia 1"); // Quebra linha
            // System.Console.Write("Bom dia 2"); // Não quebra linha
            // System.Console.WriteLine("Boa Tarde");

            // int idade = 32;
            // double saldo = 10.17344;
            // string nome = "Maria";

            // System.Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo); // Placeholders
            
            // System.Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); // Interporlação

            // System.Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais"); // Concatenação

            // System.Console.WriteLine(genero);
            // System.Console.WriteLine(idade);
            // System.Console.WriteLine(saldo);
            // System.Console.WriteLine(nome);
            // System.Console.WriteLine(saldo.ToString("F2")); // Limitando saldo à 2 casas decimais
            // System.Console.WriteLine(saldo.ToString("F4")); // Limitando saldo à 4 casas decimais
            // System.Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); // Desconsidera qualquer formatação especifica de pais
           
           
            // Exercicio

            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            System.Console.WriteLine("Produtos:");
            System.Console.WriteLine($"{produto1} cujo preço é ${preco1:F2}");
            System.Console.WriteLine($"{produto2} cujo preço é ${preco2:F2}");

            System.Console.WriteLine($"Registro: {idade} anos de idade, codigo {codigo} e gênero: {genero}");
            
            System.Console.WriteLine($"Medida com oito casa decimais: {medida:F8}");
            System.Console.WriteLine($"Arredondado (Três casas decimais): {medida:F3}");
            System.Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
