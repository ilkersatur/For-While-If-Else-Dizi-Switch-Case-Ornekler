string cevap, sonuc;
cevap = Console.ReadLine();

int sayi = Convert.ToInt32(cevap);
sonuc = "";
while (sayi > 1)
{

    int x = sayi % 2;
    sonuc = Convert.ToString(x) + sonuc;         //çalış buna
    sayi /= 2;
}
sonuc = Convert.ToString(sayi) + sonuc;
Console.WriteLine("ikili: {0}", sonuc);

//int sayi = int.Parse((Console.ReadLine);
//string ikilisayi = "";
//while (sayi>0)
//{
//    ikilisayi = sayi % 2 + ikilisayi;
//    sayi = sayi / 2;
//}
//Console.WriteLine(ikilisayi);


