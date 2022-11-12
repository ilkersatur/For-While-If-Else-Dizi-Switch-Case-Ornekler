// metin içindeki boşlukların sayısı
string metin = Console.ReadLine();
int bosluk = 0;

for (int i = 0; i < metin.Length; i++)
{

    if (metin[i] == ' ')
    {
        bosluk++;
    }

}
Console.WriteLine(bosluk);
