
double n1;
double n2;
double n3;
double media;
Console.Write("Nota 1: ");
n1 = double.Parse(Console.ReadLine());

Console.Write("Nota 2: ");
n2 = double.Parse(Console.ReadLine());

Console.Write("Nota 3: ");
n3 = double.Parse(Console.ReadLine());

media = (n1 * 2 + n2 * 3 + n3 * 5) / 10;
Console.WriteLine("Media final: " + media);
