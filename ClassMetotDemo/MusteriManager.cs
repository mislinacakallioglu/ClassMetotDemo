using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void List(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Id: " + musteri.Id);
                Console.WriteLine("Müşteri TC:" + musteri.TC);
                Console.WriteLine("Müşteri Adı Soyadı:" + musteri.Name);
                Console.WriteLine("Müşteri Email: " + musteri.Email);
                Console.WriteLine("Müşteri Şifre: " + musteri.Password);
                Console.WriteLine("Müşteri Numara: " + musteri.PhoneNumber);
                Console.WriteLine("Müşteri Doğum Tarihi: " + musteri.DateOfBirth);
                Console.WriteLine("-------------------------------");
            }
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Name + " " + " " + "Müşteri sistemden silindi.");

        }
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.TC + " " + musteri.Name + " " + musteri.Email + " " + musteri.Password + " " + musteri.PhoneNumber + " " + musteri.DateOfBirth + " " + "Müşteri sisteme eklendi.");

        }
        public void Add2(string musteriName, string musteriEmail)
        {
            Console.WriteLine("Müşteri sisteme eklendi:" + " " + musteriName + " " + musteriEmail);
        }
    }
}
