import java.math.BigInteger;
import java.util.Scanner;

public class C10CenturiesToNanoseconds {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        byte centuries = Byte.parseByte(console.nextLine());
        int years = centuries * 100;
        int days = (int) (years * 365.2422);
        long hours = (days * 24);
        long minutes = hours * 60;
        long seconds = minutes * 60;
        BigInteger miliseconds = BigInteger.valueOf(seconds * 1000);
        BigInteger microseconds = miliseconds.multiply(BigInteger.valueOf(1000));
        BigInteger nanoseconds = microseconds.multiply(BigInteger.valueOf(1000));
        System.out.printf("%d centuries = %d years = %d days = %d hours = %d minutes = " +
                "%d seconds = %d milliseconds = %d microseconds = %d" +
                " nanoseconds",centuries,years,days,hours,minutes,seconds,miliseconds,microseconds,nanoseconds);
    }
}
