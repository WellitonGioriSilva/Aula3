public class Conta
{
    // Terceiro commit

    private int _id;
    private string _agencia;
    private string _numeroConta;
    private string _nomePropietario;
    private double _saldo;

    public Conta()
    {

    }

    public Conta(int id, string agencia, string numeroConta, string nomePropietario, double saldo)
    {
        _id = id;
        _agencia = agencia;
        _numeroConta = numeroConta;
        _nomePropietario = nomePropietario;
        _saldo = saldo;
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
    public int getId() { 
        return _id; 
    }

    public void setAgencia(string agencia)
    {
        if (agencia.Length > 0)
        {
            _agencia = agencia;
        }
        else
        {
            throw new Exception("A Agência não pode ser vazia!");
        }
    }
    public string getAgencia()
    {
        return _agencia;
    }

    public void setNumeroConta(string numeroConta)
    {
        if (numeroConta.Length > 0)
        {
            _numeroConta = numeroConta;
        }
        else
        {
            throw new Exception("O Número da Conta não pode ser vazio!");
        }
    }
    public string getNumeroConta()
    {
        return _numeroConta;
    }

    public void setNomePropietario(string nomePropietario)
    {
        if (nomePropietario.Length > 0)
        {
            _nomePropietario = nomePropietario;
        }
        else
        {
            throw new Exception("O Nome do Propietário não pode ser vazio!");
        }
    }
    public string getNomePropietario()
    {
        return _nomePropietario;
    }

    public void setSaldo(double saldo)
    {
        if(saldo > 0)
        {
            _saldo = saldo;
        }
        else
        {
            throw new Exception("O Saldo deve ser maior do que zero!");
        }
    }
    public double getSaldo()
    {
        return _saldo;
    }

    public void Depositar(double valor)
    {
        if (valor <= 0)
        {
            throw new Exception("Valores negativos/zero não são permitidos!");
        }

        _saldo += valor;
        Console.Clear();
        Console.WriteLine(valor.ToString("C2") + " Depositado com sucesso!");
        Console.WriteLine("Saldo Atual: " + getSaldo().ToString("C2"));    
    }

    public void Sacar(double valor)
    {
  
        if (valor <= 0)
        {
            throw new Exception("Valores negativos/zero não são permitidos");
        }
        if (_saldo < valor)
        {
            throw new Exception("O valor de saque é maior do que o saldo!\nSaldo Disponível: " + getSaldo().ToString("C2"));
        }

        _saldo -= valor;
        Console.Clear();
        Console.WriteLine(valor.ToString("C2") + " Sacado com sucesso!");
        Console.WriteLine("Saldo Atual: " + getSaldo().ToString("C2"));
    }
}

