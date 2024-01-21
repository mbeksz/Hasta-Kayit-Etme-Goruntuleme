bool devamEt = true;
List<string> hastaVeriTabani = new List<string>();
Console.WriteLine("Ozel BEKSOZ Hastanesine hosgeldiniz.");
while (devamEt)
{
Console.WriteLine("Giris yapmak istediginiz birimi giriniz...");
Console.WriteLine("1: Hasta hayıt birimi");
Console.WriteLine("2: Radyoloji birimi");
int deger = int.Parse(Console.ReadLine());
switch (deger)
{
	case 1: // hasta kayit sayfasi
		Console.WriteLine("Hasta kayıt biriminine giris yapildi");
		while (true)
		{
		Console.WriteLine("Kayıt yapmak icin 1'e basiniz --- Yazdirmak için 2'ye basiniz --- Çıkış için 0 a basınız ");

		int kDeger = int.Parse(Console.ReadLine());
		if(kDeger == 1)
		{
	    Console.WriteLine("Hasta bilgisini yazin");
		string hastaAdi= Console.ReadLine();
                    hastaVeriTabani.Add(hastaAdi);
                    Console.WriteLine("Hasta bilgisi kaydedildi.");
                }
            else if(kDeger == 2)
			{

                    if (hastaVeriTabani.Count == 0)
                    {
                        Console.WriteLine("Kayıtlı hasta bulunmamaktadır.");
                    }
                    else
                    {
                        Console.WriteLine("Kayıtlı hastalar:");
                        foreach (string hastaAdi in hastaVeriTabani)
                        {
                            Console.WriteLine(hastaAdi);
                        }
                    }
                }
            else if (kDeger == 0)
            {
                Console.WriteLine("Programdan çıkılıyor...");
                break; // while döngüsünden çıkış yap
            }
            else
            {
                Console.WriteLine("Geçersiz seçenek. Lütfen geçerli bir seçenek girin.");
            }
        }
		break;

        case 2:
            // Radyoloji birimi işlemleri
            Console.WriteLine("Radyoloji birimine giriş yapıldı");
            // Radyoloji birimi işlemleri buraya gelecek
            bool cagir = true;
            while (cagir)
            {
                Console.WriteLine($"Toplam kayıtlı hasta sayısı: {hastaVeriTabani.Count}");

                Console.WriteLine("Hasta cagirmak icin 9'a basiniz --- Cikis yapmak icin 5 e basiniz");
             int radDeger = int.Parse(Console.ReadLine());

            if (radDeger == 9)
             {
                    Console.WriteLine($"Lutfen iceri giriniz:   {hastaVeriTabani[0]} ");
                    Console.WriteLine("Sıradaki hastalar:");
                    hastaVeriTabani.RemoveAt(0);

                    // İlk 4 hastayı yazdır
                    int limit = Math.Min(4, hastaVeriTabani.Count);
                    for (int i = 0; i < limit; i++)
                    {
                        Console.WriteLine(hastaVeriTabani[i]);
                    }
                }
            else if(radDeger == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Gecersiz deger girdiniz...");
                }
            }      
            break;

        case 3:
            Console.WriteLine("Programdan çıkılıyor...");
            devamEt = false; // Ana while döngüsünden çıkış yap
            break;

        default:
            Console.WriteLine("Geçersiz birim numarası. Lütfen geçerli bir numara girin.");
            break;
    }
}


