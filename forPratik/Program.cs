// See https://aka.ms/new-console-template for more information
for(int i = 1; i<= 10; i++)
{
    Console.WriteLine($"{i}. Kendime inanıyorum, ben bu yazılım işini hallederim!");
}
Console.WriteLine("--------------------------------------------------------------------");

for (int i = 1; i<=20; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("--------------------------------------------------------------------");

for (int i = 2; i<=20; i += 2)
{
    Console.WriteLine(i);
}
Console.WriteLine("--------------------------------------------------------------------");

int toplam = 0;
for (int i = 50; i<=150; i++)
{
    toplam += i;
}
Console.WriteLine($"Toplam = {toplam}");
Console.WriteLine("--------------------------------------------------------------------");

int cift = 0;
int tek = 0;
for (int i = 1; i <= 120; i++) {
    if (i % 2 == 0) {
        cift += i;
    } else
    {
        tek += i;
    }
}
Console.WriteLine($"Toplam çift sayısı = {cift} ,Toplam tek sayısı = {tek}");