import java.math.BigDecimal;
import java.util.Scanner;

public class C03ExactSumOfRealNumbers {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        BigDecimal sum = new BigDecimal(0);
        int nNumbers = Integer.parseInt(console.nextLine());
        for (int i = 0; i < nNumbers; i++)
        {
            BigDecimal input = console.nextBigDecimal();
            sum = sum.add(new BigDecimal(String.valueOf(input)));
        }
        System.out.print(sum);
    }
}
