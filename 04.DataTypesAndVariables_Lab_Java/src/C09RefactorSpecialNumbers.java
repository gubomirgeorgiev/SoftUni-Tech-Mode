import java.util.Scanner;

public class C09RefactorSpecialNumbers {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int length = Integer.parseInt(console.nextLine());
        for (int num = 1; num <= length; num++)
        {
            int sumOfDigits = 0;
            int digit = num;
            while (digit > 0)
            {
                sumOfDigits += digit % 10;
                digit /= 10;
            }
            boolean result = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
            System.out.printf("%d -> %s ",num,result);
        }
    }
}
