public static class Calculos
{
    public static void IMC(double peso, double altura)
    {
        (double imcIni, double imcFim, string classificao, int obesidade)[] tuplaImc = {
            (0, 18.4, "Magreza", 0),
            (18.5, 24.9, "Normal", 0),
            (25, 29.9, "Sobrepeso", 1),
            (30, 39.9, "Obesidade", 2),
            (40, 100, "Obesidade Grave", 3)
        };

        double imc = peso / (altura * altura);
        foreach (var classificacao in tuplaImc)
        {
            if (imc >= classificacao.imcIni && imc <= classificacao.imcFim)
            {
                Console.WriteLine($"Classificação: {classificacao.classificao}");
                Console.WriteLine($"Obesidade Grau: {classificacao.obesidade}");
            }
        }
    }
}

