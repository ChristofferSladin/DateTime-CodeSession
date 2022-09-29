using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_CodeSession
{
    internal class App
    {
        public void Idag()
        {
            Console.WriteLine("Mata in år i formatet yyyy");
            var year = int.Parse(Console.ReadLine());
            Console.WriteLine("Mata in månad i formatet mm");
            var month = int.Parse(Console.ReadLine());
            Console.WriteLine("Mata in dag i formatet dd");
            var day = int.Parse(Console.ReadLine());

            var combinedDate = new DateTime(year, month, day);
            if (DateTime.Now.ToString("yyyy-MM-dd") == combinedDate.ToString("yyyy-MM-dd"))
            {
                Console.WriteLine("Detta är idag");
            }
            else
                Console.WriteLine($"Det inmatade datumet är inte idag");
        }

        public void DateDiff()
        {
            Console.WriteLine("Ange ett datum i formatet yyyy-mm-dd");
            var input = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", CultureInfo.CurrentCulture);
            Console.WriteLine("Ange ett till datum i formatet yyyy-mm-dd");
            var input2 = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", CultureInfo.CurrentCulture);

            var diff = input - input2;

            Console.WriteLine($"Det är {diff} dagar mellan datumen");
        }
        public void Datum5()
        {
            Console.Write("Ange ett år: ");
            var inputYear = int.Parse(Console.ReadLine());
            
            Console.Write("Ange en månad: ");
            var inputMonth = int.Parse(Console.ReadLine());
            
            int daysInMonth = DateTime.DaysInMonth(inputYear, inputMonth);
            Console.WriteLine(daysInMonth);
        }
        public void Datum4()
        {
            Console.WriteLine("Mata in ett datum i formatet yyyy-mm-dd");
            var input = Console.ReadLine();

            var date = DateTime.ParseExact(input, "yyyy-MM-dd", CultureInfo.CurrentCulture); // koverterar string till datetime struct

            Console.WriteLine(date);
        }

        public void Datum3()
        {
            var todaysDate = DateTime.Now;

            Console.WriteLine($"idag är det {todaysDate.DayOfWeek} den {todaysDate.ToString("dd")} " +
                $"{todaysDate.ToString("MMMM", CultureInfo.CurrentCulture)} {todaysDate.ToString("yyyy")}");

            Console.WriteLine("Ange x antal dagar");
            var addedDays = int.Parse(Console.ReadLine());

            todaysDate = todaysDate.AddDays(addedDays);
            Console.WriteLine($"Om {addedDays} dagar är det {todaysDate.DayOfWeek} den {todaysDate.ToString("dd")} " +
                $"{todaysDate.ToString("MMMM", CultureInfo.CurrentCulture)} {todaysDate.ToString("yyyy")}");
        }
        public void Datum2()
        {
            var todaysDate = DateTime.Now;
            var todaysDateDay = todaysDate.DayOfWeek;
            var todaysDateMonth = todaysDate.Month;
            var todaysDateYear = todaysDate.Year;
            var todaysDateHour = todaysDate.Hour;
            var todaysDateMinute = todaysDate.Minute;
            var todaysDateSecond = todaysDate.Second;

            Console.WriteLine($"full: {todaysDate}\nday: {todaysDateDay}\nmonth: {todaysDateMonth}\nyear: {todaysDateYear}\nhour: {todaysDateHour}\n" +
                $"minute: {todaysDateMinute}\nsecond: {todaysDateSecond}");

            switch (todaysDateMonth)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
            }
            switch (todaysDateDay)
            {
                case (DayOfWeek)1:
                    Console.WriteLine("Monday");
                    break;
                case (DayOfWeek)2:
                    Console.WriteLine("Tuesday");
                    break;
                case (DayOfWeek)3:
                    Console.WriteLine("Wendsday");
                    break;
                case (DayOfWeek)4:
                    Console.WriteLine("Thursday");
                    break;
                case (DayOfWeek)5:
                    Console.WriteLine("Friday");
                    break;
                case (DayOfWeek)6:
                    Console.WriteLine("Saturday");
                    break;
                case (DayOfWeek)7:
                    Console.WriteLine("Sunday");
                    break;
            }
        }

        public void Datum1()
        {
            var todaysDate = DateTime.Now;
            var todaysDateFull = todaysDate.ToString("yyyy-MM-dd hh:mm:ss");
            var todaysDateShort = todaysDate.ToString("yyyy-MM-dd");

            Console.WriteLine($"Dagens datum: {todaysDateShort}\nDagens datum och tid: {todaysDateFull}");
        }
        public void CalculateDaysToChristmasVacation()
        {
            var vacationStarts = new DateTime(2022 - 12 - 21);

            Console.WriteLine("Ange dagens datum i format yyyy-MM-dd");
            var input = Console.ReadLine();

            var date = DateTime.ParseExact(input, "yyyy-MM-dd", CultureInfo.CurrentCulture); // NEEDED

            var diff = date - vacationStarts;
            Console.WriteLine($"Håll ut Det är {diff} dagar kvar till lovet");
        }

        public void InVoice()
        {
            var fakturaDag = DateTime.Now;
            Console.WriteLine($"Fakturadag: {fakturaDag.ToString("yyyy - MM - dd")}");

            var forFalloDag = fakturaDag.AddDays(30);
            Console.WriteLine($"Förfallo Dag: {forFalloDag.ToString("yyyy - MM - dd")}");

            if (forFalloDag.DayOfWeek == DayOfWeek.Saturday)
                forFalloDag = forFalloDag.AddDays(-1); // friday
            else if (forFalloDag.DayOfWeek == DayOfWeek.Sunday)
                forFalloDag = forFalloDag.AddDays(1); // monday

            Console.WriteLine($"Förfallo Dag: {forFalloDag.ToString("yyyy - MM - dd")}");
        }
        public void SkrivUTDatum()
        {
            var today = DateTime.Now;
            var snyggtDatum = today.ToString("yyyy-MM-dd");
            Console.WriteLine(snyggtDatum);
        }
        public string GetSwedishWeekDayName(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:

                    return "Måndag";

                case DayOfWeek.Tuesday:

                    return "Tisdag";

                case DayOfWeek.Wednesday:

                    return "Onsdag";

                case DayOfWeek.Thursday:

                    return "Torsdag";

                case DayOfWeek.Friday:

                    return "Fredag";

                case DayOfWeek.Saturday:

                    return "Lördag";

                default:
                    DayOfWeek sunday = DayOfWeek.Sunday;
                    return "Söndag";
            }
        }

        public void DayCounter()
        {
            Console.WriteLine("Ange ditt födelseår");
            var year = int.Parse(Console.ReadLine());

            Console.WriteLine("Ange din födelsemånad");
            var month = int.Parse(Console.ReadLine());

            Console.WriteLine("Ange din födelsedag");
            var day = int.Parse(Console.ReadLine());

            var yourBirthDay = new DateTime(year, month, day);

            Console.WriteLine($"Du är född en {yourBirthDay.DayOfWeek}");
            var nameInSedish = GetSwedishWeekDayName(yourBirthDay.DayOfWeek);
            Console.WriteLine($"På svenska: {nameInSedish}");

            if (yourBirthDay.DayOfWeek == DayOfWeek.Sunday || yourBirthDay.DayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine($"Du är född en helg");
            }

            var today = DateTime.Now;
            var diff = today - yourBirthDay;

            Console.WriteLine($"Du är {Convert.ToInt32(diff.TotalDays)} gammal. Har du använt dom väl?");
        }
        public void Run()
        {
            //DayCounter();
            //SkrivUTDatum();
            //InVoice();
            //CalculateDaysToChristmasVacation();
            //Datum1();
            //Datum2();
            //Datum3();
            //Datum4();
            //Datum5();
            //DateDiff();
            //Idag();
        }
    }
}
