
// Snack 3
/*Console.Write("Inserisci 10 numeri: ");
int somma = 0;
for (int i = 0; i < 10; i++)
{
    int numeroutente = int.Parse(Console.ReadLine());
    somma += numeroutente;
}
Console.WriteLine($"La somma totale dei numeri inseriti é : {somma}");
*/

//Snack 4
int sum4 = 0;
float avg = 0f;
int a = 0;

for (int i = 2; i <= 10; i++)
{
    a += 1;
    sum4 = sum4 + i;

}

avg = sum4 / a;
Console.WriteLine(sum4);
Console.WriteLine(avg);

return;