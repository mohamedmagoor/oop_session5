using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass05oop
{
    internal class Duration
    {
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Duration other = (Duration)obj;
            return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
        public override string ToString()
        {
            return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
        }
        private void Normalize()
        {
            if (Seconds >= 60)
            {
                Minutes += Seconds / 60;
                Seconds %= 60;
            }
            if (Minutes >= 60)
            {
                Hours += Minutes / 60;
                Minutes %= 60;
            }
        }
        public void Display()
        {
            Console.WriteLine(this.ToString());
        }

        public void AddSeconds(int seconds)
        {
            Seconds += seconds;
            Normalize();
        }

        // start overloding the operators.....
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
        }

        // Overload the + operator to add seconds to a Duration object
        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.Hours, d.Minutes, d.Seconds + seconds);
        }

        // Overload the + operator to add seconds to a Duration object in reverse order
        public static Duration operator +(int seconds, Duration d)
        {
            return d + seconds;
        }

        // Overload the ++ operator to increase the Duration by one minute
        public static Duration operator ++(Duration d)
        {
            return new Duration(d.Hours, d.Minutes + 1, d.Seconds);
        }

        // Overload the -- operator to decrease the Duration by one minute
        public static Duration operator --(Duration d)
        {
            return new Duration(d.Hours, d.Minutes - 1, d.Seconds);
        }

        // Overload the - operator to subtract two Duration objects
        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration(d1.Hours - d2.Hours, d1.Minutes - d2.Minutes, d1.Seconds - d2.Seconds);
        }

        // Overload the > operator to compare two Duration objects
        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() > d2.TotalSeconds();
        }

        // Overload the < operator to compare two Duration objects
        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() < d2.TotalSeconds();
        }

        // Overload the >= operator to compare two Duration objects
        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() >= d2.TotalSeconds();
        }

        // Overload the <= operator to compare two Duration objects
        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() <= d2.TotalSeconds();
        }

        // Overload the true operator to check if a Duration is non-zero
        public static bool operator true(Duration d)
        {
            return d.Hours != 0 || d.Minutes != 0 || d.Seconds != 0;
        }

        // Overload the false operator to check if a Duration is zero
        public static bool operator false(Duration d)
        {
            return d.Hours == 0 && d.Minutes == 0 && d.Seconds == 0;
        }

        // Implicit conversion from Duration to DateTime
        public static implicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        }

        // Helper method to get the total seconds of the Duration
        private int TotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }


    }
}
