Random rand = new Random();
Random rand2 = new Random();
int toplam = 0;
int[] dizi = new int[rand2.Next(10, 20)];
for (int i = 0; i < dizi.Length; i++)
{
    dizi[i] = rand.Next(1, 50);
    toplam += dizi[i];
}
Console.Write($"toplam={toplam} \nortalama={(double)toplam / dizi.Length}"); // işlem önüne double koyunca tipi değişir