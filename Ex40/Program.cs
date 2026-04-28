string nome;

int parafusos;
int porcas;
int arruelas;

double precoParafusos = 2;
double precoPorca = 1.5;
double precoArruela = 1;

double total;
double desconto;
double pagar;

Console.Write("Nome do cliente: ");
nome = Console.ReadLine();

Console.Write("Qtd parafusos: ");
parafusos = int.Parse(Console.ReadLine());

Console.Write("Qtd porcas: ");
porcas = int.Parse(Console.ReadLine());

Console.Write("Qtd arruelas: ");
arruelas = int.Parse(Console.ReadLine());

total = (parafusos * precoParafusos) + (porcas * precoPorca) + (arruelas * precoArruela);

desconto = (parafusos * precoParafusos * 0.2) +
           (porcas * precoPorca * 0.1) +
           (arruelas * precoArruela * 0.3);

pagar = total - desconto;

Console.WriteLine("Cliente: " + nome);
Console.WriteLine("Total: " + total);
Console.WriteLine("Desconto: " + desconto);
Console.WriteLine("Total a pagar: " + pagar);