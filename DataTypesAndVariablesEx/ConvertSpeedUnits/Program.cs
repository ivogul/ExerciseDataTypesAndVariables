using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            byte hours = byte.Parse(Console.ReadLine());
            byte minutess = byte.Parse(Console.ReadLine());
            byte seconds = byte.Parse(Console.ReadLine());
            int timeInSeconds = hours * 3600 + minutess * 60 + seconds;

            float metersPerSecond = (float)distanceInMeters / timeInSeconds;
            float kilometersPerHour = ((float)distanceInMeters / 1000) / ((float)timeInSeconds / 3600);
            float milesPerHour = ((float)distanceInMeters / 1609) / ((float)timeInSeconds / 3600);
            Console.WriteLine($"{metersPerSecond}");
            Console.WriteLine($"{kilometersPerHour}");
            Console.WriteLine($"{milesPerHour}");
        }
    }
}
