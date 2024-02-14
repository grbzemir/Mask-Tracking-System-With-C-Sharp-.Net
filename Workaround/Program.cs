using Business.Concrete;
using Entities.Concrete;
using System;
using System.Threading.Tasks;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            SelamVer();
            SelamVer();
            SelamVer();

            int sonuc = Topla(50);

            string ogrenci1 = "Engin";
            string ogrenci2 = "Derin";
            string ogrenci3 = "Salih";


            string[] ogrenciler = new string[4];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Derin";
            ogrenciler[2] = "Salih";
  

            ogrenciler = new string[4];
            ogrenciler[3] = "Ali";


            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Adana", "Diyarbakır" };

            //Sehirler2 nin referans numarası sehirler1 in referans numarasına eşitlendi.
            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi2 = sayi1; // 10
            //sayi1 = 30;
            //// sayi2 = 10 dur yani!
            ///
            
            Person person1 = new Person();
            person1.FirstName = "Emircan Yetkin";
            person1.LastName = "Gürbüz";
            person1.DateOfBirthYear = 2003;
            person1.NationalId = 123456789;


            Person person2 = new Person();
            person2.FirstName = "Derin";
            person2.LastName = "Demiroğ";
            person2.DateOfBirthYear = 2005;
            person2.NationalId = 123456789;


            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }


            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Bursa");

            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
  
        }

        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Selam" + isim);
        }

        static int Topla(int sayi1 = 5 , int sayi2 = 10)

        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : "+ sonuc.ToString());
            return sonuc;
        }


    }

}


