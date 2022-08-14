using bytebank;

Console.WriteLine("Boas vindas ao seu banco!");

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Erick Silvério Blass";
conta1.conta = "10123-x";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Itaú Unibanco";
conta1.saldo = 441.93;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Rosangela Aparecida Silvério";
conta2.conta = "23123-x";
conta2.numero_agencia = 42;
conta2.nome_agencia = "Santander";
conta2.saldo = 2141.93;

//Console.WriteLine(conta1.titular);
//Console.WriteLine(conta1.conta);
//Console.WriteLine(conta1.numero_agencia);
//Console.WriteLine(conta1.nome_agencia);
//Console.WriteLine(conta1.saldo);

Console.WriteLine(conta2.titular);
Console.WriteLine(conta2.conta);
Console.WriteLine(conta2.numero_agencia);
Console.WriteLine(conta2.nome_agencia);
Console.WriteLine(conta2.saldo);

conta2.Sacar(1000.00);

Console.WriteLine(conta2.saldo);

conta2.Depositar(1500);

Console.WriteLine(conta2.saldo);

Console.ReadKey();