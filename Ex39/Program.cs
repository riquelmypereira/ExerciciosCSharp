double compra;
double pago;
int troco;
int n100;
int n10;
int n1;

Console.Write("Valor da compra: ");
compra = double.Parse(Console.ReadLine());

Console.Write("Valor pago: ");
pago = double.Parse(Console.ReadLine());

troco = (int)(pago - compra);

n100 = troco / 100;
troco = troco % 100;

n10 = troco / 10;
troco = troco % 10;

n1 = troco;

Console.WriteLine("Troco: " + (pago - compra));
Console.WriteLine("Notas de 100: " + n100);
Console.WriteLine("Notas de 10: " + n10);
Console.WriteLine("Notas de 1: " + n1);