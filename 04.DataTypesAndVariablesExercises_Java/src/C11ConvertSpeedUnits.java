import java.text.DecimalFormat;
import java.util.Scanner;

public class C11ConvertSpeedUnits {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int distanceInMeters = Integer.parseInt(console.nextLine());
        int hours = Integer.parseInt(console.nextLine());
        int minutes = Integer.parseInt(console.nextLine());
        int seconds = Integer.parseInt(console.nextLine());
        int timeInSeconds;
        if (hours==0){
            timeInSeconds = (minutes*60)+seconds;

        }else {
            timeInSeconds = (hours * 3600) + ((minutes * 60) + seconds);
        }
        float speedMetersPerSecond = (float) Math.floorDiv((distanceInMeters ), (timeInSeconds));
        float speedKilometersPerHour = (float)Math.floorDiv((distanceInMeters / 1000) , (timeInSeconds / 3600));
        float speedMilesPerHour =(float) Math.floorDiv((distanceInMeters / 1609), (timeInSeconds / 3600));
        /*DecimalFormat formatterBiggerThanTen = new DecimalFormat("##.#####");
        DecimalFormat formatterSmallerThanTen = new DecimalFormat("#.######");
        float speedMetersPerSecondFormated = Float.parseFloat((speedMetersPerSecond>=10)?Math.r(speedMetersPerSecond):formatterSmallerThanTen.format(speedMetersPerSecond));
        float speedKilometersPerHourFormated = Float.parseFloat((speedKilometersPerHour>=10)?formatterBiggerThanTen.format(speedKilometersPerHour):formatterSmallerThanTen.format(speedKilometersPerHour));
        float speedMilesPerHourdFormated = Float.parseFloat((speedMilesPerHour>=10)?formatterBiggerThanTen.format(speedMilesPerHour):formatterSmallerThanTen.format(speedMilesPerHour));*/
        System.out.printf("%f%n%f%n%f",speedMetersPerSecond,speedKilometersPerHour,speedMilesPerHour);
    }
}
