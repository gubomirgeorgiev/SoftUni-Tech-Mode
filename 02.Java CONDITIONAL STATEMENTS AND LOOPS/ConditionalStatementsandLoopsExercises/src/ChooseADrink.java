import java.util.Scanner;

public class ChooseADrink {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String input = console.nextLine();
        switch (input) {
            case "Athlete":
                System.out.println("Water");
                break;
            case "Businessman":
            case "Businesswoman":
                System.out.println("Coffee");
                break;
            case "SoftUni Student":
                System.out.println("Beer");
                break;
            default:
                System.out.println("Tea");
                break;
        }
    }
}
