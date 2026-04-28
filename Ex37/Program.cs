using System.Security.Cryptography;

double anos;
double meses;
double dias;
double total;

Console.Write("Idade em anos: ");
anos = double.Parse(Console.ReadLine());

Console.Write("Meses: ");
meses = double.Parse(Console.ReadLine());

Console.Write("Dias: ");
dias = double.Parse(Console.ReadLine());

total = anos * 365 + meses * 30 + dias;
Console.WriteLine("Dias vividos: " + total);
