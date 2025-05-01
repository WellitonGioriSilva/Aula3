class Funcionario
{
    private int _id;
    private string _nome;
    private string _cpf;
    private DateTime _dataNascimento;
    private string _email;
    private DateTime _dataAdmissao;
    private double _salario;

    // GET e SET
    public void setId(int id)
    {
        if (id > 0)
        {
            _id = id;
        }
        else
        {
            throw new Exception("O Id deve ser maior do que zero!");
        }
    }
    public int getId()
    {
        return _id;
    }

    public void setNome(string nome)
    {
        if (nome.Length > 0)
        {
            _nome = nome;
        }
        else
        {
            throw new Exception("O Nome não pode ser vázio!");
        }
    }
    public string getNome()
    {
        return _nome;
    }

    public void setCpf(string cpf)
    {
        if (cpf.Length > 0)
        {
            if (cpf.Replace("-", "").Replace(".", "").Length == 11 && ValidarCpf(cpf))
            {
                _cpf = cpf;
            }
            else
            {
                throw new Exception("CPF Inválido!");
            }
        }
        else
        {
            throw new Exception("O CPF não pode ser vázio!");
        }
    }
    public string getCpf()
    {
        return _cpf;
    }

    public void setDataNascimento(DateTime dataNascimento)
    {
        if (dataNascimento < DateTime.Now)
        {
            _dataAdmissao = dataNascimento;
        }
        else
        {
            throw new Exception("A Data de Nascimento deve ser menor à atual!");
        }
    }
    public DateTime getDataNascimento()
    {
        return _dataNascimento;
    }

    public void setEmail(string email)
    {
        if (email.Length > 0)
        {
            _email = email;
        }
        else
        {
            throw new Exception("O Email não pode ser vázio!");
        }
    }
    public string getEmail()
    {
        return _email;
    }

    public void setDataAdmissao(DateTime dataAdmissao)
    {
        if (dataAdmissao <= DateTime.Now)
        {
            _dataAdmissao = dataAdmissao;
        }
        else
        {
            throw new Exception("A Data de Admissão deve ser menor ou igual à atual!");
        }
    }
    public DateTime getDataAdmissao()
    {
        return _dataAdmissao;
    }

    public void setSalario(double salario)
    {
        if (salario >= 0)
        {
            _salario = salario;
        }
        else
        {
            throw new Exception("O salário não pode ser negativo!");
        }
    }

    public bool ValidarCpf(string cpf)
    {
        cpf = cpf.Replace("-", "").Replace(".", "");

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

        if (resto < 2) {
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
