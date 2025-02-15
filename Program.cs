using System;
using System.Linq;
using ExercicioIMC;

namespace ExercicioIMC;

public static class Program
{
    public static void Main()
    {
        Pessoa pessoa = new Pessoa();
        Console.WriteLine("Qual seu nome ?");
        pessoa.nome = Console.ReadLine();

        Console.WriteLine("--------------------------------------");

        Console.WriteLine("Digite seu peso :");
        pessoa.peso = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("--------------------------------------");

        Console.WriteLine("Digite sua altura :");
        pessoa.altura = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("--------------------------------------");

        Console.WriteLine(pessoa.IMC());
        pessoa.Msg();
    }
}
