import java.math.BigInteger;
import java.util.Scanner;
public class C01PracticeIntegers {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        byte sbyteValue = Byte.parseByte(console.nextLine());
        short byteValue = Short.parseShort(console.nextLine());
        short shortValue = Short.parseShort(console.nextLine());
        int ushortValue = Integer.parseInt(console.nextLine());
        long uintValue = Long.parseLong(console.nextLine());
        long intValue = Long.parseLong(console.nextLine());
        BigInteger longValue = BigInteger.valueOf(Long.parseLong(console.nextLine()));
        System.out.print(sbyteValue);
        System.out.println();
        System.out.print(byteValue);
        System.out.println();
        System.out.print(shortValue);
        System.out.println();
        System.out.print(ushortValue);
        System.out.println();
        System.out.print(uintValue);
        System.out.println();
        System.out.print(intValue);
        System.out.println();
        System.out.print(longValue);
    }
}
