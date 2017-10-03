using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P19TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPictures = int.Parse(Console.ReadLine());
            int filterTimeInSec = int.Parse(Console.ReadLine());
            int fileterFactor = int.Parse(Console.ReadLine());
            int uploadTimeInSec = int.Parse(Console.ReadLine());
            long filteredPictures = (long)Math.Ceiling(numOfPictures * (fileterFactor / 100.0));
            long timeNeededToFilterAllPicturesInSec =(long)numOfPictures * filterTimeInSec;
            long timeNeededToUploadAllGoodPicturesInSec = filteredPictures * uploadTimeInSec;
            long totalTimeInSec = timeNeededToFilterAllPicturesInSec + timeNeededToUploadAllGoodPicturesInSec;
            TimeSpan elapsedTime = TimeSpan.FromSeconds(totalTimeInSec);
            string ctor = String.Format("{0:D1}:{1:D2}:{2:D2}:{3:D2}", elapsedTime.Days, elapsedTime.Hours, elapsedTime.Minutes, elapsedTime.Seconds);
            Console.WriteLine(ctor);
        }
    }
}
