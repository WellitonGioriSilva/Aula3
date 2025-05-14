public static class Validacao
{
    public static bool ValidarCpf(string cpf)
    {
        cpf = cpf.Replace("-", "").Replace(".", "");

        if (cpf.Length != 11)
        {
            return false;
        }

        string parte1 = cpf.Substring(0, 9);
        string parte2 = cpf.Substring(9, 2);

        int soma = 0;
        int resto = 0;

        string verificador = "";

        // PARTE 1

        for (int i = 0; i < 9; i++)
        {
            soma += (Convert.ToInt32(parte1[i].ToString()) * (10 - i));
        }

        resto = soma % 11;

        if (resto < 2)
        {
            verificador += "0";
        }
        else
        {
            verificador += (11 - resto).ToString();
        }


        // PARTE 2
        soma = 0;
        resto = 0;
        parte1 += verificador;
        for (int i = 0; i < 10; i++)
        {
            soma += (Convert.ToInt32(parte1[i].ToString()) * (11 - i));
        }

        resto = soma % 11;

        if (resto < 2)
        {
            verificador += "0";
        }
        else
        {
            verificador += (11 - resto).ToString();
        }

        if (verificador != parte2)
        {
            return false;
        }

        return true;
    }
}