double A;
double B;

Console.Write("Digite o valor de A: ");
A = double.Parse(Console.ReadLine());

Console.Write("Digite o valor de B: ");
B = double.Parse(Console.ReadLine());

if (A > B)
{
    Console.WriteLine("A é maior que B");
}
else if (B > A)
{
    Console.WriteLine("B é maior que A");
}
else
{
    Console.WriteLine("A é igual a B");
}