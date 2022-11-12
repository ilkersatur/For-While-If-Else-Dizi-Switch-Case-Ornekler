// metin içindeki karakterleri tek tek yazma 
string metin=Console.ReadLine();
foreach (char item in metin)
{
   Console.WriteLine(item);
}

// for ile

for (int i = 0; i < metin.Length; i++) // string zaten bir dizidir 
{
    Console.WriteLine(metin[i]);
}

