import java.util.Scanner;

public class OddNumber {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int counter = 999;
        for (int i = 0; i < counter; i++) {
            int number = Integer.parseInt(console.nextLine());
            if (number % 2 == 0) {
                System.out.println("Please write an odd number.");
            } else {
                System.out.println("The number is: " + Math.abs(number));
                counter = 0;
            }
        }
    }
}
