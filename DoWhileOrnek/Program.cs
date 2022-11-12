using System.Collections.Concurrent;

Random rand1 = new Random();
Random rand2 = new Random();
int[] tombala = new int[15];
int sayac = 0;
int dongu_sayısı = 0;
do
{
    bool varmı = false;
    int sayi = new Random().Next(1, 91);
    foreach (int s in tombala)
    {
        if (sayi == s)
        {
            Console.WriteLine("<<" + sayi + ">>");
            varmı = true;
        }
    }
    if (varmı == false)
    {
        tombala[sayac] = sayi;
        sayac++;
        Console.WriteLine(sayi + " ");
    }
    dongu_sayısı++;
} while (sayac < 15);

Console.WriteLine($"döngü sayısı= {dongu_sayısı}");