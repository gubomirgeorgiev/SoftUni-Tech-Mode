import javafx.util.StringConverter;
import javafx.util.converter.BigDecimalStringConverter;

import java.math.BigDecimal;
import java.text.DecimalFormat;
import java.util.Objects;
import java.util.Scanner;

public class C02PracticeFloatingPoints {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String a = console.nextLine();
        BigDecimal firstNumber = new BigDecimal(a);
        double secondNumber = Double.parseDouble(console.nextLine());
        BigDecimal thirdNumber = console.nextBigDecimal();
        System.out.println(firstNumber);
        System.out.println(secondNumber);
        System.out.println(thirdNumber);
    }
}
