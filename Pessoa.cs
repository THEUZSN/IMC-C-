using System;
using System.Linq;
using System.Collections.Generic;

namespace ExercicioIMC;

public class Pessoa
{
    public string nome;
    public double peso, altura;

    public double IMC()
    {
        double result = peso / Math.Pow(altura, 2);
        return Math.Round(result, 2);
    }

    public string situacao(double imc)
    {
        imc = IMC();
        if (imc < 18.5)
        {
            return "Abaixo do peso";
        }

        else if (imc < 25)
        {
            return "Peso normal";
        }

        else if (imc < 30)
        {
            return "Acima do peso";
        }

        else if (imc < 35)
        {
            return "Obesidade nivel I";
        }

        else if (imc < 40)
        {
            return "Obesidade nivel II";
        }

        else
        {
            return "Obesidade nivel III";
        }
    }

    public void Msg()
    {
        double obterIMC = IMC();
        string obterSituacao = situacao(obterIMC);

        Console.WriteLine(nome + ", seu IMC é " + obterIMC + " seu estado é " + obterSituacao);
    }

}