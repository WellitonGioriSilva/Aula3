try
{
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
            Conta ultimaConta = lContas.FindLast(c => c.getId() == c.getId());
            if (ultimaConta != null)
            {
                idAutoIncrement = ultimaConta.getId();
            }

            conta.setId(idAutoIncrement + 1);

            Console.Write("Digite o número da agência: ");
            conta.setAgencia(Console.ReadLine());

            Console.WriteLine("");
            Console.Write("Digite o número da conta: ");
            conta.setNumeroConta(Console.ReadLine());

            Console.WriteLine("");
            Console.Write("Digite seu nome: ");
            conta.setNomePropietario(Console.ReadLine());
            lContas.Add(conta);
        }
        else if (opc == 2)
        {
            foreach (Conta c in lContas)
            {
                Console.WriteLine($"{c.getId()} | {c.getNumeroConta()} | {c.getNomePropietario()} | {c.getSaldo().ToString("C2")} \n");
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

            Conta conta = lContas.Where(c => c.getAgencia() == agencia).Where(c => c.getNumeroConta() == numero).FirstOrDefault();

            if (conta != null)
            {
                Console.WriteLine("");
                Console.WriteLine($"Conta: {conta.getNomePropietario()}");
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

            Conta conta = lContas.Where(c => c.getAgencia() == agencia).Where(c => c.getNumeroConta() == numero).FirstOrDefault();

            if (conta != null)
            {
                Console.WriteLine("");
                Console.WriteLine($"Conta: {conta.getNomePropietario()}");
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
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Fechando conexão com banco de dados");
}