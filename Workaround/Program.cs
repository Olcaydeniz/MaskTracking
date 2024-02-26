using Entities.Concrete;
using System;
using System.Globalization;
using System.Transactions;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {

            Citizen citizen = new Citizen();

            Message(name:"olcay");
            Message(name:"Deniz");
            Message(name:"Upss");
            Message();


            int result = Total(1, 4);


            string ogrenci1 = "Olcay";
            string ogrenci2 = "Deniz";
            string ogrenci3 = "Engin";
            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);


            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Deniz";
            ogrenciler[1] = "Olcay";
            ogrenciler[2] = "Demiroğ";
            ogrenciler = new string[4];
            ogrenciler[3] = "aaa";
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }



            //Ref
            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] {"Bursa","Antalya","Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            //Ref
            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi2 = sayi1;
            //sayi1 = 30;
            //Console.WriteLine(sayi2);

            
            Person person1 = new Person();
            person1.FirstName = "Olcay";

            Person person2 = new Person();
            person2.FirstName = "Deniz";

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }
            //new list desing
            //generic 
            List<string> yeniSehirler1 =new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add(item:"Adana 1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            Console.ReadLine();
        }
        static void Message(string name="noname") 
        {
            Console.WriteLine("Hello"+ name);
        }

        static int Total(int number1 , int number2)
        {
            int result = number1 + number2;
            Console.WriteLine("Total :"+ result.ToString());
            return result;
        }

        



        private static void variable()
        {
            string message = "Hello";
            double price = 10000;
            int number = 100;
            bool isLgin = false;

            //string name = "Olcay";
            //string surname = "Deniz";
            //int birthyear = 2000;
            //long id = 1234567890;
        }
    }
   
    // 'aB' syntax pascal casing
    public class Citizen
    {
        //old
          //public string name = "Olcay";
          //public string surname = "Deniz";
          //public int birthyear = 2000;
          //public long id = 1234567890;
        //new  property
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateOfBirthYear { get; set; }
        public long NationalIdentity { get; set; }
        
    }
}
