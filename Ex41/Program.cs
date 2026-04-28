

double SalarioMinimo;
int carros;
double vendas;
double salario;

Console.Write("Salario minimo: ");
SalarioMinimo = double.Parse(Console.ReadLine());

Console.Write("Carros Vendidos: ");
carros = int.Parse(Console.ReadLine());

Console.Write("Valor total das Vendas: ");
vendas = double.Parse(Console.ReadLine());

salario = SalarioMinimo * 2 + carros * 50 + vendas * 0.05;
Console.WriteLine("Salario total: " + salario);