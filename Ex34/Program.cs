int maior = 0;
int meio = 0;
int menor = 0;
int a;
int b;
int c;

Console.Write("Digite o valor de A: ");
a = int.Parse(Console.ReadLine());

Console.Write("Digite o valor de B: ");
b = int.Parse(Console.ReadLine());

Console.Write("Digite o valor de C: ");
c = int.Parse(Console.ReadLine());

if (a < b)
{
    if (a < c)
    {
        menor = a;

        if (b < c)
        {
            meio = b;
            maior = c;
        }
        else
        {
            meio = c;
            maior = b;
        }
    }
}

Console.WriteLine("Ordem crescente: " + menor + " " + meio + " " + maior);