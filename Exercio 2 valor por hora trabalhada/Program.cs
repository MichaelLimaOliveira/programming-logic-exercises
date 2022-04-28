
Double Salario;
Double Horas;
Double SalarioHoras;

//Entrada De dados

Console.Write("Digite o valor do Seu Salario Mensal: ");
Salario = Double.Parse(Console.ReadLine());
Console.Write("Digite A Quantidade de horas Mensais Trabalhadas: ");
Horas = Double.Parse(Console.ReadLine());



//Processamento de dados

SalarioHoras = Salario / Horas;


//entrega de dados resultado


Console.Write("Seu Valor Por Hora e de:" + SalarioHoras);


Console.ReadKey ();



