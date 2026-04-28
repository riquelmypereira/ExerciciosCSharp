double total = 0;
string nome;
double venda;
double comissao;

for (int i = 1; i <= 3; i++)
{
    Console.Write("Nome do corretor: ");
    nome = Console.ReadLine();

    Console.Write("Valor da venda: ");
    venda = double.Parse(Console.ReadLine());

    if (venda > 50000)
    {
        comissao = venda * 0.12;
    }
    else if (venda >= 30000)
    {
        comissao = venda * 0.095;
    }
    else
    {
        comissao = venda * 0.07;
    }

    total = total + venda;

    Console.WriteLine(nome + " - Venda: " + venda + " Comissão: " + comissao);
}

Console.WriteLine("Total de vendas: " + total);