import java.util.Scanner;

public class NumberChecker {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        try
        {
            String input = console.nextLine();
            int i = Integer.parseInt(input);
            System.out.println("It is a number.");
        }
        catch (NumberFormatException e)
        {
            System.out.println("Invalid input!");
        }
    }
}
