import java.util.Scanner;

public class C15FastPrimeChecker {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int tailRangeNumber = Integer.parseInt(console.nextLine());
        for (int number = 2; number <= tailRangeNumber; number++)
        {
            boolean result = true;
            for (int divider = 2; divider <= Math.sqrt(number); divider++)
            {
                if (number % divider == 0) {
                    result = false;
                    break;
                }
            }
            System.out.printf("%d -> %s%s%n",number,Character.toString(String.valueOf(result).charAt(0)).toUpperCase(),
                    String.valueOf(result).substring(1,String.valueOf(result).length()));
        }
    }
}
