class Pessoa
{
    private int _id;
    private string _nome;
    private string _cpf;
    private int _idade;
    private string _sexo;
    private double _altura;
    private double _peso;

    public Pessoa(int id, string nome, string cpf, int idade, string sexo, double altura, double peso)
    {
        setId(id);
        setNome(nome);
        setCpf(cpf);
        setIdade(idade);
        setSexo(sexo);
        setAltura(altura);
        setPeso(peso);

        Calculos.IMC(peso, altura / 100);
    }

    public Pessoa()
    {

    }

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
            if (Validacao.ValidarCpf(cpf))
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

    public void setIdade(int idade)
    {
        if (idade > 0)
        {
            _idade = idade;
        }
        else
        {
            throw new Exception("A idade deve ser maior do que zero!");
        }
    }
    public int getIdade()
    {
        return _idade;
    }

    public void setSexo(string sexo)
    {
        if (sexo == "Masculino" || sexo == "Feminino")
        {
            _sexo = sexo;
        }
        else
        {
            throw new Exception("O Sexo deve ser Masculino ou Feminino!");
        }
    }
    public string getSexo()
    {
        return _sexo;
    }

    public void setAltura(double altura)
    {
        if (altura > 0)
        {
            _altura = altura;
        }
        else
        {
            throw new Exception("A altura deve ser maior do que zero!");
        }
    }
    public double getAltura()
    {
        return _altura;
    }

    public void setPeso(double peso)
    {
        if (peso > 0)
        {
            _peso = peso;
        }
        else
        {
            throw new Exception("A peso deve ser maior do que zero!");
        }
    }
    public double getPeso()
    {
        return _peso;
    }
}