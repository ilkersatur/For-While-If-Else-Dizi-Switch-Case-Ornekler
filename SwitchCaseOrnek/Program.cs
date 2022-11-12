//bool i = true;
//while (i)
//{
//    Console.WriteLine("1 ya da 2 giriniz");
//    string secim = Console.ReadLine();
//    switch (secim)
//    {
//        case "1":
//            Console.Write("satış miktarı= ");
//            int satis = Convert.ToInt32(Console.ReadLine());
//            Console.Write("taban ücreti= ");
//            double tabanucret = Convert.ToDouble(Console.ReadLine());
//            double prim;
//            if ((50000 > satis))
//            {
//                prim = satis * 0.01;
//            }
//            else if (50000 < satis && 100000 > satis)
//            {
//                prim = satis * 0.02;
//            }
//            else
//            {
//                prim = satis * 0.03;
//            }
//            Console.WriteLine("taban ücret= {0}, prim= {1}", (prim + tabanucret), prim);
//            break;
//        case "2":
//            Console.WriteLine("çıkış yapıldı");
//            i = false;
//            break;

//        default:
//            Console.WriteLine("1 ve 2 arası değer giriniz");
//            break;
//    }
//}
///////////
Console.WriteLine("1 ya da 2 giriniz");
string secim = Console.ReadLine();
do
{
    switch (secim)
    {
        case "1":
            Console.Write("satış miktarı= ");
            int satis = Convert.ToInt32(Console.ReadLine());
            Console.Write("taban ücreti= ");
            double tabanucret = Convert.ToDouble(Console.ReadLine());
            double prim;
            if ((50000 > satis))
            {
                prim = satis * 0.01;
            }
            else if (50000 < satis && 100000 > satis)
            {
                prim = satis * 0.02;
            }
            else
            {
                prim = satis * 0.03;
            }
            Console.WriteLine("taban ücret= {0}, prim= {1}", (prim + tabanucret), prim);
            break;
        case "2":
            Console.WriteLine("çıkış yapıldı");
            break;

        default:
            Console.WriteLine("1 ve 2 arası değer giriniz");
            break;
    }
}
while (secim != "2"); //2 farklı mı 2 den---- farklı şart sağlandı do ya git

//break; döngüden çıkmak için kullanılır
//  ve case in bittiğini söyler