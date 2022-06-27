
Console.Write("Inserisci 10 numeri: ");
int somma = 0;
for (int i = 0; i < 10; i++)
{
    int numeroutente = int.Parse(Console.ReadLine());
    somma += numeroutente;
}
Console.WriteLine($"La somma totale dei numeri inseriti é : {somma}");