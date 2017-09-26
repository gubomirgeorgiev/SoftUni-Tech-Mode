import java.util.Scanner;

public class DebitCardNumber {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int firstFourDigits = Integer.parseInt(console.nextLine());
        int secondFourDigits = Integer.parseInt(console.nextLine());
        int thirdFourDigits = Integer.parseInt(console.nextLine());
        int fourthFourDigits = Integer.parseInt(console.nextLine());
        System.out.printf("%04d %04d %04d %04d", firstFourDigits, secondFourDigits, thirdFourDigits, fourthFourDigits);
    }
}
