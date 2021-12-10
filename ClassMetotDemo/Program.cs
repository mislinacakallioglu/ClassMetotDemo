using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.TC = "19832876567";
            musteri1.Name = "Mislina Çakallıoğlu";
            musteri1.Email = "mislinacakallioglu@gmail.com";
            musteri1.Password = "12345";
            musteri1.PhoneNumber = "05413520646";
            musteri1.DateOfBirth = "26.12.1999";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.TC = "56787523409";
            musteri2.Name = "Gizem Nakışlı";
            musteri2.Email = "gizemnakisli@gmail.com";
            musteri2.Password = "gizem12";
            musteri2.PhoneNumber = "05368740980";
            musteri2.DateOfBirth = "06.01.2001";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.TC = "19765864789";
            musteri3.Name = "Ali Enes Çakallıoğlu";
            musteri3.Email = "alienes@gmail.com";
            musteri3.Password = "alins123";
            musteri3.PhoneNumber = "05069748634";
            musteri3.DateOfBirth = "02.01.1995";

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3};

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri2);
            Console.WriteLine("----------------------");
            musteriManager.Delete(musteri3);
            Console.WriteLine("----------------------");
            musteriManager.List(musteriler);

            musteriManager.Add2("Mislina Çakallıoğlu", "mislinacakallioglu@gmail.com");
            musteriManager.Add2("Gizem Nakışlı", "gizemnakisli@gmail.com");
            musteriManager.Add2("Ali Enes Çakallıoğlu", "alienes@gmail.com");


        }
    }
}
