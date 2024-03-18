
using MusteriTakip;

Musteri musteri = new Musteri();
musteri.Id = 1;
musteri.Ad = "Ömer";
musteri.SoyAd = "Adıgüzel";
musteri.TelefonNo = "05456958493";
musteri.KimliNo = "33883357921";

Musteri musteri1 = new Musteri();
musteri1.Id = 2;
musteri1.Ad = "Hüseyin";
musteri1.SoyAd = "Korkutan";
musteri1.TelefonNo = "05456958494";
musteri1.KimliNo = "33883357931";

MusteriManager musteriManager = new MusteriManager();
musteriManager.Ekle(musteri);
musteriManager.Sil(musteri1);


Musteri[] musteriler = new Musteri[] { musteri,musteri1 };
foreach (var x in musteriler)
{
    musteriManager.Listele(x);
}




