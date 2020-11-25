using System;

namespace ConsoleApp2
{
    public class Addition
    {
        public string Name;
        public string Surname;
        public string Name_ { 
            get 
            {
                return Name;
            }
            set
            {
                Name = value;
            } 
        }
        public string Surname_
        {   
            get
            {
                return Surname;
            }
            set
            {
                Surname = value;
            }
        }
    }
    public class Airline
    {
        public string Destination;
        public string Type_Plane;
        public string flight_number;
        public string minute;
        public string hour;
        public string seconds;
        public string day;
        public string month;
        public string years;
        public string weekDay;
        public int[] Day_month = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        DateTime dt1 = new DateTime();
        public string Destination_
        {
            get
            {
                return Destination;
            }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Error cant be written");
                    fail++;
                }
                else
                    Destination = value;
            }
        }
        ///////////////////////////
        public string Type_Plane_
        {
            get
            {
                return Type_Plane;
            }
            set
            {
                if (value == "" && fail == 0)
                {
                    Console.WriteLine("Error cant be written");
                    fail++;
                }
                else
                    Type_Plane = value;
            }
        }
        ///////////////////////////
        public string flight_number_
        {
            get
            {
                return flight_number;
            }
            set
            {
                if (int.Parse(value) >= Int32.MaxValue)
                {
                    Console.WriteLine("Error cant be written");
                    fail++;
                }
                else
                    flight_number = value;
            }
        }
        ///////////////////////////
        public string minute_
        {
            get
            {
                return minute;
            }
            set
            {
                if (60 > Convert.ToInt32(value) && fail == 0)
                {
                    minute = value;
                }
                else
                {
                    Console.WriteLine("Error cant be written");
                    fail++;
                }
            }
        }
        ///////////////////////////
        public string hour_
        {
            get
            {
                return hour;
            }
            set
            {
                if (24 > Convert.ToInt32(value))
                {
                    hour = value;
                }
                else
                {
                    Console.WriteLine("Error cant be written");
                    fail++;
                }
            }
        }
        public string day_
        {
            get
            {
                return day;
            }
            set
            {
                int month = int.Parse(this.month);
                if (int.Parse(value) < 32 && Day_month[month - 1] > int.Parse(value))
                {
                    day = value;
                }
                else
                {
                    Console.WriteLine("Error cant be written");
                    fail++;
                }
            }
        }
        ///////////////////////////
        public string month_
        {
            get
            {
                return month;
            }
            set
            {
                if (int.Parse(value) < 13)
                {
                    month = value;
                }
                else
                {
                    Console.WriteLine("Error cant be written");
                    fail++;
                }
            }
        }
        ///////////////////////////
        public string years_
        {
            get
            {
                return years;
            }
            set
            {
                int year = Convert.ToInt32(time_Now.ToString("yyyy"));
                if (year > Convert.ToInt32(value))
                {
                    years = value;
                }
                else
                {
                    Console.WriteLine("Error cant be written");
                    fail++;
                }
            }
        }
        // not fact
        ///////////////////////////
        public string[] weekDays = new string[] { "Mon", "Tues", "Wed", "Thut", "Frid", "Sat", "Sund" };
        ///////////////////////////
        public string weekDay_
        {
            get
            {
                return weekDay;
            }
            set
            {
                for (int i = 0; i < 7; i++)
                {
                    if (value != weekDays[i] && fail == 0)
                    {
                        Console.WriteLine("Error cant be written");
                        fail++;
                    }
                    else
                    {
                        weekDay = value;
                        break;
                    }
                }
            }
        }
        ///////////////////////////
        public int fail = 0;
        public DateTime time_Now = DateTime.Now;
        ///////////////////////////
        public string seconds_
        {
            get
            {
                return seconds;
            }
            set
            {
                if (int.Parse(value) < 61)
                {
                    seconds = value;
                }
                else
                {
                    Console.WriteLine("Error cant be written");
                    fail++;
                }
            }
        }
        ///////////////////////////
    }
}