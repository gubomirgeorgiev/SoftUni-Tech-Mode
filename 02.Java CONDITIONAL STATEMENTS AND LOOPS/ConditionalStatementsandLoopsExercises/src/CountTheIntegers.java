import java.util.Scanner;

public class CountTheIntegers {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int counter = 0;
        int breaker = 999;
        for (int i = 0; i < breaker; i++)
        {
            try
            {
                String input = console.nextLine();
                Integer.parseInt(input);
                counter++;
            }
            catch (NumberFormatException e)
            {
                breaker = 0;
            }
        }
        System.out.println(counter);
    }
}
