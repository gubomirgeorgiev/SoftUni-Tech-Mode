import sun.nio.cs.SingleByte;

import java.util.Scanner;

public class C18DifferentIntegersSize {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String inputInteger = console.nextLine();
        SingleByte svyteValue;
        byte byteValue;
        short shortValue;
        int intValue;
        long uintValue;
        long longValue;
        try {
            if (Byte.parseByte(inputInteger)){

            }

            System.out.println(inputInteger);
            shortValue = Short.parseShort(inputInteger);
            intValue = Integer.parseInt(inputInteger);
            uintValue = Long.parseLong(inputInteger);
        }
        catch (NumberFormatException e)
        {
            System.out.printf("%s can't fit in any type", inputInteger);
        }
    }
}
