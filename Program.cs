try
{
    int r = Convert.ToInt32(Console.ReadLine()) / Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(r);
}
catch(DivideByZeroException ex)
{
    Console.WriteLine("Não pode ser dividido por zero!");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("SISTEMA DE CONTA BANCÁRIA");
Console.WriteLine("");

List<Conta> lContas = new List<Conta>();    

while (true)
{    
    Console.WriteLine("Digite 1 para cadastrar, 2 para listar, 3 para depositar, 4 para sacar, e 5 para sair!");
    int opc = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    if (opc == 1)
    {
        Console.WriteLine("CADASTRAR NOVA CONTA");
        Console.WriteLine("");

        Conta conta = new Conta();

        int idAutoIncrement = 0;
        Conta ultimaConta = lContas.FindLast(c => c._id == c._id);
        if (ultimaConta != null)
        {
            idAutoIncrement = ultimaConta._id;
        }

        conta._id = idAutoIncrement+1;

        Console.Write("Digite o número da agência: ");
        conta._agencia = Console.ReadLine();

        Console.WriteLine("");
        Console.Write("Digite o número da conta: ");
        conta._numeroConta = Console.ReadLine();

        Console.WriteLine("");
        Console.Write("Digite seu nome: ");
        conta._nomePropietario = Console.ReadLine();
        lContas.Add(conta);
    }
    else if (opc == 2)
    {
        foreach (Conta c in lContas)
        {
            Console.WriteLine($"{c._id} | {c._numeroConta} | {c._nomePropietario} | {c.GetSaldo().ToString("C2")} \n");
        }

        Console.ReadKey();
    }
    else if (opc == 3)
    {
        Console.WriteLine("DEPOSITAR");
        Console.WriteLine("");
        Console.Write("Digite a agência: ");
        string agencia = Console.ReadLine();
        Console.Write("Digite o número da conta: ");
        string numero = Console.ReadLine();

        Conta conta = lContas.Where(c => c._agencia == agencia).Where(c => c._numeroConta == numero).FirstOrDefault();

        if (conta != null)
        {
            Console.WriteLine("");
            Console.WriteLine($"Conta: {conta._nomePropietario}");
            Console.Write("Digite o valor de depósito: ");
            conta.Depositar(Convert.ToDouble(Console.ReadLine()));
            Console.ReadKey();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Conta não encontrada!");
            Console.ReadKey();
        }
    }
    else if (opc == 4)
    {
        Console.WriteLine("SACAR");
        Console.WriteLine("");
        Console.Write("Digite a agência: ");
        string agencia = Console.ReadLine();
        Console.Write("Digite o número da conta: ");
        string numero = Console.ReadLine();

        Conta conta = lContas.Where(c => c._agencia == agencia).Where(c => c._numeroConta == numero).FirstOrDefault();

        if (conta != null)
        {
            Console.WriteLine("");
            Console.WriteLine($"Conta: {conta._nomePropietario}");
            Console.Write("Digite o valor de saque: ");
            conta.Sacar(Convert.ToDouble(Console.ReadLine()));
            Console.ReadKey();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Conta não encontrada!");
            Console.ReadKey();
        }
    }
    else
    {
        break;
    }

    Console.Clear();
}

/*
while (true)
{
    
}
*/