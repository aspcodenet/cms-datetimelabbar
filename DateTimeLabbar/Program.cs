using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeLabbar
{
    class Program
    {
        static void Lab1()
        {
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:SS"));
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd"));
        }
        static void Lab2()
        {
            var dt = DateTime.Now;

            Console.WriteLine($@"year = {dt.Year}                                                                      
month = {dt.Month}                                                                        
day = {dt.Day}                                                                         
hour = {dt.Hour}                                                                         
minute = {dt.Minute}                                                                      
second = {dt.Second}                                                                      
millisecond = {dt.Millisecond}   ");
            
        }

        static void Lab3()
        {
            DateTime dt = DateTime.Now;
            string veckoDagsString = dt.DayOfWeek.ToString();

            Console.WriteLine($"Dagens veckodag är {veckoDagsString}");

            string inSwedish = "";
            switch(dt.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    inSwedish = "Måndag";
                    break;
                case DayOfWeek.Tuesday:
                    inSwedish = "Tisdag";
                    break;
                case DayOfWeek.Wednesday:
                    inSwedish = "Onsdag";
                    break;
                case DayOfWeek.Thursday:
                    inSwedish = "Torsdag";
                    break;
                case DayOfWeek.Friday:
                    inSwedish = "Fredag";
                    break;
                case DayOfWeek.Saturday:
                    inSwedish = "Lördag";
                    break;
                case DayOfWeek.Sunday:
                    inSwedish = "Söndag";
                    break;

            }

        }

        static void Lab4()
        {
            Console.WriteLine($"Today is {DateTime.Now.ToString("yyyy-mm-dd HH:mm:SS")}");

            DateTime dt = DateTime.Now.AddDays(40);
            Console.WriteLine($"40 days from now is {dt.DayOfWeek.ToString()}");
            Console.WriteLine(dt.ToString("yyyy-mm-dd HH:mm:SS"));
        }

        static void Lab5()
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString("yyyy-MM-dd"));
            for (var i = 0; i < 10; i++)
            {
                dt = dt.AddDays(40);
                Console.WriteLine(dt.ToString("yyyy-MM-dd"));
            }
        }

        static Random rnd = new Random();
        static void Lab7()
        {
            //DateTime d = new DateTime(rnd.Next(1970,2016),rnd.Next(1,12), rnd.Next(1,28));
            DateTime d = DateTime.Now;

            var oneMonthForward = new DateTime(d.Year, d.Month, d.Day).AddMonths(1);
            var firstOfThat = new DateTime(oneMonthForward.Year, oneMonthForward.Month, 1);
            var lastOfBefore = firstOfThat.AddDays(-1);

            Console.WriteLine($"Year is {lastOfBefore.Year}, month is {lastOfBefore.Month} and it has {lastOfBefore.Day} days");

        }

        static void Lab8()
        {
            DateTime dq = new DateTime(rnd.Next(1970, 2016), rnd.Next(1, 12), rnd.Next(1, 28));
            DateTime dw = new DateTime(rnd.Next(1970, 2016), rnd.Next(1, 12), rnd.Next(1, 28));

            TimeSpan sp = dq - dw;

            Console.WriteLine(dq.ToString("yyyy-mm-dd"));
            Console.WriteLine(dw.ToString("yyyy-mm-dd"));
            Console.WriteLine($"difference is {sp.TotalDays} days");

        }

        static void Lab6()
        {
            Console.Write("Ange datum:");
            string txt = Console.ReadLine();
            DateTime dt = DateTime.ParseExact(txt, "yyyy-MM-dd", 
                System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine(dt.ToString("yyyy-MM-dd"));
        }

        static void Lab9()
        {
            Console.Write("Ange år:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ange månad(1-12):");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ange day(1-31):");
            int day = Convert.ToInt32(Console.ReadLine());

            var inputDate = new DateTime(year, month, day);

            if(DateTime.Now.Date == inputDate)
            {
                Console.WriteLine("Detta är idag");
            }
            else
                Console.WriteLine("Detta är INTE idag");
        }


        static void Main(string[] args)
        {
            Lab5();
            //Lab1();
            //Lab2();
            Lab3();
            //Lab4();
            Lab5();
            Lab6();
            //for(int i =0; i < 100; i++)
            //    Lab7();

            //Lab8();
            Lab9();
            Console.ReadLine();
        }
    }
}
