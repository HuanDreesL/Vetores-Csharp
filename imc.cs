double IMC (double peso, double altura)
{
    return peso / Math.Pow (altura, 2);
}

string DescricaoIMC (double peso, double altura)
{
    double imc = IMC (peso, altura);
    
    if (imc < 18.5)
    {
        return $"Seu IMC é {imc:f2} -> Abaixo do Peso";
    }
    else if (imc < 25)
    {
        return $"Seu IMC é {imc:f2} -> Peso Normal";
    }
    else if (imc < 30)
    {
        return $"Seu IMC é {imc:f2} -> Sobrepeso";
    }
    else if (imc < 35)
    {
        return $"Seu IMC é {imc:f2} -> Obeso leve";
    }
    else if (imc < 40)
    {
        return $"Seu IMC é {imc:f2} -> Obeso moderado";
    }
    else
    {
        return $"Seu IMC é {imc:f2} -> Tu tá gordão hein";
    }
}

Console.WriteLine("Digite seu peso em kg: ");
double peso = double.Parse(Console.ReadLine());

Console.WriteLine("Digite sua altura em metros: ");
double altura = double.Parse(Console.ReadLine());

Console.WriteLine(DescricaoIMC (peso, altura));
