string nome;
double portugues;
double matematica;
double conhecimentosgerais;
double media;

Console.Write("Nome: ");
nome = Console.ReadLine();

Console.Write("Português: ");
portugues = double.Parse(Console.ReadLine());

Console.Write("Matemática: ");
matematica = double.Parse(Console.ReadLine());

Console.Write("Conhecimentos Gerais: ");
conhecimentosgerais = double.Parse(Console.ReadLine());

media = (portugues + matematica + conhecimentosgerais) / 3;

Console.WriteLine("Nome: " + nome);
Console.WriteLine("Notas: " + portugues + ", " + matematica + ", " + conhecimentosgerais);
Console.WriteLine("Média: " + media);

if (media >= 7)
{
    if (portugues > 5)
    {
        if (matematica > 5)
        {
            if (conhecimentosgerais > 5)
            {
                Console.WriteLine("Resultado: APROVADO");
            }
            else
            {
                Console.WriteLine("Resultado: REPROVADO");
            }
        }
    }
}
