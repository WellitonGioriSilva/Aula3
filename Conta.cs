public class Conta
{
    public int _id;
    public string _agencia;
    public string _numeroConta;
    public string _nomePropietario;
    private double _saldo;

    public void Depositar(double valor)
    {
        try
        {
            if (valor <= 0)
            {
                throw new Exception("Valores negativos/zero não são permitidos!");
            }

            _saldo += valor;
            Console.Clear();
            Console.WriteLine(valor.ToString("C2") + " Depositado com sucesso!");
            Console.WriteLine("Saldo Atual: " + GetSaldo().ToString("C2"));

        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }

    public void Sacar(double valor)
    {
        try
        {
            if (valor <= 0)
            {
                throw new Exception("Valores negativos/zero não são permitidos");
            }
            if (_saldo < valor)
            {
                throw new Exception("O valor de saque é maior do que o saldo!\nSaldo Disponível: " + GetSaldo().ToString("C2"));
            }

            _saldo -= valor;
            Console.Clear();
            Console.WriteLine(valor.ToString("C2") + " Sacado com sucesso!");
            Console.WriteLine("Saldo Atual: " + GetSaldo().ToString("C2"));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public double GetSaldo()
    {
        return _saldo;
    }
}

