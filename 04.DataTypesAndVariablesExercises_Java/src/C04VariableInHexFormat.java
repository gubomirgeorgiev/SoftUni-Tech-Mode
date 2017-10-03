import java.util.Scanner;

public class C04VariableInHexFormat {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String hexadecimalFormatInput = console.nextLine();
        int inputConvertedToDecimalFormat = Integer.decode(hexadecimalFormatInput);
        System.out.println(inputConvertedToDecimalFormat);
    }
}
