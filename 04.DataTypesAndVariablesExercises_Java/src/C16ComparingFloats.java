import java.math.BigDecimal;
import java.util.Scanner;

public class C16ComparingFloats {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);{
            BigDecimal numberA = console.nextBigDecimal();
            BigDecimal numberB = console.nextBigDecimal();
            numberA.abs();
            numberB.abs();
            BigDecimal maxEpsilon = numberA.max(numberB);
            BigDecimal minEpsilon = (numberA.min(numberB));
            BigDecimal minValue = new BigDecimal(0.000001);
            if ((maxEpsilon.subtract(minEpsilon)).compareTo(minValue)<0.000001F)
            {
                System.out.println("True");
            }
            else
            {
                System.out.println("False");
            }
        }

}
}
