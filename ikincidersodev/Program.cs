using System;

namespace ikincidersodev
{
    class Program
    {
        static void Main(string[] args)
        {





            urun urun1 = new urun();
            urun1.urunAdi= "Samsung 40T5300 40'' 101 Ekran Uydu Alıcılı Full HD Smart LED TV";
            urun1.urunFiyati= 2976;
            urun1.indirimOrani =  22; 
            urun1.urunPuan = 35;

            urun urun2 = new urun();
            urun2.urunAdi = "LG 55NANO796 55'' 139 Ekran Uydu Alıcılı 4K Ultra HD NanoCell Smart TV";
            urun2.urunFiyati = 6099;
            urun2.indirimOrani =  11;
            urun2.urunPuan = 15;

            urun urun3 = new urun();
            urun3.urunAdi = "Samsung 40T5300 40'' 101 Ekran Uydu Alıcılı Full HD Smart LED TV";
            urun3.urunFiyati=2279;
            urun3.indirimOrani =  11;
            urun3.urunPuan = 9;

            urun urun4 = new urun();
            urun4.urunAdi = "Philips 58PUS8505 58'' 146 Ekran Uydu Alıcılı 4K Ultra HD Android Smart LED TV";
            urun4.urunFiyati = 6744;
            urun4.indirimOrani = 21;
            urun4.urunPuan = 9;

            urun[] urunler = new urun[] { urun1, urun2, urun3, urun4 };
            // foreach dongüsü ile yazdırılması:
            Console.WriteLine("**********************foreach dongüsü ile yazdırılması:***************************");
            foreach (var urun in urunler)
            {
                Console.WriteLine("ürün adı:"+" "+urun.urunAdi+"//"+"ürün fiyatı:"+" "+urun.urunFiyati+"₺"+"// "+"ürün indirim oranı:"+"%" +urun.indirimOrani+"//"+"ürün puanı:"+urun.urunPuan);
            }
            Console.WriteLine("**********************for dongüsü ile yazdırılması:***************************");
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine("ürün adı:" + "// " + urunler[i].urunAdi + "ürün fiyatı:" + urunler[i].urunFiyati + "₺"+"// " + "ürün indirim oranı:" + "% " + urunler[i].indirimOrani +"//"+ "ürün puanı" + urunler[i].urunPuan);

            }
            Console.WriteLine("**********************while dongüsü ile yazdırılması:***************************");
            int a = 0;
            int b = urunler.Length;
            while (a<b)

            {
                Console.WriteLine("ürün adı:" + urunler[a].urunAdi +"//"+ "ürün fiyatı:" + urunler[a].urunFiyati + "₺" + "// " + "ürün indirim oranı:" + "%" + urunler[a].indirimOrani +"//"+ "ürün puanı" +urunler[a].urunPuan);
                a++;
            }
            
            
            
            
        }
       
            
    }
    class urun
    {
        public string urunAdi { get; set; }
        public int urunFiyati { get; set; }
        public int indirimOrani { get; set; }
        public int urunPuan { get; set; }
    }

}
