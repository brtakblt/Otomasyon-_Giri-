using System.ComponentModel.Design;

namespace Otomasyon__Giriş
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Bakiyenizi giriniz: ");
            double bakiye = Convert.ToDouble(Console.ReadLine());



            while (true)
                {

                string[] urunler = { "kola", "fanta", "su", "Mırra" };
                double[] fiyatlar = { 40, 40, 10, 70 };



              


                Console.WriteLine("Ürün numarasını giriniz:");
                    Console.WriteLine("1-) Fanta = 40 TL");
                    Console.WriteLine("2-) Kola = 40 TL");
                    Console.WriteLine("3-) Su = 10 TL");
                    Console.WriteLine("4-) Mırra = 70 TL");
                    Console.WriteLine("9-) Para ekleme.");
                    Console.WriteLine("0-) Çıkış.");



                    string urunSecimi = Console.ReadLine();




                    if (urunSecimi == "1")
                    {
                        while (bakiye < fiyatlar[0])
                        {
                            Console.WriteLine("Bakiyeniz yetersiz. Bakiyenizi artırmak için 9'a basın, çıkmak için 0'a basın.");
                            int secim = Convert.ToInt32(Console.ReadLine());

                            if (secim == 9)
                            {
                                Console.WriteLine("Eklemek istediğiniz miktarı giriniz: ");
                                double paraEkleme1 = Convert.ToDouble(Console.ReadLine());
                                bakiye += paraEkleme1;
                                Console.WriteLine("Güncel bakiyeniz: " + bakiye);
                            }
                            else if (secim == 0)
                            {
                                Console.WriteLine("Paranızı alınız.");
                                Thread.Sleep(2500);
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Hatalı tuşlama.");
                                Thread.Sleep(1500);
                            }
                        }
                        Console.WriteLine("Afiyet olsun! Fanta'yı aldınız.");
                        bakiye -= fiyatlar[0];
                        Console.WriteLine("Kalan bakiye: " + bakiye);
                    }

                    else if (urunSecimi == "2")
                    {
                        while (bakiye < fiyatlar[1])
                        {
                            Console.WriteLine("Bakiyeniz yetersiz. Bakiyenizi artırmak için 9'a basın, çıkmak için 0'a basın.");
                            int secim = Convert.ToInt32(Console.ReadLine());
                            if (secim == 9)
                            {
                                Console.WriteLine("Eklemek istediğiniz miktarı giriniz: ");
                                double paraEkleme2 = Convert.ToDouble(Console.ReadLine());
                                bakiye += paraEkleme2;
                                Console.WriteLine("Güncel bakiyeniz: " + bakiye);
                            }
                            else if (secim == 0)
                            {
                                Console.WriteLine("Paranızı alınız.");
                                Thread.Sleep(2500);
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Hatalı tuşlama.");
                                Thread.Sleep(1500);
                            }
                        }
                        Console.WriteLine("Afiyet olsun! Kola'yı aldınız.");
                        bakiye -= fiyatlar[1];
                        Console.WriteLine("Kalan bakiye: " + bakiye);
                    }
                    else if (urunSecimi == "3")
                    {
                        while (bakiye < fiyatlar[2])
                        {
                            Console.WriteLine("Bakiyeniz yetersiz. Bakiyenizi artırmak için 9'a basın, çıkmak için 0'a basın.");
                            int secim = Convert.ToInt32(Console.ReadLine());
                            if (secim == 9)
                            {
                                Console.WriteLine("Eklemek istediğiniz miktarı giriniz: ");
                                double paraEkleme3 = Convert.ToDouble(Console.ReadLine());
                                bakiye += paraEkleme3;
                                Console.WriteLine("Güncel bakiyeniz: " + bakiye);
                            }
                            else if (secim == 0)
                            {
                                Console.WriteLine("Paranızı alınız." + bakiye);
                                Thread.Sleep(2500);
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Hatalı tuşlama.");
                                Thread.Sleep(1500);
                            }
                        }
                        Console.WriteLine("Afiyet olsun! Su aldınız.");
                        bakiye -= fiyatlar[2];
                        Console.WriteLine("Kalan bakiye: " + bakiye);
                    }
                    else if (urunSecimi == "4")
                    {
                        while (bakiye < fiyatlar[3])
                        {
                            Console.WriteLine("Bakiyeniz yetersiz. Bakiyenizi artırmak için 9'a basın, çıkmak için 0'a basın.");
                            int secim = Convert.ToInt32(Console.ReadLine());
                            if (secim == 9)
                            {
                                Console.WriteLine("Eklemek istediğiniz miktarı giriniz: ");
                                double paraEkleme3 = Convert.ToDouble(Console.ReadLine());
                                bakiye += paraEkleme3;
                                Console.WriteLine("Güncel bakiyeniz: " + bakiye);
                            }
                            else if (secim == 0)
                            {
                                Console.WriteLine("Paranızı alınız." + bakiye);
                                Thread.Sleep(2500);
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Hatalı tuşlama.");
                                Thread.Sleep(1500);
                            }
                        }
                        Console.WriteLine("Afiyet olsun! Mırra aldınız.");
                        bakiye -= fiyatlar[2];
                        Console.WriteLine("Kalan bakiye: " + bakiye);
                    }


                    else if (urunSecimi == "9")
                    {
                        Console.WriteLine("Eklemek istediğiniz miktar:");
                        double paraEkleme4 = Convert.ToInt32(Console.ReadLine());
                        bakiye += paraEkleme4;
                        Console.WriteLine("Güncel bakiyeniz " + bakiye);
                    }
                    else if (urunSecimi == "0")
                    {
                        Console.WriteLine("Çıkış yapılıyor...");
                        Thread.Sleep(1500);
                        Environment.Exit(0);
                    }
                //***ADMİN**
                while (urunSecimi == "sysadmin")
                {
                    Console.WriteLine("1-)Yeni ürün ekle");
                    Console.WriteLine("2-)ürün güncelle");
                    Console.WriteLine("3-)Ürün sil");
                    Console.WriteLine("4-)ürünleri listele");
                    Console.WriteLine("5-)Gün sonu al");
                    Console.WriteLine("6-)Geri dön");
                    string adminSecim = Console.ReadLine();

                    if (adminSecim == "1")
                    {
                        Console.WriteLine("Eklemek istenen ürünü yazınız");
                        string urunEkleme = Console.ReadLine();
                        Array.Resize(ref urunler, urunler.Length + 1);
                        urunler[urunler.Length - 1] = urunEkleme;

                        Console.WriteLine("Eklenen ürünün fiyatını girin");
                        double fiyatEklenen = Convert.ToDouble(Console.ReadLine());
                        Array.Resize(ref fiyatlar, fiyatlar.Length + 1);
                        fiyatlar[fiyatlar.Length - 1] = fiyatEklenen;

                        Console.WriteLine("Tüm ürünler ve fiyatlar:");
                        for (int i = 0; i < urunler.Length; i++)
                        {
                            Console.WriteLine($"{i + 1} -) {urunler[i]} = {fiyatlar[i]} TL");
                        }

                        /*
                        foreach (string item in urunler)
                        {
                            Console.WriteLine(item);
                        }
                        */

                    }
                    else if (adminSecim == "2")
                    {
                        Console.WriteLine("Güncellenmesini istediğiniz ürünü indeks numarasını yazınız");
                        int guncelleme = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Güncel ürünü yazınız.");
                        string guncellemeUrun = Console.ReadLine();
                        urunler[guncelleme] = guncellemeUrun;

                    }
                    else if (adminSecim == "3")
                    {
                        Console.WriteLine("\nSilmek istediğiniz ürünün numarasını giriniz (1-4 arası): ");
                        int silinecekUrunIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                        // Ürün geçerli bir numara mı?
                        if (silinecekUrunIndex >= 0 && silinecekUrunIndex < urunler.Length)
                        {
                            // Silinecek üründen sonraki tüm öğeleri kaydır
                            for (int i = silinecekUrunIndex; i < urunler.Length - 1; i++)
                            {
                                urunler[i] = urunler[i + 1];  // Ürün adlarını kaydır
                                fiyatlar[i] = fiyatlar[i + 1];  // Fiyatları kaydır
                            }

                            // Son öğeyi boş bırak
                            Array.Resize(ref urunler, urunler.Length - 1);
                            Array.Resize(ref fiyatlar, fiyatlar.Length - 1);

                            Console.WriteLine("\nÜrün silindi.");
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz ürün numarası.");
                        }

                        // Güncellenmiş ürünleri listele
                        Console.WriteLine("\nGüncellenmiş Ürünler ve Fiyatlar:");
                        for (int i = 0; i < urunler.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {urunler[i]} - {fiyatlar[i]} TL");
                        }
                    }
                    else if (adminSecim == "4")
                    {
                        Array.Sort(urunler);
                        foreach (string item in urunler)
                        {
                            Console.WriteLine(urunler);
                        }
                    }

                }





                }
               
            
           
          }
    }
}
