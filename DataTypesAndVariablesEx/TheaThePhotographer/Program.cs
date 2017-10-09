using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long picturesTaken = long.Parse(Console.ReadLine());
            long filterTimeInSeconds = long.Parse(Console.ReadLine());
            long filterFactorInPercents = long.Parse(Console.ReadLine());
            long uploadTimeInSeconds = long.Parse(Console.ReadLine());

            long goodPictures = (long) Math.Ceiling(picturesTaken * filterFactorInPercents / 100.0);
            long proceedingTimeInSeconds = (picturesTaken * filterTimeInSeconds) + (goodPictures * uploadTimeInSeconds);
            long days = proceedingTimeInSeconds / 86400; 
            long temp = proceedingTimeInSeconds % 86400; 
            long hours = temp / 3600; 
            temp = temp % 3600;
            long minutes = temp / 60; 
            temp = temp % 60;                                               
            long seconds = temp;

            Console.WriteLine($"{days}:{hours:d2}:{minutes:d2}:{seconds:d2}");
        }
    }
}
