double A;
double B;
double C;
double soma;

Console.Write("A: ");
A = double.Parse(Console.ReadLine());

Console.Write("B: ");
B = double.Parse(Console.ReadLine());

Console.Write("C: ");
C = double.Parse(Console.ReadLine());

soma = A + B;

if (soma > C)
{
    Console.WriteLine("Maior que C");
}
else if (soma < C)
{
    Console.WriteLine("Menor que C");
}
else
{
    Console.WriteLine("Igual a C");
}