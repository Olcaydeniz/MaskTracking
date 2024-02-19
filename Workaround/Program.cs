using System;
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


            Console.ReadLine();
        }
        static void Message(string name="noname") // void verilen işi yapar
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
