int a;
int b;

Console.Write("Digite O Primeiro valor: ");
a = int.Parse(Console.ReadLine());
Console.Write("Digite O segundo Valor: ");
b = int.Parse(Console.ReadLine());

if(a < b)
{
    Console.WriteLine("Este e o Maior Valor: " + b);

}
else if(b < a)
{
    Console.WriteLine("Este e o Maior Valor: " + a);

}
else
{
    Console.WriteLine("Os Valores São Iguais");
}
