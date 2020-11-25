using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        private static void add(List<Airline> newlist, string Destination, string flight_number , string Type_Plane, int i, Airline air)
        {
            air.Destination_ = Destination;
            air.flight_number_ = flight_number;
            air.Type_Plane_ = Type_Plane;
            newlist.Add(air);
        }
        private static void Show(List<Airline> newlist, int i)
        {
            Console.WriteLine("Destination:\t" + newlist[i].Destination);
            Console.WriteLine("flight number:\t" + newlist[i].flight_number);
            Console.WriteLine("Type Plane:\t" + newlist[i].Type_Plane);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Random rnd = new Random();
            
            int value = rnd.Next();
            string[] month = { "January", "February", "March", "April", "May", "June", "July" , "August", "September", "October" , "November" , "December" };
            string[] array = { "December", "January", "February", "June", "July", "August" };
            int[] numbers1 = { -3, -2, -1, 0, 1, 2, 3 };
            var result_ = numbers1.Skip(4).Take(3);
            foreach (int i in result_)
                Console.Write(i + ", ");
            Console.WriteLine("\n--------------------------------------------------------------------------");

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int size = (from i in numbers where i % 2 == 0 && i > 5 select i).Count();
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine(size);
            int size_ = numbers.Max();
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine(size_);
            int size_1 = numbers.Min();
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine(size_1);
            int size_2 = (int)numbers.Average();
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine(size_2);
            var numbers_ = numbers.Skip(4);
            foreach (var i in numbers_)
                Console.Write(i + ", ");
            Console.WriteLine("\n--------------------------------------------------------------------------");
            var sequence = month.Where(p => p.Length == 6);     //amount value
            var result = month.Intersect<string>(array);
            var OrederBty = from t in month
                            orderby t
                            select t;
            var u = from t in month
                    where t.Contains("u") & t.Length > 4
                    select t;
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n--------------------------------------------------------------------------");
            Console.WriteLine($"Length n: 6");
            foreach (var i in sequence)
                Console.WriteLine(i);
            Console.WriteLine("--------------------------------------------------------------------------\nAfter sort");
            month.OrderBy(x => x);
            foreach (var i in month)
                Console.Write(i + ", ");

            Console.WriteLine("\n--------------------------------------------------------------------------");
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            List<Airline> newlist = new List<Airline>();
            string[] arrdest = { "Minsk", "Moskow", "New York", "Dybai", "Warshawa", "Berlin", "London", "Paris" };
            for (int i = 0; i < 8; i++)
            {
                Airline air = new Airline();
                string val = rnd.Next().ToString();
                add(newlist, arrdest[i], val, "Boeing", i , air);
            }
            for (int i = 0; i < 8; i++)
            {
               Console.WriteLine("--------------------------------------------------------------------------");
               Show(newlist, i);
               Console.WriteLine("--------------------------------------------------------------------------");
            }
            IEnumerable<Airline> quest3_1 = newlist.Where(s => s.Destination == "Minsk");
            IEnumerable<Airline> quest3_2 = newlist.Where(t => t.Type_Plane == "Boeing");
            IEnumerable<Airline> quest3_3 = newlist.Where(t => int.Parse(t.flight_number) >= 1000000000);
            quest3_1 = from t in newlist
                       where t.Destination == "Minsk" & int.Parse(t.flight_number) >= 10000
                       select t;
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("--------------------------------------------------------------------------\nTask 1:");
            Console.WriteLine("Destinition|\tFlight number|\tType Plane|");
            foreach (var i in quest3_1)
                Console.Write(i.Destination + ",  \t" + i.flight_number + ",  \t" + i.Type_Plane + "\n");
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("--------------------------------------------------------------------------\nTask 2:");
            Console.WriteLine("Destinition|\tFlight number|\tType Plane|");
            foreach (var i in quest3_2)
                Console.Write(i.Destination + ",  \t" + i.flight_number + ",  \t" + i.Type_Plane + "\n");
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("--------------------------------------------------------------------------\nTask 3:");
            Console.WriteLine("Destinition|\tFlight number|\tType Plane|");
            foreach (var i in quest3_3)
                Console.Write(i.Destination + ",  \t" + i.flight_number + ",  \t" + i.Type_Plane + "\n");
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            List<Addition> list = new List<Addition>()
            {
                new Addition{ Name = "Vladislav" , Surname = "kurdinov"},
                new Addition{ Name = "Vasiliy" , Surname = "Kormon"},
                new Addition{ Name = "Solomon" , Surname = "Warpov"},
                new Addition{ Name = "Mihael" , Surname = "Krikylin"},
                new Addition{ Name = "Artem" , Surname = "Novokov"},
                new Addition{ Name = "Dmitry" , Surname = "Shimonikov"},
                new Addition{ Name = "Lisa" , Surname = "Kuchukina"},
                new Addition{ Name = "Anton" , Surname = "Kilimov"}
            };
            var Result_ = newlist.Join(list,
                    s => s.Destination_,
                    p => p.Name_,
                    (s, p) => new { s.Destination, s.flight_number, s.Type_Plane, p.Name, p.Surname });
            Console.WriteLine("--------------------------------------------------------------------------\nTask 5:");
            Console.WriteLine("Destinition|\tName|\tSurname|");
            foreach (var i in Result_)
                Console.Write(i.Destination + ",  \t" + ",  \t" + i.Name + ",  \t" + i.Surname + "\n");
            Console.WriteLine("--------------------------------------------------------------------------");
        }
    }
}