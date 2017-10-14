import java.math.BigDecimal;
import java.time.Duration;
import java.util.Scanner;

public class C19TheaThePhotographer {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int numOfPictures = Integer.parseInt(console.nextLine());
        int filterTimeInSec = Integer.parseInt(console.nextLine());
        int fileterFactor = Integer.parseInt(console.nextLine());
        int uploadTimeInSec = Integer.parseInt(console.nextLine());
        long filteredPictures = (long)Math.ceil(numOfPictures * (fileterFactor / 100.0));
        long timeNeededToFilterAllPicturesInSec =(long)numOfPictures * filterTimeInSec;
        long timeNeededToUploadAllGoodPicturesInSec = filteredPictures * uploadTimeInSec;
        long totalTimeInSec = timeNeededToFilterAllPicturesInSec + timeNeededToUploadAllGoodPicturesInSec;
        long days = totalTimeInSec/86400;
        long hours = (totalTimeInSec-(days*86400))/3600;
        long minutes = (totalTimeInSec-(days*86400)-(hours*3600))/60;
        long seconds = totalTimeInSec-(days*86400)-(hours*3600)-(minutes*60);
        //System.out.println(days+ " "+hours+ " "+ minutes+ " " + seconds);
        String ctor = String.format("%1d:%02d:%02d:%02d", days, hours, minutes,
                seconds);
        System.out.println(ctor);
    }
}
